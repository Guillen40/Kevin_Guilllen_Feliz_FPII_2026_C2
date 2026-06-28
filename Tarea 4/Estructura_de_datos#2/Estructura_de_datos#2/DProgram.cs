using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos_2
{
    class CQueue
    {

        CNodo ancla;
        CNodo trabajo;

        public CQueue()
        {
            ancla = new CNodo();
            ancla.Siguiente = null;
        }


        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;

                int d = trabajo.Dato;

                Console.Write("<- {0} ", d);
            }

            Console.WriteLine();
        }

        public void Enqueue (int pDato)
        {
            trabajo = ancla;
            while (trabajo.Siguiente != null) 
            trabajo= trabajo.Siguiente;

            //nuevo nodo
            CNodo temp = new CNodo();
            temp.Dato = pDato;
            temp.Siguiente = null;
            trabajo.Siguiente= temp;

        }

        public int Dequeue ()
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

    }
}
