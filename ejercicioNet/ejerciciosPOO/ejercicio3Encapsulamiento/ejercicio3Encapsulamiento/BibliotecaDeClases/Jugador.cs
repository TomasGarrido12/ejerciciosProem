using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Jugador : Persona
    {
        private int partidosJugados;

        public int PartidosJugados
        {
            get { return partidosJugados; }
        }

        private int totalGoles;

        public int TotalGoles
        {
            get { return totalGoles; }
        }

        public float PromedioDeGoles  // Revisar este metodo, me devueve siepre un promedio de 0 goles
        {
            get { return totalGoles / partidosJugados; }
        }

        public Jugador(long dni, string nombre):base(dni,nombre)
        {

        }

        public Jugador(long dni, string nombre, int totalGoles, int partidosJugados) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        public string MostrarDatosJugador()  //Como hacer para que muestre los datos del metodo que esta en Persona tambien. Osea, solamente me muestra los datos de aca abajo y no los que estan en Persona
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La cantidad de partidos jugados es {partidosJugados}");
            sb.AppendLine($"La cantidad de goles del jugador es {totalGoles}");
            sb.AppendLine($"El promedio de goles es {PromedioDeGoles}");

            return sb.ToString();

            return $"{base.MostrarDatosPersona()}";
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
