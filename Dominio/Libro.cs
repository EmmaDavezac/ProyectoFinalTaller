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
        public bool Baja { get; set; }


        public Libro()
        {

        }

        public Libro(string unISBN, string titulo, string autor, string añoPublicacion)
        {
            ISBN = unISBN;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Baja = false;
        }

        public List<Ejemplar> EjemplaresDisponibles()
        { List<Ejemplar> ejemplaresDisponibles = new List<Ejemplar>();
            foreach (var item in this.Ejemplares)
            {
                if (item.Disponible && item.Estado == EstadoEjemplar.Bueno)
                {
                    ejemplaresDisponibles.Add(item);
                }
               
            }
            return ejemplaresDisponibles;
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
            int i = 1;
            foreach (var item in Ejemplares)
            {
                if (i > pCantidad)
                {
                    break;
                }
                else if (item.Disponible == true)
                {
                    item.Disponible = false;
                    item.Estado = EstadoEjemplar.Malo;
                    i = i + 1;
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
                    item.Disponible = false;
                    item.Baja = true;
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
                    item.Disponible = true;
                    item.Baja = false;
                }
            }
        }
    }
}
