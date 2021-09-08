using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            int alturaTotal = 0;
            bool flag = true;
            int promedioAltura = 0;
            int alturaMin = int.MaxValue;
            char sexoAux='a';
            int contador = 0;

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese una altura entre 0 y 250 cm");
                    int altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sexo 'f' o 'm' o 'x':");
                    char sexo = char.Parse(Console.ReadLine());
                    char.ToLower(sexo);

                    if ((altura >0 || altura <= 250) && (sexo == 'f' || sexo == 'm' || sexo == 'x'))
                    {
                        flag = false;
                        alturaTotal = alturaTotal + altura;
                        promedioAltura = alturaTotal / 5;

                        if (altura < alturaMin)
                        {
                            alturaMin = altura;
                            sexoAux = sexo;
                        }
                        if ((altura > 190) && (sexo == 'f'))
                        {
                            contador++;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine("Datos no validos, intente denuevo");
                    }
                } while (flag);
                
               
                
            }
            Console.WriteLine("El promedio es {0}", promedioAltura);
            Console.WriteLine("La altura mas baja es {0} y el sexo es {1}", alturaMin, sexoAux);
            Console.WriteLine("La cantidad de mujeres que su altura supere los 190 centimetros son {0}", contador);
            Console.ReadKey();
        }
    }
}
