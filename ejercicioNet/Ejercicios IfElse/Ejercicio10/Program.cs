using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios 10
            Console.WriteLine("Ingresa tu edad");
            int edad = int.Parse(Console.ReadLine());

            if(edad >= 18 || edad < 13)
            {
                Console.WriteLine("No sos adolescente");
            }
            else
            {
                Console.WriteLine("Sos adolescente");
            }
            Console.ReadKey();
        }
    }
}
