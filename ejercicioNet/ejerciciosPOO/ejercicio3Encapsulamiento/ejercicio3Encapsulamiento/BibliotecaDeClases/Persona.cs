using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Persona
    {
        private long dni;

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        public string MostrarDatosPersona()
        {
            StringBuilder sbPersona = new StringBuilder();
            sbPersona.AppendLine($"El dni de la persona es {dni}");
            sbPersona.AppendLine($"El nombre de la persona es {nombre}");

            return sbPersona.ToString();
        }
    }
}
