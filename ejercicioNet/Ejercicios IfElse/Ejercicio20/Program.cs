using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una estacion del año en la que quiera viajar");
            string estacion = Console.ReadLine();
            
            Console.WriteLine("Ingrese una localidad a la que quiera viajar");
            string localidad = Console.ReadLine();
            int precioBase = 15000;
            switch (estacion)
            {
                 //switch para viajar en invierno
                case "invierno":
                    switch (localidad)
                    {
                        case "bariloche":
                            int precioFinalBariloche = (int)(precioBase + (precioBase * 0.2));
                            Console.WriteLine($"El precio del viaje a {localidad} en {estacion} es de " + precioFinalBariloche + " pesos");
                            break;
                        
                        case "cataratas":
                        case "cordoba":
                            int precioFinalCordoba = (int)(precioBase - (precioBase * 0.1));
                            Console.WriteLine($"El precio del viaje a {localidad} en {estacion} es de " + precioFinalCordoba + " pesos");
                            break;
                       
                        case "mar del plata":
                            int precioFinalMdq = (int)(precioBase - (precioBase * 0.2));
                            Console.WriteLine($"El precio del viaje a {localidad} en {estacion} es de " + precioFinalMdq + " pesos");
                            break;
                        
                        default:
                            Console.WriteLine("Por favor ingrese una localidad valida");
                            break;
                    }
                    break;

                //switch para viajar en verano
                case "verano":
                    switch (localidad)
                    {
                        case "bariloche":
                            int precioFinalBariloche = (int)(precioBase - (precioBase * 0.2));
                            Console.WriteLine($"El precio del viaje a {localidad} en {estacion} es de " + precioFinalBariloche + " pesos");
                            break;

                        case "cataratas":
                        case "cordoba":
                            int precioFinalCordoba = (int)(precioBase + (precioBase * 0.1));
                            Console.WriteLine($"El precio del viaje a {localidad} en {estacion} es de " + precioFinalCordoba + " pesos");
                            break;

                        case "mar del plata":
                            int precioFinalMdq = (int)(precioBase + (precioBase * 0.2));
                            Console.WriteLine($"El precio del viaje a {localidad} en {estacion} es de " + precioFinalMdq + " pesos");
                            break;

                        default:
                            Console.WriteLine("Por favor ingrese una localidad valida");
                            break;
                    }
                    break;
                //switch para viajar en otoño o primavera
                case "otoño":
                case "primavera":
                    switch (localidad)
                    {
                        case "bariloche":
                            int precioFinalBariloche = (int)(precioBase + (precioBase * 0.1));
                            Console.WriteLine($"El precio del viaje a {localidad} en {estacion} es de " + precioFinalBariloche + " pesos");
                            break;

                        case "cataratas":
                            int precioFinalCordoba = (int)(precioBase + (precioBase * 0.1));
                            Console.WriteLine($"El precio del viaje a {localidad} en {estacion} es de " + precioFinalCordoba + " pesos");
                            break;

                        case "mar del plata":
                            int precioFinalMdq = (int)(precioBase + (precioBase * 0.1));
                            Console.WriteLine($"El precio del viaje a {localidad} en {estacion} es de " + precioFinalMdq + " pesos");
                            break;

                        case "cordoba":
                            Console.WriteLine($"El precio del viaje {localidad} en {estacion} es de " + precioBase + " pesos");
                            break;
                        default:
                            Console.WriteLine("Por favor igrese una localidad valida");
                            break;
                    }
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
