using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntoCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroA = IngresarDato("Por favor ingresar un dato");
            int numeroB = IngresarDato("Por favor ingresar un dato");
            Calcular(numeroA, numeroB);
            Console.ReadKey();
        }
        static int IngresarDato(string dato)
        {
            Console.WriteLine(dato);
            return int.Parse(Console.ReadLine());
        }
        static void Calcular(int numeroA, int numeroB)
        {
            int resta;
            int suma;
            if (numeroA == numeroB)
            {
                Console.WriteLine("Los numeros son iguales y concatenados quedaria como {0}{1}", numeroA, numeroB);
            }
            else if (numeroA > numeroB)
            {
                resta = numeroA - numeroB;
                if (resta > 10)
                {
                    Console.WriteLine("El primero numero es mayor al segundo, la resta de los dos es {0} y supero el 10", resta);
                }
                else
                {
                    Console.WriteLine("El primero numero es mayor al segundo y la resta de los dos es {0}", resta);
                }
            }
            else
            {
                suma = numeroA + numeroB;
                Console.WriteLine("El segundo numero es mayor al primero y la suma es {0}", suma);
            }
        }
    }
}
