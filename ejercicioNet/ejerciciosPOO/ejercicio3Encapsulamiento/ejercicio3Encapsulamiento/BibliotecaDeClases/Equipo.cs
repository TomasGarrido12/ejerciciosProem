using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public string GetNombreEquipo()
        {
            return nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool NoEstaEnElEquipo = true;

            if (j is not null && e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if (jugador == j)
                    {
                        NoEstaEnElEquipo = false;
                        break;
                    }
                }
                if (NoEstaEnElEquipo)
                {
                    e.jugadores.Add(j);
                    return NoEstaEnElEquipo;
                }
            }
            return false;

        }
    }
}
