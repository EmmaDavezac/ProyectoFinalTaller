using System.Collections.Generic;

namespace Dominio
{
    public class Libro //Esta clase es una abstracciòn de un libro
    {
        public int Id { get; set; }//Clave primaria que nos permite diferenciar los libros entre si
        public string ISBN { get; set; }//Codigo ISBN del libro (en el caso de que lo tenga)
        public string Titulo { get; set; }//Titulo del libro
        public string Autor { get; set; }//Nombre del autor del libro
        public string AñoPublicacion { get; set; }//Nombre del autor del libro
        public virtual List<Ejemplar> Ejemplares { get; set; }//Nombre del autor del libro
        public bool Baja { get; set; }//Property que nos permite dar una baja logica al libro


        public Libro()//Constructor de la clase sin argumentos
        {

        }

        public Libro(string unISBN, string titulo, string autor, string añoPublicacion)//Constructor de la clase
        {
            ISBN = unISBN;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Baja = false;
        }

        public List<Ejemplar> EjemplaresDisponibles()//Metodo que nos devuelve la lista de ejemplares del libro que se encuentran disponibles para prestarse actualmente
        {
            List<Ejemplar> ejemplaresDisponibles = new List<Ejemplar>();//Se crea una lista de ejemplares vacia y se guarda en la variable ejemplaresDisponibles
            foreach (var item in this.Ejemplares)//Recorremos la lista de ejemplares del libro
            {
                if (item.Disponible && item.Estado == EstadoEjemplar.Bueno && item.Baja == false)//Verifica si el ejemplar cumple las condiciones de no encontrarse prestado y estar en buen estado
                {
                    ejemplaresDisponibles.Add(item);//Verifica si el ejemplar cumple las condiciones de no encontrarse prestado y estar en buen estado
                }

            }
            return ejemplaresDisponibles;//Verifica si el ejemplar cumple las condiciones de no encontrarse prestado y estar en buen estado
        }

        public List<Ejemplar> EjemplaresEnBuenEstado()
        {
            List<Ejemplar> ejemplaresEnBuenEstado = new List<Ejemplar>();
            foreach (var item in this.Ejemplares)
            {
                if (item.Estado == EstadoEjemplar.Bueno)
                {
                    ejemplaresEnBuenEstado.Add(item);
                }

            }
            return ejemplaresEnBuenEstado;
        }
        public List<Ejemplar> EjemplaresTotales()
        {
            List<Ejemplar> ejemplaresTotales = new List<Ejemplar>();
            foreach (var item in this.Ejemplares)
            {
                if (item.Estado == EstadoEjemplar.Bueno && item.Baja == false)
                {
                    ejemplaresTotales.Add(item);
                }

            }
            return ejemplaresTotales;
        }

        public void EliminarEjemplares(int pCantidad)
        {
            int e = 0;
            foreach (var item in Ejemplares)
            {
                if (e >= pCantidad)
                {
                    break;
                }
                if (item.Estado != EstadoEjemplar.Malo)
                {
                    item.Estado = EstadoEjemplar.Malo;
                    item.Disponible = false;
                    item.Baja = true;
                    e = e + 1;
                }
            }
        }

        public void DarDeBaja()
        {
            if (Baja == false)
            {
                Baja = true;
                foreach (var item in Ejemplares)
                {
                    if (item.Estado != EstadoEjemplar.Malo)
                    {
                        item.Disponible = false;
                        item.Baja = true;
                    }              
                }
            }
        }

        public void DarDeAlta()
        {
            if (Baja == true)
            {
                Baja = false;
                foreach (var item in Ejemplares)
                {
                    if (item.Estado != EstadoEjemplar.Malo)
                    {
                        item.Disponible = true;
                        item.Baja = false;
                    }
                    
                }
            }
        }
    }
}
