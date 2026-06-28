using Estructura_de_datos_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack pila = new CStack();

            pila.Push(5);
            pila.Push(3);
            pila.Push(10);

            pila.Transversa();


            // agregar "//" en ambas lineas pra NO agregar el 10
          Console.WriteLine(pila.Pop());
          pila.Transversa();

            // agregar "//" para que el peek no se ejecute
            Console.WriteLine(pila.Peek());
            Console.WriteLine(pila.Peek());
            pila.Transversa();
        }
    }
}
