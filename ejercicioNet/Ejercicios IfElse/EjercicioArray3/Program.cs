using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArray3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int[] lista = new int[5];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Ingrese un numero");

                valor = int.Parse(Console.ReadLine());

                lista[i] = valor;
            }
            Array.Sort(lista);

            Console.WriteLine("La lista que vos ingresaste es la siguiente");
                                                       
            for (int i = 0; i < lista.Length; i++) //para escribir todo el array
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("Termino la lista");

            Console.ReadKey();
        }
    }
}
