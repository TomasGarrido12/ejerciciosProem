using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los meses 12,1,2,3 verano, 4,5,6 otoño, 7,8 invierno, 9,10,11 primavera
            Console.WriteLine("Ingrese un mes del año");
            string mes = Console.ReadLine();

            switch (mes)
            {
                //Meses de verano y primavera 
                case "enero":

                case "febrero":

                case "marzo":

                case "septiembre":

                case "octubre":
                case "noviembre":

                case "diciembre":
                    Console.WriteLine($"Ya pasamos el frio, ahora calor!!");
                    break;
                //Meses de otoño
                case "abril":

                case "mayo":

                case "junio":
                    Console.WriteLine($"Falta para el invierno");
                    break;
                //Meses de invierno
                case "julio":

                case "agosto":
                    Console.WriteLine($"abrigate que hace frio");
                    break;

                default:
                    break;
 
                    
            }
            Console.ReadKey();
        }
    }
}
