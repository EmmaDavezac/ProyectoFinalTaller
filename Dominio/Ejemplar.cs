using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ejemplar
    {
        public int Id { get; set; }
        [ForeignKey("idLibro")]
        virtual public Libro Libro { get; set; } 
        public int idLibro { get; set; }
        public bool Disponible { get; set; }
        public EstadoEjemplar Estado { get; set; }
        public virtual List<Prestamo> Prestamos { get; set; }
        public bool Baja { get; set; }
        public Ejemplar()
        {

        }
        public Ejemplar(Libro unLibro)
        {  
            Estado = EstadoEjemplar.Bueno;
            Disponible = true;
            Libro = unLibro;
            Baja = false;
        }
    }
}
