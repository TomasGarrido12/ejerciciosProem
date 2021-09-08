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
            string respuesta = "";
            bool flag = true;
            int totalInicial;

            double totalFinal = 0;
            do
            {
                int valorHora = PedirDatosNumericos("Por favor ingrese el valor hora");
                int horasTrabajadas = PedirDatosNumericos("Por favor ingrese la cantidad de horas trabajadas en el mes:");
                int antiguedad = PedirDatosNumericos("Por favor ingrese su antiguedad (en años):");
                string nombre = PedirDatosString("Por favor ingrese su nombre");

                totalInicial = (valorHora * horasTrabajadas) + (antiguedad * 150);

                totalFinal = totalInicial - (totalInicial * 0.13);

                Console.WriteLine("-Empleado: {0} \n-Antiguedad: {1} \n-Valor hora: {2} \n-Total en bruto: {3} \n-Total neto: {4}", nombre, antiguedad, valorHora, totalInicial, totalFinal );

                Console.WriteLine("Desea continuar?");
                respuesta = Console.ReadLine();
                Console.Clear();
            } while (respuesta == "si");
            Console.WriteLine("codigo terminado");

            Console.ReadKey();
            
        }
        static int PedirDatosNumericos(string dato)
        {
            Console.WriteLine(dato);
            return int.Parse(Console.ReadLine());
        }
        static string PedirDatosString (string dato)
        {
            Console.WriteLine(dato);
            return Console.ReadLine();
        }
        
    }
}
