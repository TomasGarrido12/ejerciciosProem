using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            char caracter;
            do
            {
                Console.WriteLine("Ingrese un numero entre el 0 y el 9");

                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese s para salir");

                caracter = char.Parse(Console.ReadLine());

            } while (caracter != 's');
            
            Console.WriteLine("Saliste de la condicion DO WHILE");
            Console.ReadKey();
        }
    }
}
