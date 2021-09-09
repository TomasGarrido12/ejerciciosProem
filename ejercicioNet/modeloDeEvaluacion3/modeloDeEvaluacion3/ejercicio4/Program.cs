using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acumulado = 0;
            int rangoMinimo = DatoIngresado("Ingrese el rango minimo:");
            int rangoMaximo = DatoIngresado("Ingrese el rango maximo:");
            do
            {
                int valor = DatoIngresado("Ingrese un valor:");
                if (Validar(valor, rangoMinimo, rangoMaximo))
                {
                    Console.WriteLine("Dato correcto");
                    if (min > valor)
                    {
                        min = valor;
                    }
                    else if(max < valor)
                    {
                        max = valor;
                    }
                    acumulado += valor;
                }
                else
                {
                    Console.WriteLine("Dato incorrecto");
                }
                
                n++;

            } while (n<=10);

            Console.WriteLine($"El valor minimo es {min} \nEl valor maximo es {max} \nEl promedio es {(float)acumulado/10}");
            
            Console.ReadKey();
        }
        static int DatoIngresado(string dato)
        {
            Console.WriteLine(dato);
            return int.Parse(Console.ReadLine());
        }
        static bool Validar(int valor, int rangoMinimo, int rangoMaximo)
        {
            bool resultado;

            if (valor >= rangoMinimo && valor <= rangoMaximo)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;

        }
    }
}
