using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una hora");
            int hora = int.Parse(Console.ReadLine());
            switch (hora)
            {
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Es de mañana");
                    break;
                default:
                    Console.WriteLine("No es de mañana");
                    break;
            }
            Console.ReadKey();
        }
    }
}
