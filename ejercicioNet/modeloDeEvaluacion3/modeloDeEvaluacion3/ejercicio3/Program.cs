using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año inicial:");
            int añoInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un año final:");
            int añoFin = int.Parse(Console.ReadLine());

            for (int i = añoInicio; i <= añoFin; i++)
            {
                if (i % 400 == 0)
                {
                    Console.WriteLine("{0} es bisiesto", i);
                }
                else
                {
                    if ((i % 4 == 0) && (i %100 != 0))
                    {
                        Console.WriteLine("{0} es bisiesto", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} no es bisiesto", i);
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
