using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int valor;
            int contador = 0;
            int suma = 0;
            int promedio;

            Console.WriteLine("Ingrese la longitud del array");

            int valores = int.Parse(Console.ReadLine());  //El usuario ingresa la longitud del array
            int[] lista = new int[valores];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Ingrese un numero");

                valor = int.Parse(Console.ReadLine()); //El usuario agrega un dato al array                
                lista[i] = valor;
                suma += valor;
                contador++; 

                if (lista [i] < minimo)
                {
                    minimo = lista[i];
                }
                if (lista[i] > maximo)
                {
                    maximo = lista[i];
                }
            }
            promedio = suma / contador;

            Console.WriteLine("La lista que ingresaste es:");

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);  //Para imprimir el array
            }
            
            Console.WriteLine($"El numero maximo es el {maximo} , el minimo es {minimo}, la suma es {suma} y el promedio es {promedio}");
            
            Console.WriteLine("Indique el elemento que quiera eliminar");

            int elementoAEliminar = int.Parse(Console.ReadLine());

            lista = lista.Where(val => val != elementoAEliminar).ToArray(); //Para eliminar el elemento que ingrese el usuario

            Console.WriteLine("La lista nueva que ingresaste es:");

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);  //Para imprimir el array nuevo
            }


            ////////////////////////////////////////////////////////////////////////
            string [] nombres = new string[5];
            int[] edades = new int[5];
            int[] mayores = new int[5];
            int contadorDeMayores = 0;

            for (int j = 0 ,i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona" + i);
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la edad de la persona" + i);
                edades[i] = int.Parse(Console.ReadLine());
                if (edades[i] >= 18)
                {
                    contadorDeMayores++;
                    mayores[j] - i;
                    j++;
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("La persona en la posicion" + i + "tiene de nombre" + nombres[i] + "y tiene" + edades[i] + "años");
                }
                for (int i = 0; i < contadorDeMayores; i++)
                {
                    for (int j = 0; j < contadorDeMayores; j++)
                    {

                    }
                }

            }





            Console.ReadKey();
        }
    }
}
