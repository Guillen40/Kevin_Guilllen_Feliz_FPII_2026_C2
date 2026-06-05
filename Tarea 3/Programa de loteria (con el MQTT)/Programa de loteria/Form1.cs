using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using Newtonsoft.Json;

namespace Programa_de_loteria
{
    public partial class Form1 : Form
    {
        // variable global
        private IMqttClient mqttClient;

        public Form1()
        {
            InitializeComponent();

            // para conectar con el servidor
            _ = ConectarMQTT();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Generador de numeros random
            Random random = new Random();

            // validacion de numero
            if (!int.TryParse(tBox1.Text, out int numeroJugado) || numeroJugado < 1 || numeroJugado > 99)
            {
                MessageBox.Show("Por favor, ingresa un numero valido del 1 al 99.", "Error de numero");
                return;
            }

            if (!decimal.TryParse(tBox2.Text, out decimal dineroApostado) || dineroApostado <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad de dinero valida.", "Error de dinero");
                return;
            }

            // Donde aparecen los numeros
            int primera = random.Next(1, 100);
            int segunda = random.Next(1, 100);
            int tercera = random.Next(1, 100);
            tBox5.Text = primera.ToString();
            tBox4.Text = segunda.ToString();
            tBox3.Text = tercera.ToString();

            // multiplicacion del premio
            decimal premio = 0;

            if (numeroJugado == primera)
            {
                premio = dineroApostado * 1000;
            }
            else if (numeroJugado == segunda)
            {
                premio = dineroApostado * 100;
            }
            else if (numeroJugado == tercera)
            {
                premio = dineroApostado * 10;
            }

            tBox6.Text = premio.ToString("C");

            // BLOQUE MQTT: ENVIAR RESULTADO AL CLIENTE EN LA CALLE

            try
            {
                // 1. Verificar si el cliente MQTT esta conectado antes de mandar
                if (mqttClient != null && mqttClient.IsConnected)
                {
                    // Extraemos el nombre del cliente que guardamos provisionalmente en el titulo de la ventana
                    string idClienteActual = this.Text.Replace("Loteria - Jugada de: ", "");

                    // Si el titulo no tiene un cliente real (porque se jugo local), usamos uno por defecto
                    if (string.IsNullOrEmpty(idClienteActual) || idClienteActual.StartsWith("Loteria") || idClienteActual.StartsWith("Ludopatas"))
                    {
                        idClienteActual = "Cliente_Local";
                    }

                    // 2. Llenar plantilla con los datos frescos de la apuesta
                    // USE LA CONVERSION SEGURA PARA EVITAR EL ERROR DE FORMATO
                    ResultadoJugada resultado = new ResultadoJugada
                    {
                        IdCliente = idClienteActual,
                        NumerosGanadores = $"1ro: {tBox3.Text} | 2do: {tBox4.Text} | 3ro: {tBox5.Text}",
                        PremioGanado = int.TryParse(tBox6.Text.Replace("$", "").Replace("RD$", "").Replace(" ", "").Split('.')[0].Trim(), out int premioLimpio) ? premioLimpio : 0
                    };

                    // 3. Convertimos el objeto C# a un texto JSON
                    string jsonResultado = JsonConvert.SerializeObject(resultado);

                    // 4. Creamos el mensaje MQTT listo para viajar por la red
                    var mensaje = new MqttApplicationMessageBuilder()
                        .WithTopic("itla/loteria/resultados") // Topico de salida para los clientes
                        .WithPayload(jsonResultado)
                        .WithExactlyOnceQoS()
                        .Build();

                    // 5. Lo lanzamos de manera asincrona a internet
                    Task.Run(async () => await mqttClient.PublishAsync(mensaje));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar el resultado por MQTT: " + ex.Message);
            }
            // que lucha mano
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // limpiar entradas
            tBox1.Text = "";
            tBox2.Text = "";

            // Limpiar casillas
            tBox5.Text = "";
            tBox3.Text = "";
            tBox4.Text = "";

            // Limpiar el premio
            tBox6.Text = "";
        }

        private async Task ConectarMQTT()
        {
            var factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithClientId("Servidor_Ludopatas_" + Guid.NewGuid().ToString().Substring(0, 5)) // ID unico para evitar clones
                .WithTcpServer("broker.hivemq.com", 1883)
                .WithCleanSession()
                .Build();

            mqttClient.UseApplicationMessageReceivedHandler(async e =>
            {
                string payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);

                this.Invoke((MethodInvoker)delegate
                {
                    ProcesarJugadaEntrante(payload);
                });
            });

            try
            {
                await mqttClient.ConnectAsync(options, System.Threading.CancellationToken.None);
                await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic("itla/loteria/jugadas").Build());
                MessageBox.Show("¡Conectado exitosamente al Broker MQTT y escuchando jugadas!", "Conexión Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo conectar al MQTT: {ex.Message}", "Error de Conexión");
            }
        }

        // Aqui cae la jugada 
        private void ProcesarJugadaEntrante(string jsonRecibido)
        {
            try
            {
                // Convertir el texto JSON que llego de internet en un objeto C# de esta clase
                JugadaCliente jugada = JsonConvert.DeserializeObject<JugadaCliente>(jsonRecibido);

                if (jugada != null)
                {
                    // Reflejar la interfaz de la loteria lo que el cliente aposto desde fuera
                    tBox1.Text = jugada.NumeroJugado.ToString();  // Casilla del numero apostado
                    tBox2.Text = jugada.MontoApostado.ToString(); // Casilla del dinero apostado

                    // Guardamos el ID del cliente en una etiqueta
                    this.Text = "Loteria - Jugada de: " + jugada.IdCliente;

                    MessageBox.Show($"¡Llego jugada externa!\nCliente: {jugada.IdCliente}\nNúmero: {jugada.NumeroJugado}\nMonto: RD${jugada.MontoApostado}", "Jugada Recibida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descifrar los datos del cliente: " + ex.Message);
            }
        }
    }
}