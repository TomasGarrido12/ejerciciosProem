using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioSiete
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta= "";
            int cantNumPares = 0;
            int cantNumImpares = 0;
            int cantCeros = 0;
            int numPositivos = 0;
            int contadorPositivos = 0;
            int promedioNumPositivos = 0;
            int numMax = int.MinValue;
            char letraMax = 'a';
            int numMin = int.MaxValue;
            char letraMin = 'a';
            do
            {
               
                Console.WriteLine("Ingrese un numero:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese una letra:");
                char letra = char.Parse(Console.ReadLine());
                char.ToLower(letra);     
                
                if (num > -100 && num < 100 )
                {
                    if (num % 2 == 0)
                    {
                        cantNumPares++;
                    }
                    else
                    {
                        cantNumImpares++;
                    }
                    if (num == 0)
                    {
                        cantCeros++;
                    }
                    if (num > 0)
                    {
                        numPositivos = numPositivos + num;
                        contadorPositivos++;
                        promedioNumPositivos = numPositivos / contadorPositivos;
                    }
                    if (num < numMin)
                    {
                        numMin = num;
                        letraMin = letra;
                    }
                    if (num > numMax)
                    {
                        numMax = num;
                        letraMax = letra;
                    }
                }

                Console.WriteLine("queres continuar?");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");
            Console.WriteLine("La cantidad de numeros pares es {0} \n-La de impares es {1} \n-La cantidad de ceros es {2} \n-El promedio de los positivos es {3} \n-El num maximo es {4} y su letra es {5} \n-El num minimo es {6} y su letra es {7} ", cantNumPares, cantNumImpares, cantCeros, promedioNumPositivos, numMax, letraMax, numMin, letraMin);

            Console.ReadKey();
        }
    }
}
