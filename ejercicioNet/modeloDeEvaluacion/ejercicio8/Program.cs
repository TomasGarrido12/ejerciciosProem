using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            bool flag = true;
            int cantTempPares = 0;
            int habMin = int.MaxValue;
            string paisAux = "";
            int cantPaisesCuarentaGrados = 0;
            int contador = 0;
            int cantHabIngresadosTotal = 0;
            int tempMin = int.MaxValue;
            string paisTempMin = "";
            int promedio = 0;
            do
            {
                Console.WriteLine("Ingrese el pais:");
                string pais = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de habitantes entre 1 y 7000:");
                int cantidadHabitantesPorPais = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la temperatura minima entre -50 y 50");
                int temp = int.Parse(Console.ReadLine());

                if ((cantidadHabitantesPorPais > 1 && cantidadHabitantesPorPais <= 7000) && (temp > -50 && temp <= 50))
                {
                    flag = false;
                    contador++;
                    cantHabIngresadosTotal = cantHabIngresadosTotal + cantidadHabitantesPorPais;
                    promedio = cantHabIngresadosTotal / contador;

                    if (temp % 2 == 0)
                    {
                        cantTempPares++;
                    }
                    if (habMin > cantidadHabitantesPorPais)
                    {
                        habMin = cantidadHabitantesPorPais;
                        paisAux = pais;
                    }
                    if (tempMin > temp)
                    {
                        tempMin = temp;
                        paisTempMin = pais;
                    }
                    if (temp > 40)
                    {
                        cantPaisesCuarentaGrados++;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Datos incorrectos, intente devuelta");
                }
                Console.WriteLine("Desea continuar?");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");

            Console.WriteLine("La cantidad de temperaturas pares es {0} \n-El nombre del pais con menos habitantes es {1} \n-La cant de paises que superan los 40 grados son {2} \n-El promedio de habitantes entre los países ingresados es {3} \n-La temperatura mínima ingresada es {4} y nombre del país que registró esa temperatura es {5}.", cantTempPares, paisAux, cantPaisesCuarentaGrados, promedio, tempMin, paisTempMin);
            Console.ReadKey();
        }
    }
}
