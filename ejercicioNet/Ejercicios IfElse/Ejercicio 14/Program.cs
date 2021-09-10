using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero correspondiente a los meses del año");
            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("que comiences bien el año!!");
                    break;
                case 3:
                    Console.WriteLine("a clases!!");
                    break;
                case 7:
                    Console.WriteLine("se vienen las vacaciones!!!");
                    break;
                case 12:
                    Console.WriteLine("felices fiestas!!!");
                    break;

                default:
                    Console.WriteLine("El mes que pusiste no es ni enero, ni marzo, ni julio ni diciembre");
                    break;
            }
                Console.ReadKey();
        }
    }
}
