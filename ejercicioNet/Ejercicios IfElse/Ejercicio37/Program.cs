using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            bool esPrimo = true;

            Console.WriteLine("Ingresa un numero");

            numero = int.Parse(Console.ReadLine());         

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                Console.WriteLine("{0} es primo", numero);
            }
            else
            {
                Console.WriteLine("{0} no es primo", numero);
            }
            Console.ReadKey();
        }
    }
}
