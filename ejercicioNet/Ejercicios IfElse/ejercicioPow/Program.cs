using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPow
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = IngresarDato("Por favor ingresar un numero");
            ValidarDato(num);            
            Console.ReadKey();
        }

        static int IngresarDato(string dato)
        {
            Console.WriteLine(dato);
            return int.Parse(Console.ReadLine());
        }

        static void ValidarDato(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("ERROR.¡Reingresar numero!");
            }
            else
            {
                var cuadrado = Math.Pow(num, 2);
                var cubo = Math.Pow(num, 3);
                Console.WriteLine($"El cuadrado del numero es : " + cuadrado);
                Console.WriteLine($"El cubo del numero es : " + cubo);
            }
        }
        //static void CalcularPotencia(int num)
        //{
            
        //}
    }
}
