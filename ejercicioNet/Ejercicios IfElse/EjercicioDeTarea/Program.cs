using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeTarea
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un texto");
            string palabra = Console.ReadLine();
            string[] palabrasInvertidas = palabra.Split();
            //Esto es necesario para poder invertir cada una de las palabras del texto
            //y poder almacenarlas en un array nuevo
            string[] palabrasAlReves = new string[palabrasInvertidas.Length];
            
            for (int i = 0; i < palabrasInvertidas.Length; i++)
            {
                //Necesitamos cambiar el tipo string a char array para poder hacer el reverse
                char[] palabraArray = palabrasInvertidas[i].ToCharArray();
                Array.Reverse(palabraArray);
                //Como tenemos un array de string, necesitamos transformar
                //nuestro char array a un string
                //De esa manera lo podemos agregar a palabrasAlReves
                palabrasAlReves[i] = new string(palabraArray);
            }


            string resultado = string.Join(" ", palabrasAlReves);
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
