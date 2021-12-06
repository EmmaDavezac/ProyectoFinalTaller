using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UsuarioSimple:Usuario
    {
        public virtual List<Prestamo> Prestamos { get; set; }
        public UsuarioSimple()
        {

        }
        public int Scoring { get; set; }
        public UsuarioSimple(string nombre, string apellido, DateTime fechaNacimiento, string mail) : base(nombre, apellido, fechaNacimiento, mail)
        {
            
            Scoring = 0;
        }
    }
}
