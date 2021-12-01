using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Libro
    { 
        public int Id { get; set; }
        public string ISBN  { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public IEnumerable<Ejemplar> Ejemplares { get; set; }
        public Libro(string unISBN,string titulo,string autor)
        {
            ISBN = unISBN;
            Titulo = titulo;
            Autor = autor;
        }
    }
}
