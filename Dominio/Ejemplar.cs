using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Ejemplar//esta clase tiene como objetivo representar en el modelo un ejemplar de un libro registrado, almacenando sus atributos y comportamiento
    {
        public int Id { get; set; }// clave que nos permite diferenciar entre si los ejemplares
        [ForeignKey("idLibro")]//Es la clave foranea del objeto que nos permite relacionar tablas entre si
        virtual public Libro Libro { get; set; }
        public int idLibro { get; set; }
        public bool Disponible { get; set; }//Property que nos permite saber si un ejemplar esta disponible o se encuenra prestado actualmente
        public EstadoEjemplar Estado { get; set; }//Esta property nos permite saber el estado del ejemplar(bueno o malo) solo se puede prestar si esta en buen estado
        public virtual List<Prestamo> Prestamos { get; set; }//Lista de prestamos que se ha hecho del ejemplar
        public bool Baja { get; set; }//Property para dar una baja logica del ejemplar

        public Ejemplar()//Constructor de la clase  que no toma parametros
        {
        }

        public Ejemplar(Libro unLibro)//Constructor de la clase que toma como parametro el libro al que pertenece el ejemplar
        {
            Estado = EstadoEjemplar.Bueno;//El estado original de un ejemplar es buen estado
            Disponible = true;//Originalmente un ejemplar se encuentra disponible hasta que se preste
            Libro = unLibro;//Relacionamos el ejemplar con el libro al que pertenece
            Baja = false;//Un ejemplar recien creado no se encuentra dado de baja
        }

        public string ObtenerTituloLibro()//Metodo que nos devuelve el nombre del libro al que pertenece el ejemplar
        {
            return Libro.Titulo;
        }

        public string ObtenerISBNLibro()//Metodo que nos devuelve el ISBN del libro al que pertenece el ejemplar
        {
            return Libro.ISBN;
        }
    }
}
