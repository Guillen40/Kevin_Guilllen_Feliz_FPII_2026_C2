using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_de_loteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // limpiar entradas
            btn1.Text = "";
            btn1.Text = "";

            // Limpiar casillas
            tBox5.Text = "";
            tBox2.Text = "";
            tBox3.Text = "";

            // Limpiar el premio
            tBox6.Text = "";
        }
    }
}
