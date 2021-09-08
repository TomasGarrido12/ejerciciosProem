using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            string destino = IngresarContinente("Por favor ingrese su destino, las opciones son : \n-America \n-Africa \n-Europa \n-Otro ");
            int cantDias = IngresarDias("Ingresar la cantidad de dias: ");
            string medioPago = IngresarMedioPago("Ingresar el medio de pago, las opciones son: \n-En America = Debito u Otro \n-En Africa = MercadoPago, Efectivo u Otro \n-En Europa = Debito, MercadoPago u Otro \n-Otro = Todos los anteriores ");
            int precio = 100;
            double precioFinalDos = CalcularPrecio(destino, cantDias, precio, medioPago);
            Console.WriteLine("El precio final es: {0} pesos", precioFinalDos);
            Console.ReadKey();
        }
        static string IngresarContinente(string dato)
        {
            Console.WriteLine(dato);
            return Console.ReadLine();
        }
        static int IngresarDias(string datoAux)
        {
            Console.WriteLine(datoAux);
            return int.Parse(Console.ReadLine());
        }
        static string IngresarMedioPago(string datoAuxx)
        {
            Console.WriteLine(datoAuxx);
            return Console.ReadLine();
        }
        static double CalcularPrecio(string destino, int cantDias, int precio, string medioPago)
        {
            int precioNeto = cantDias * precio;
            double precioFinal = 0;
            switch (destino)
            {
                case "America":
                    switch (medioPago)
                    {
                        case "Debito":
                            precioFinal = precioNeto - (precioNeto*0.6);
                            break;
                        case "Otro":
                            precioFinal = precioNeto - (precioNeto * 0.5);
                            break;
                    }
                    break;

                case "Africa":
                    switch (medioPago)
                    {
                        case "MercadoPago":
                            precioFinal = precioNeto - (precioNeto * 0.75);
                            break;
                        case "Efectivo":
                            precioFinal = precioNeto - (precioNeto * 0.75);
                            break;
                        case "Otro":
                            precioFinal = precioNeto - (precioNeto * 0.6);
                            break;
                    }
                    break;

                case "Europa":
                    switch (medioPago)
                    {
                        case "Debito":
                            precioFinal = precioNeto - (precioNeto * 0.35);
                            break;
                        case "MercadoPago":
                            precioFinal = precioNeto - (precioNeto * 0.30);
                            break;
                        case "Otro":
                            precioFinal = precioNeto - (precioNeto * 0.25);
                            break;
                    }
                    break;

                case "Otro":
                    precioFinal = precioNeto + (precioNeto * 0.20);
                    break;

            }
                return precioFinal;
        }
    }
}
