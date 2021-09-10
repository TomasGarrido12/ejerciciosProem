using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios 12
            Console.WriteLine("Ingresa tu edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu estado civil (Soltero o Casado)");
            string estadoCivil = Console.ReadLine();

            if (edad < 18 && estadoCivil != "Soltero")
            {
                Console.WriteLine("Es muy pequeño para NO ser soltero");
            }
            Console.ReadKey();
        }
    }
}
