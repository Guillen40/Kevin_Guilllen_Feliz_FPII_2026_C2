using Estructura_de_datos_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos_1
{
    class CStack
    {
        private CNodo ancla;

        private CNodo trabajo;

        public CStack()
        {
            ancla = new CNodo();

            ancla.Siguiente = null;
        }

        //push
        public void Push(int pDato)
        {
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            temp.Siguiente = ancla.Siguiente;

            ancla.Siguiente = temp;
        }

        //pop
        public int Pop()
        {

            int valor = 0;

            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }

            return valor;
        }

        // Peek
        public int Peek()
        {

            int valor = 0;

            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }

            return valor;
        }

        // Transversa

        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;

                int d = trabajo.Dato;

                Console.WriteLine("[{0}]", d);
            }
        }

    }
}