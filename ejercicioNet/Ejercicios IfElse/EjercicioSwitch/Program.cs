using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir 2 valores y mostrar la comparacion

            Console.WriteLine("Escribi dos valores");
            int nota1 = int.Parse(Console.ReadLine());
            int nota2 = int.Parse(Console.ReadLine());

            if (nota1 > nota2)
            {
                Console.WriteLine(nota1 +">"+ nota2 );
            }
            else if (nota2 > nota1)
            {
                Console.WriteLine(nota2 +"<"+ nota1);
            }
            else
            {
                Console.WriteLine("Tus valores son iguales");
            }





            Console.ReadKey();
        }
    }
}
