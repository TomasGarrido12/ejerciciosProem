using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centroNumerico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            CalcularCentroNumerico(numero);            
            Console.ReadLine();
        }

        static void CalcularCentroNumerico(int numero)
        {
            int aumento = 1, i, j, sumaDerecha, sumaIzquierda;
            while (aumento < numero)
            {

                aumento++;
                sumaDerecha = 0;
                sumaIzquierda = 0;

                for (i = 1; i < aumento; i++)
                {
                    sumaDerecha = sumaDerecha + i;
                }

                for (j = aumento + 1; j <= sumaDerecha; j++)
			    {
                    if ((sumaIzquierda == sumaDerecha)||(sumaIzquierda > sumaDerecha))
                        break;
                    sumaIzquierda = sumaIzquierda + j;
			    }               

                if (sumaDerecha == sumaIzquierda)
                    Console.WriteLine("El {0} es centro numerico", aumento);
            }
        }
    }
}
