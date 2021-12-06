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
        virtual public Libro Libro { get; set; }
        public bool Disponible { get; set; }
        public EstadoEjemplar Estado { get; set; }
        public virtual List<Prestamo> Prestamos { get; set; }
        public Ejemplar()
        {

        }
        public Ejemplar(Libro unLibro, string estado)
        {   if(estado=="Bueno")
            Estado = EstadoEjemplar.Bueno;
        else Estado = EstadoEjemplar.Malo;
            Disponible = true;
            Libro = unLibro;
        }
    }
}
