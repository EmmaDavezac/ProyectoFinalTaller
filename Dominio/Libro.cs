using System.Collections.Generic;

namespace Dominio
{/// <summary>
/// Resumen:Esta clase es una abstracciòn de un Libro
/// </summary>
    public class Libro

    {   /// <summary>
        /// Resumen:Clave primaria que nos permite diferenciar los libros entre si
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Resumen:Codigo ISBN del libro (en el caso de que lo tenga)
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Resumen:Titulo del libro
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Resumen:Nombre del autor del libro
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Resumen:Nombre del autor del libro
        /// </summary>
        public string AñoPublicacion { get; set; }

        /// <summary>
        /// Resumen:Lista de ejemplares del libro
        /// </summary>
        public virtual List<Ejemplar> Ejemplares { get; set; }

        /// <summary>
        /// Resumen:Property que nos permite dar una baja logica al libro
        /// </summary>
        public bool Baja { get; set; }

        /// <summary>
        /// Resumen:Constructor de la clase sin argumentos
        /// </summary>
        public Libro()
        {
        }

        /// <summary>
        /// Resumen:Constructor de la clase
        /// </summary>
        /// <param name="unISBN"></param>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="añoPublicacion"></param>
        public Libro(string unISBN, string titulo, string autor, string añoPublicacion)
        {
            ISBN = unISBN;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Baja = false;
            Ejemplares = new List<Ejemplar>();
        }

        /// <summary>
        /// Resumen:Metodo que nos devuelve la lista de ejemplares del libro que se encuentran disponibles para prestarse actualmente
        /// </summary>
        /// <returns></returns>
        public List<Ejemplar> EjemplaresDisponibles()
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

        /// <summary>
        /// Resumen:Devuelve una lista con todos los ejemplares del libro que se encuentran en buen estado
        /// </summary>
        /// <returns>List Ejemplar</returns>
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

        /// <summary>
        /// Resumen: Devuelve una lista con todos los ejemplares del libro
        /// </summary>
        /// <returns>List Ejemplar</returns>
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

        /// <summary>
        /// Resumen: Elimina nCantidad de ejemplares del libro
        /// </summary>
        /// <param name="pCantidad"></param>
        public void EliminarEjemplares(int nCantidad)
        {
            int e = 0;
            foreach (var item in Ejemplares)
            {
                if (e >= nCantidad)
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

        /// <summary>
        /// Resumen: Da de baja el libro
        /// </summary>
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

        /// <summary>
        /// Resumen:Da de alta el libro
        /// </summary>
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
