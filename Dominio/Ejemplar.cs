using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{   
    public class Ejemplar
    {
        public int Id { get; set; }
        public bool Disponible { get; set; }
        public EstadoEjemplar Estado { get; set; }
       virtual public IEnumerable<Prestamo> Prestamos { get; set; }
        public Ejemplar(EstadoEjemplar estado)
        {
            Estado = estado;
            Disponible = true;
        }
    }
}
