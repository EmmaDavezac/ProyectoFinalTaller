using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UsuarioSimple:Usuario
    {
        public UsuarioSimple()
        {

        }
        public int Scoring { get; set; }
        public UsuarioSimple(string nombre,string apellido,DateTime fechaNacimiento,string mail)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Mail = mail;
            Scoring = 0;
        }
    }
}
