using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el ancho del triangulo:");
            int ladoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el largo del triangulo:");
            int ladoB = int.Parse(Console.ReadLine());
            int perimetro;

            if (ladoA == ladoB)
            {
                perimetro = 3 * ladoB;
            }
            else
            {
                perimetro = (2 * ladoA) + ladoB;
            }

            Console.WriteLine("El perimetro del triangulo es {0}", perimetro);

            Console.ReadKey();
        }
    }
}
