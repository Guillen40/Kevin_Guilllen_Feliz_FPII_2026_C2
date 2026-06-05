using System;

namespace Programa_de_loteria
{
    public class JugadaCliente
    {
        // El identificador unico de quien juega (Ej: "Celular_Juan")
        public string IdCliente { get; set; }

        // El numero al que le va a apostar
        public int NumeroJugado { get; set; }

        // La cantidad de dinero que le va a meter a ese numero
        public int MontoApostado { get; set; }
    }
}