using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFor
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Crea un programa que vaya desde el 59 al 0
            //for (int i = 59; i >= 0 ; i--)
            //{
            //    Console.WriteLine(i);
            //}
            ////Crea un programa que imprima numeros pares desde el 0 al 100
            //for (int i = 0; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            
            //Crear un programa de 0 a 100, imprimir si es divisible por 3 o no
            for (int i = 0; i <= 100 ; i++)
            {
                Console.WriteLine(i);
                if ((i%3)==0)
                {
                    Console.WriteLine("i es divisible por 3");
                }
                else
                {
                    Console.WriteLine("i no es divisible por 3");
                }
            }
            Console.ReadKey();
        }
    }
}
