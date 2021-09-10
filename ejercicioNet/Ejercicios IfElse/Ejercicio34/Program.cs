using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de veces que queres que se repita la palabra Hola Mundo");

            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad ; i++)
            {
                Console.WriteLine("Hola Mundo");
            }

            Console.ReadKey();
        }
    }
}
