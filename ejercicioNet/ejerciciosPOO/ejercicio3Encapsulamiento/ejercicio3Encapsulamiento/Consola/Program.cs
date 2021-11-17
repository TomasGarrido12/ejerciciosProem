using System;
using BibliotecaDeClases;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(39744898,"Tomas",20,30);
            Jugador j2 = new Jugador(39744899, "Fede", 21, 33);
            DirectorTecnico dt1 = new DirectorTecnico("Pepe",DateTime.Now);
            DirectorTecnico dt2 = new DirectorTecnico("Guardiola", new DateTime(2009));
            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine(j2.MostrarDatos());
            
        }
    }
}
