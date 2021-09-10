using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSwitch3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio Switch
            
            int puntuacion = new Random().Next(0, 5);
            Console.WriteLine(puntuacion);
            switch (puntuacion)
            {
                case 0:
                    Console.WriteLine("La pelicula fue mala");
                    break;

                case 1:
                    Console.WriteLine("La pelicula fue regular");
                    break;

                case 2:
                    Console.WriteLine("La pelicula fue buena");
                    break;
                
                case 3:
                    Console.WriteLine("La pelicula fue muy buena");
                    break;

                case 4:
                    Console.WriteLine("La pelicula fue excelente");
                    break;

                default:
                    Console.WriteLine("La puntuacion va del 0 al 4");
                    break;
            }
            Console.ReadKey();

        }
    }
}
