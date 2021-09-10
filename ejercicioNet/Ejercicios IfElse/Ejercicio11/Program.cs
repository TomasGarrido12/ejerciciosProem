using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios 11
            Console.WriteLine("Ingresa tu edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Sos mayor de edad");
            }
            else if(edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Sos adolescente");
            }
            else
            {
                Console.WriteLine("Sos menor de edad");
            }
            Console.ReadKey();
        }
    }
}
