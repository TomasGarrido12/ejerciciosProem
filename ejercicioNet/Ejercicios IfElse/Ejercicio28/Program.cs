using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            int contador = 0;

            int suma = 0;

            int promedio;

            string respuesta;

            do
            {
                Console.WriteLine("Desea continuar?");

                respuesta = Console.ReadLine();
                
                if (respuesta == "si")
                {
                
                Console.WriteLine("Ingrese un numero ");

                valor = int.Parse(Console.ReadLine());
                
                suma += valor;

                contador++;

                }

            } while (respuesta != "no");

            Console.WriteLine($"La suma de los numeros ingresados es {suma}");

            promedio = suma / contador;

            Console.WriteLine($"El promedio es {promedio}");

            Console.ReadKey();
        }
    }
}
