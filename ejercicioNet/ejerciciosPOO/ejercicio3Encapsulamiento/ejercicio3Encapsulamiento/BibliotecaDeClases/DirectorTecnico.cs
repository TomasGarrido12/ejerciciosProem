using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        private DirectorTecnico(string nombre):base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaDeNacimiento) : this(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sbPersona = new StringBuilder();
            sbPersona.AppendLine($"La fecha de nacimiento del Director tecnico es : {fechaDeNacimiento}");

            return sbPersona.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.fechaDeNacimiento == dt2.fechaDeNacimiento;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
