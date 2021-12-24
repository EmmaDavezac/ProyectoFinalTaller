using System;
using System.Collections.Generic;
using System.Collections;
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
        public string AñoPublicacion { get; set; }
        public virtual List<Ejemplar> Ejemplares { get; set; }

        
        

        public Libro()
        {

        }

        public Libro(string unISBN, string titulo, string autor, string añoPublicacion)
        {
            ISBN = unISBN;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
        }
        public Libro(string unISBN,string titulo,string autor,string añoPublicacion,int pCantidadEjemplares)
        {
            ISBN = unISBN;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
        }
        public List<Ejemplar> EjemplaresDisponibles()
        { List<Ejemplar> ejemplaresDisponibles = new List<Ejemplar>();
            foreach (var item in Ejemplares)
            {
                if (item.Disponible)
                {
                    ejemplaresDisponibles.Add(item);
                }
               
            }
            return ejemplaresDisponibles;
        }
    }
}
