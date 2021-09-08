using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreA = IngresarNombre("Por favor ingresar su nombre: ");
            string nombreB = IngresarNombre("Por favor ingresar su nombre: ");
            int pesoA = IngresarPeso("Por favor ingresar su peso: ");
            int pesoB = IngresarPeso("Por favor ingresar su peso: ");
            MensajeFinal(pesoA, pesoB, nombreA, nombreB);
            Console.ReadKey();
        }
        static string IngresarNombre(string datoNombre)
        {
            Console.WriteLine(datoNombre);
            return Console.ReadLine();
        }
        static int IngresarPeso(string datoPeso)
        {
            Console.WriteLine(datoPeso);
            return int.Parse(Console.ReadLine());
        }
        static void MensajeFinal(int pesoA, int pesoB, string nombreA, string nombreB)
        {
            int suma = pesoA + pesoB;
            float promedio = (float)(pesoA + pesoB) / 2;
            Console.WriteLine("Ustedes se llaman {0} y {1} pesan {2} y {3} kilos, que sumados son {4} kilos y el promedio de peso {5} ", nombreA, nombreB, pesoA, pesoB, suma, promedio);
        }
    }
}
