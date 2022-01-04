using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UsuarioSimple : Usuario
    {
        public virtual List<Prestamo> Prestamos { get; set; }
        public int Scoring { get; set; }
        public UsuarioSimple(string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono, string pNombreUsuario) : base(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario)
        {
            Scoring = 0;
        }

        public UsuarioSimple()
        {

        }

        public bool ValidarBaja()
        {
            bool resultado = true;
            if (Prestamos == null)
            {
                resultado = true;
            }
            else
            {
                foreach (var item in Prestamos)
                {
                    if (item.FechaDevolucion == null)
                    {
                        resultado = false;
                    }
                }
            }
            return resultado;
        }
    }
}