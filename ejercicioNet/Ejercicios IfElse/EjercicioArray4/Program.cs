using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArray4
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto;
            int precio;
            string[] listaProductos = new string[5];
            int[] listaPrecios = new int[5];

            for (int i = 0; i < listaProductos.Length; i++) //para generar la lista de productos
            {
                Console.WriteLine($"Ingrese el producto numero {i}");
                producto = Console.ReadLine();
                listaProductos[i] = producto;
            }


            for (int i = 0; i < listaPrecios.Length; i++) //para generar la lista de precios
            {
                Console.WriteLine($"Ingrese el precio del producto numero {i}");
                precio = int.Parse(Console.ReadLine());
                listaPrecios[i] = precio;
            }

            

            Console.WriteLine("La lista de productos es");
            for (int i = 0; i < listaProductos.Length; i++)   //Para escribir la lista de productos
            {
                Console.WriteLine($"producto N° {i} = " + listaProductos[i]);
            }

            Console.WriteLine("La lista de precios es");
            for (int i = 0; i < listaPrecios.Length; i++)   //Para escribir la lista de precios
            {
                Console.WriteLine($"precio del producto N° {i} = " + "$" + listaPrecios[i]);
            }

            Array.Sort(listaPrecios);
            Console.WriteLine("El menor precio es el " + "$" + listaPrecios[0] + " *");

            Console.ReadKey();
        }
    }
}
