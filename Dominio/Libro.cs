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
        //public string ISBN  { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string AñoPrimeraPublicacion { get; set; }
        public IEnumerable<Ejemplar> Ejemplares { get; set; }
        public Libro(string titulo,string autor,string añoPrimeraPublicacion)
        {
            //ISBN = unISBN;
            Titulo = titulo;
            Autor = autor;
            AñoPrimeraPublicacion = añoPrimeraPublicacion;
        }
    }
}
