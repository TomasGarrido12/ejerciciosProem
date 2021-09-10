using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int contador = 0;
            int suma = 0;
            int promedio;

            int[] lista = new int[500];                        

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Ingrese un numero");
                
                valor = int.Parse(Console.ReadLine());         //para pedirle al usuario que agregue un dato al array
               
                lista[i] = valor;                              //agregar el dato del usuario a mi arreglo
                
                suma += valor;                                 //sumar cada dato que ingrese el usuario
                
                contador++;                                    //contabilizar la cantidad de datos ingresados
                

                if (valor == -1)
                {
                    break;
                }

            }
             promedio = suma / contador;

            Console.WriteLine($"el promedio es {promedio}" );

            Console.ReadKey();
        }
    }
}
