using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArrayEnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            int[] lista = new int[500];                      

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Ingrese un numero");

                //para pedirle al usuario que agregue un dato al array
                numero = int.Parse(Console.ReadLine());

                lista[i] = numero;

                if (numero == -1)
                {
                    break;
                }

            }

            Console.WriteLine("La lista que vos ingresaste es la siguiente");

            for (int i = 0; i < lista.Length; i++)
            {
                //para escribir todo el array
                Console.WriteLine($"posicion {i} = " + lista[i]);
                if (lista[i] == -1)
                {
                    break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
