using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string tipo = "";
            string respuesta = "";
            double cant = 0;
            double precioIngresado = 0;
            double precioIngresadoAux = 0;
            double precioConDtoMasDiezUni = 0;
            double precioConDtoMasTreintaUni = 0;
            double precioFinal = 0;
            string tipoAux = "";
            double cantidadMax = double.MinValue;
            double precioMax = double.MinValue;
            string tipoAuxDos = "";
            do
            {
                Console.WriteLine("Ingrese un tipo de producto (arena, cal o cemento):");
                tipo = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad:");
                cant = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio (mayor a cero):");
                precioIngresado = double.Parse(Console.ReadLine());

                if ((tipo == "arena" || tipo == "cal" || tipo == "cemento") && (precioIngresado > 0))
                {
                    flag = false;
                    precioIngresado = precioIngresado * cant;
                    precioIngresadoAux = precioIngresadoAux + precioIngresado;
                    if (cant>10 && cant <30)
                    {
                         precioConDtoMasDiezUni = precioIngresado - (precioIngresado * 0.15);
                    }
                    if (cant > 30)
                    {
                        precioConDtoMasTreintaUni = precioIngresado - (precioIngresado * 0.25);
                    }
                    if (cantidadMax < cant)
                    {
                        cantidadMax = cant;
                        tipoAux = tipo;
                    }
                    if (precioMax < precioIngresado)
                    {
                        precioMax = precioIngresado;
                        tipoAuxDos = tipo;
                    }
                    precioFinal = precioConDtoMasDiezUni + precioConDtoMasTreintaUni;
                }

                if (flag)
                {
                    Console.WriteLine("Datos incorrectos, intente devuelta");
                }
                Console.WriteLine("Desea continuar?");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");

            Console.WriteLine("El importe total a pagar , bruto sin descuento es {0} \n-El importe total a pagar con descuento(solo si corresponde) es {1} \n-El tipo con más cantidad de bolsas es {2} \n-El tipo más caro es {3}", precioIngresadoAux, precioFinal, tipoAux, tipoAuxDos);

            Console.ReadKey();
        }
    }
}
