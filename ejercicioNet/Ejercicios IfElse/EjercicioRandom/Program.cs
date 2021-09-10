using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rd = new Random();
            //int numero = rd.Next(0, 11);

            //if (numero <=5)
            //{
            //    Console.WriteLine("Cara");
            //}
            //else
            //{
            //    Console.WriteLine("Cruz");
            //}
            //Console.ReadKey();
            Random rd = new Random();
            int numero = rd.Next(0, 11);
            string resultado;

            resultado = numero <= 5 ? "cruz" : "cara";
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
        
    }
}
