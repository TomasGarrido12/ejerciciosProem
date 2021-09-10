using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero que corresponda con los meses del año");
            
            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 11:
                    Console.WriteLine("Este mes NO tiene mas de 29 dias");
                    break;
                default:
                    Console.WriteLine("Este mes tiene 30 dias o mas");
                    break;
            }
            Console.ReadKey();
        }
    }
}
