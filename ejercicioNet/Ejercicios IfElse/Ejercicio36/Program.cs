using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");

            int numero = int.Parse(Console.ReadLine());

            int contador = 0;

            for (int i = 1; i <= numero; i++)
            {
   
                if (numero % i == 0)
                {
                    Console.WriteLine($"Numero divisor del {numero} es , por ahora, {i}");
                    contador++;
                    Console.WriteLine($"La cantidad de numeros divisores hasta el momento son {contador}");


                }
            }
            Console.ReadKey();
        }
    }
}
