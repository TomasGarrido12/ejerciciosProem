using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolAsteriscos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la altura del arbol");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num ; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
