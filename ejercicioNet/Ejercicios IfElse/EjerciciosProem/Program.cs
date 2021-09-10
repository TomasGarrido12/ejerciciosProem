using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu edad");
            int edad = int.Parse(Console.ReadLine());
            
            if(edad == 15)
            {
                Console.WriteLine("Quinceañero/a");
            }
            
            Console.ReadKey();
        }
    }
}
