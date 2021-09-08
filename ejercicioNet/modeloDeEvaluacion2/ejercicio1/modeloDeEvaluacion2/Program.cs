using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int cantidadAux = 0;          
            int precioMin = int.MaxValue;
            int cantidadMax = int.MinValue;
            string tipoAux= "";
            int promedio = 0;
            int cantTotalJabones = 0;
            string fabricanteAux = "";
            int contador = 0;
            int n = 0;
            int cantSumada = 0;
            while (n<2)
            {
                do
                {
                    Console.WriteLine("Ingrese un tipo de producto, debe ser jabon, barbijo o alcohol: ");
                    string tipo = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del producto, debe ser 100 y 300:");
                    int precio = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad del producto, debe ser mayor a cero y menor a 1000: ");
                    int cantidad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un fabricante:");
                    string fabricante = Console.ReadLine();

                    if ((tipo == "barbijo" || tipo == "alcohol" || tipo == "jabon") && (precio > 100 && precio < 300) && (cantidad > 0 && cantidad < 1000))
                    {
                        flag = false;
                        if (tipo == "alcohol")
                        {
                            if (precio < precioMin)
                            {
                                precioMin = precio;
                                cantidadAux = cantidad;
                                fabricanteAux = fabricante;
                            }
                        }
                        if (cantidadMax < cantidad)
                        {
                            cantidadMax = cantidad;
                            tipoAux = tipo;
                            contador++;
                            cantSumada = cantSumada + cantidad;
                            promedio = cantSumada / contador;
                            
                        }
                        if (tipo == "jabon")
                        {
                            cantTotalJabones = cantTotalJabones + cantidad;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine("Datos incorrectos, intente otra vez");
                    }
                } while (flag);

                n++;
            }
                                 
            Console.WriteLine($"El alcohol mas barato es {precioMin}, la cantidad de unidades es {cantidadAux} y el fabricante es {fabricanteAux}" );
            Console.WriteLine($"El tipo que tiene mas unidades es {tipoAux} con {cantidadMax} unidades y el promedio de compra es {promedio}");
            Console.WriteLine($"La cantidad de jabon total es {cantTotalJabones}");
            Console.ReadLine();
        }
    }
}
