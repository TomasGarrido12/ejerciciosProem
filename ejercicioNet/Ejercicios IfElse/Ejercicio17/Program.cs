using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un mes del año");
            
            string mes = Console.ReadLine();

            switch (mes)
            {
                case "enero":

                case "marzo":

                case "mayo":

                case "julio":

                case "agosto":

                case "octubre":

                case "diciembre":

                    Console.WriteLine("Este mes tiene 31 dias");
                    break;

                case "abril": 

                case "junio":

                case "septiembre": 

                case "noviembre":

                    Console.WriteLine("Este mes tiene 30 dias");
                    break;

                default:

                    Console.WriteLine("Este mes tiene como maximo 29 dias");
                    break;
            }
            Console.ReadKey();
        }
    }
}
