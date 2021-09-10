using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            string clave;
            do
            {
                Console.WriteLine("Ingrese la clave");
                clave = Console.ReadLine();
            } while (!(clave == ".net"));
            
            Console.WriteLine("clave correcta");
            
            Console.ReadKey();
        }
       
    }
}
