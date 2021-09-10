using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño de la lista");
            
            int numero = int.Parse(Console.ReadLine());  //Para que el usuario decida el tamaño del array

            int[] lista = new int[numero];               //Para que el usuario decida el tamaño del array          

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Ingrese un numero");

                //para pedirle al usuario que agregue un dato al array
                lista[i] = int.Parse(Console.ReadLine());  
                
            }

            Console.WriteLine("La lista que vos ingresaste es la siguiente");

            for (int i = 0; i < lista.Length; i++)
            {
                //para escribir todo el array
                Console.WriteLine(lista[i]);
            }
            
            
            Console.ReadKey();
        }
    }
}

