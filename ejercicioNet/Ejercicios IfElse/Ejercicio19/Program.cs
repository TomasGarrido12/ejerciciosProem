using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
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

                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    Console.WriteLine("Es de tarde");
                    break;

                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                    Console.WriteLine("Es de noche");
                    break;

                default:
                    Console.WriteLine("La hora no existe");
                    break;
            }
            Console.ReadKey();
        }
    }
}
