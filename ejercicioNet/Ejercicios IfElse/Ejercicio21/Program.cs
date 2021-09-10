using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una estacion del año en la que quiera viajar");
            string estacion = Console.ReadLine();

            Console.WriteLine("Ingrese una localidad a la que quiera viajar");
            string localidad = Console.ReadLine();
            switch (estacion)
            {
                //switch para viajar en invierno
                case "invierno":
                    switch (localidad)
                    {
                        case "bariloche":
                            Console.WriteLine("Se viaja");
                            break;

                        default:
                            Console.WriteLine("No se viaja");
                            break;
                    }
                    break;

                //switch para viajar en verano
                case "verano":
                    switch (localidad)
                    {
                        case "cordoba":
                        case "mar del plata":
                            Console.WriteLine("Se viaja");
                            break;

                        default:
                            Console.WriteLine("No se viaja");
                            break;
                    }
                    break;
                
                    //switch para viajar en otoño o primavera
                
                case "primavera":
                    switch (localidad)
                    {
                        case "bariloche":
                            Console.WriteLine("No se viaja");
                            break;

                        default:
                            Console.WriteLine("Se viaja");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Se viaja");
                    break;
            }
            Console.ReadKey();
        }
    }
}
