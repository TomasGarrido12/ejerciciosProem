using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArray5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la longitud del array");

            int valores = int.Parse(Console.ReadLine());  //El usuario ingresa la longitud del array
            int[] lista = new int[valores];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Ingrese un numero");
                lista[i]= int.Parse(Console.ReadLine()); //El usuario agrega un dato al array
            }

            Console.WriteLine("La lista que ingresaste es:");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);  //Para imprimir el array
            }

            Array.Reverse(lista); //Se cambia el orden del array
            Console.WriteLine("La lista al revés es:");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadKey();
        }
    }
}
