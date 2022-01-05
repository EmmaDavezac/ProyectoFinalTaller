using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Prestamo
    {
        public int Id { get; set; }
        public string FechaPrestamo { get; set; }
        public string FechaLimite { get; set; }
        public string FechaDevolucion { get; set; }
        public EstadoPrestamo EstadoPrestamo { get; set; }
        public EstadoEjemplar EstadoDevolucion { get; set; }
        public string nombreUsuario { get; set; }
        [ForeignKey("nombreUsuario")]
        public virtual UsuarioSimple Usuario { get; set; }
        public int idEjemplar { get; set; }
        [ForeignKey("idEjemplar")]
        public virtual Ejemplar Ejemplar { get; set; }
        public string TituloLibro { get; set; }
        public string ISBNLibro { get; set; }
        public int idLibro { get; set; }
        private DateTime CalcularFechaLimite(UsuarioSimple usuario)
        {
            int scoring = usuario.Scoring;

            if (scoring >= 0)
            {
                int aux = scoring / 5;
                if (aux >= 10)
                {
                    return DateTime.Now.AddDays(15);
                }
                else return DateTime.Now.AddDays(5 + aux);
            }
            else return DateTime.Now.AddDays(5);
        }
        public Prestamo(UsuarioSimple usuario, Ejemplar ejemplar, Libro libro)
        {
            FechaPrestamo = DateTime.Now.ToShortDateString();
            FechaLimite = CalcularFechaLimite(usuario).ToShortDateString();
            nombreUsuario = usuario.NombreUsuario;
            Usuario = usuario;
            idEjemplar = ejemplar.Id;
            Ejemplar = ejemplar;
            EstadoPrestamo = EstadoPrestamo.Normal;
            TituloLibro = libro.Titulo;
            ISBNLibro = libro.ISBN;
            idLibro = libro.Id;
        }
        public Prestamo()
        {

        }

        public EstadoPrestamo ActualizarEstado()
        {
            if (Retrasado() )
            {
                EstadoPrestamo = EstadoPrestamo.Retrasado;
            }
            else if (ProximoAVencerse() )
            {
                EstadoPrestamo = EstadoPrestamo.ProximoAVencer;
            }
            else
            {
                EstadoPrestamo = EstadoPrestamo.Normal;
            }
            return EstadoPrestamo;
        }

        public bool Retrasado()
        {
            if ((DateTime.Now.Date > Convert.ToDateTime(FechaLimite).Date))
            {
                return true;
            }
            else return false;

        }
        public bool ProximoAVencerse()
        {
            int cantDiasParaConsiderarseProximo = 3;
            if (!this.Retrasado())
            {
                if (string.IsNullOrEmpty(FechaDevolucion))
                {
                    TimeSpan diferenciaEntreFechas = Convert.ToDateTime(FechaLimite) - DateTime.Now;
                    int dias = diferenciaEntreFechas.Days;
                    if (dias < cantDiasParaConsiderarseProximo)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
        private int CalcularScoring(UsuarioSimple usuario)
        {
            int scoring = usuario.Scoring;
            if (EstadoDevolucion == EstadoEjemplar.Malo)
            {
                scoring -= 10;
            }
            if (Retrasado())
            {
                TimeSpan difFechas = Convert.ToDateTime(FechaDevolucion) - Convert.ToDateTime(FechaLimite);
                int dias = difFechas.Days;
                scoring -= 2 * dias;
            }
            else if (EstadoDevolucion == EstadoEjemplar.Bueno)
            {
                scoring += 5;
            }
            return scoring;
        }
        public void RegistrarDevolucion(EstadoEjemplar estadoDevolucion)
        {
            EstadoDevolucion = estadoDevolucion;
            Ejemplar.Estado = estadoDevolucion;
            Ejemplar.Disponible = true;
            FechaDevolucion = DateTime.Now.Date.ToString();
            Usuario.Scoring = CalcularScoring(Usuario);
        }
    }
}
