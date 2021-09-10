using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");

            int numero = int.Parse(Console.ReadLine());

            int contador = 0;

            for (int i = 1; i <= numero ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Numero par hasta el {numero} es , por ahora, {i}");
                    contador++;
                    Console.WriteLine($"La cantidad de numeros hasta el momento son {contador}");


                }
            }
            Console.ReadKey();

        }
    }
}
