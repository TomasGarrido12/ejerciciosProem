using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            do
            {
                Console.WriteLine("Ingrese su sexo");
                sexo = Console.ReadLine();
                if (sexo == "femenino" || sexo == "mujer")
                {
                    Console.WriteLine("Sos mujer");
                    break;
                }
                else if (sexo == "masculino" || sexo == "varon")
                {
                    Console.WriteLine("Sos varon");
                    break;
                }
                else
                {
                    Console.WriteLine("No sos ni varon ni mujer");
                    break;
                }

            } while (string.IsNullOrEmpty(sexo));
            Console.ReadKey();
        }
    }
}
