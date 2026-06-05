using System;

namespace Programa_de_loteria
{
    public class ResultadoJugada
    {
        // Para saber a cual cliente le pertenece este resultado
        public string IdCliente { get; set; }

        // Los tres numeros que salieron
        public string NumerosGanadores { get; set; }

        // El total de dinero que se gano (si no saco nada, sera 0)
        public int PremioGanado { get; set; }
    }
}