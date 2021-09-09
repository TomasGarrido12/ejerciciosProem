using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'a';
            int valor;
            int acumulador = 0;
            do
            {
                Console.WriteLine("Ingrese un valor");
                valor = int.Parse(Console.ReadLine());
                acumulador += valor;

                Console.WriteLine("¿Continuar?");
                c = char.Parse(Console.ReadLine());

            } while (ValidaS_N(c));

            Console.WriteLine($"La suma de todos los valores es {acumulador}");
            Console.ReadKey();
        }

        static bool ValidaS_N(char c)
        {
            bool resultado;


            if (c == 'S')
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }
    }
}
