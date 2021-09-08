using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoTres
{
    class Program
    {
        static void Main(string[] args)
        {
            float precio = IngresarPrecio("Por favor ingresar el precio del producto: ");
            float descuento = IngresarDescuento("Por favor ingresar el descuecto que quiera aplicar: ");
            Console.WriteLine("Usted a elegido aplicar a {0} un descuento del {1}%", precio, descuento);
            float precioFinal =CalcularDescuento(precio, descuento);
            Console.WriteLine("El precio final es de {0}", precioFinal);
            Console.ReadKey();

        }
        static int IngresarPrecio(string datoPrecio)
        {
            Console.WriteLine(datoPrecio);
            return int.Parse(Console.ReadLine());
        }
        static int IngresarDescuento(string datoDescuento)
        {
            Console.WriteLine(datoDescuento);
            return int.Parse(Console.ReadLine());
        }
        static float CalcularDescuento(float precio, float descuento)
        {
            float precioAuxiliar =precio-( precio * (descuento / 100));
            return precioAuxiliar;
        }
    }
}
