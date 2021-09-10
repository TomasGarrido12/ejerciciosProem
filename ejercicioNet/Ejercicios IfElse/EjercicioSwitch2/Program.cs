using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSwitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Poner dos valores y mostrar cual es mas grande

            Console.WriteLine("Escribi dos valores");
            int nota1 = int.Parse(Console.ReadLine());
            int nota2 = int.Parse(Console.ReadLine());
            string comparacion = nota1 > nota2 ? nota1 +" es mayor a "+ nota2 : nota2 + " es mayor a " + nota1;
            Console.WriteLine(comparacion);

            Console.ReadKey();

        }
    }
}
