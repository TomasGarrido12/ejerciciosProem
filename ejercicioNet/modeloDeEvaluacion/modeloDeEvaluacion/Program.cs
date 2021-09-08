using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDeEvaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoA = IngresarDato("Por favor ingrese la longitud de un lado del triangulo equilatero: ");
            int perimetro = CalcularPerimetro(ladoA);
            Console.WriteLine($"El perimetro del triangulo es : " + perimetro);
            Console.ReadKey();
        }

        static int IngresarDato(string dato)
        {
            Console.WriteLine(dato);
            return int.Parse(Console.ReadLine());
        }

        static int CalcularPerimetro(int ladoA)
        {
            return ladoA * 3;
        }
    }
}
