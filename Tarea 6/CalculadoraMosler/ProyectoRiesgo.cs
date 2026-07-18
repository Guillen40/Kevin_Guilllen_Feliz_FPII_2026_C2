using System;

namespace CalculadoraMosler
{
    public class ProyectoRiesgo
    {
        public string NombreProyecto { get; set; }
        public string Evaluador { get; set; }
        public string BienAProteger { get; set; }
        public string Amenaza { get; set; }

        public int Funcion { get; set; }
        public int Sustitucion { get; set; }
        public int Profundidad { get; set; }
        public int Extencion { get; set; }
        public int Agresion { get; set; }
        public int Vulnerabilidad { get; set; }
        public int ResultadoER { get; set; }
        public string NivelRiesgo { get; set; }
    }
}