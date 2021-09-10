using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPalindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese palabras");

            string resultado1 = Console.ReadLine();

            char[] caracteres = resultado1.ToCharArray();

            Array.Reverse(caracteres);

            string resultado2 = new string(caracteres);

            if (resultado1 == resultado2)
            {
                Console.WriteLine("es palindromo");
            }
            else
            {
                Console.WriteLine("No es palindromo");
            }
            Console.ReadKey();   
        }
    }
}
