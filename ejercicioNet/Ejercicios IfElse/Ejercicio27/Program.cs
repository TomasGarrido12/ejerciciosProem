using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            int contador = 0;

            int suma = 0;

            int promedio;
            
            do
            {
                Console.WriteLine("Ingrese un numero");

                valor = int.Parse(Console.ReadLine());

                suma = suma + valor;
                contador++;


            } while (contador < 5);

            

            Console.WriteLine($"La suma de los 5 numeros es {suma}");

            promedio = suma / 5;

            Console.WriteLine($"El promedio es {promedio}");

            Console.ReadKey();
        }
    }
}

