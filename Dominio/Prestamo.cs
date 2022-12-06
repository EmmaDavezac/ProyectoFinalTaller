using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    /// <summary>
    /// Resumen:Esta clase tiene como finalidad representar un prestamo de un ejemplar
    /// </summary>
    public class Prestamo
    {
        /// <summary>
        /// Resumen:
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Resumen:Fecha en que se realizo el prestamo
        /// </summary>
        public string FechaPrestamo { get; set; }

        /// <summary>
        /// Resumen:Fecha en la que vence el presamo
        /// </summary>
        public string FechaLimite { get; set; }

        /// <summary>
        /// Resumen:Fecha en la que se devolvio el prestamo
        /// </summary>
        public string FechaDevolucion { get; set; }

        /// <summary>
        /// Resumen:Estado del ejemplar(Normal,Proximo a vencer,Retrasado)
        /// </summary>
        public EstadoPrestamo EstadoPrestamo { get; set; }

        /// <summary>
        /// Resumen:Estado de devolucion del ejemplar
        /// </summary>
        public EstadoEjemplar EstadoDevolucion { get; set; }

        /// <summary>
        /// Resumen: Clave foranea que permite relacionar el Prestamo a un Usuario
        /// </summary>
        public string nombreUsuario { get; set; }
        [ForeignKey("nombreUsuario")]

        ///Resumen:Instancia del usuario relacionado al prestamo
        public virtual UsuarioSimple Usuario { get; set; }

        /// <summary>
        /// Resumen:Clave foranea que nos permite relacionar el prestamo con el ejemplar
        /// </summary>
        public int idEjemplar { get; set; }
        [ForeignKey("idEjemplar")]

        ///Resumen:Instancia del ejemplar relacionado al prestamo
        public virtual Ejemplar Ejemplar { get; set; }

        /// <summary>
        /// Resumen: Identificador del Libro Prestado
        /// </summary>
        public int idLibro { get; set; }//id del libro

        /// <summary>
        /// Resumen: Calcula la fecha Limite del Prestamo
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>(DateTime) Fecha Limite</returns>
        private DateTime CalcularFechaLimite(UsuarioSimple usuario)//Este metodo nos permite calcular la fecha limite para un prestamo en funcion del Scoring del usuario que solicita el prestamo
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

        /// <summary>
        /// Resumen:Constructor de la clase
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="ejemplar"></param>
        /// <param name="libro"></param>
        public Prestamo(UsuarioSimple usuario, Ejemplar ejemplar, Libro libro)
        {
            FechaPrestamo = DateTime.Now.ToShortDateString();
            FechaLimite = CalcularFechaLimite(usuario).ToShortDateString();
            nombreUsuario = usuario.NombreUsuario;
            Usuario = usuario;
            idEjemplar = ejemplar.Id;
            Ejemplar = ejemplar;
            EstadoPrestamo = EstadoPrestamo.Normal;
            idLibro = libro.Id;
        }

        /// <summary>
        /// Resumen:Constructor de la clase sin parametros
        /// </summary>
        public Prestamo()
        {

        }

        /// <summary>
        /// Resumen:Este metodo nos permite actualizar el estado actual del prestamo y devolverlo
        /// </summary>
        /// <returns>(Estado Prestamo) </returns>
        public EstadoPrestamo ActualizarEstado()
        {
            if (Retrasado())
            {
                EstadoPrestamo = EstadoPrestamo.Retrasado;
            }
            else if (ProximoAVencerse())
            {
                EstadoPrestamo = EstadoPrestamo.ProximoAVencer;
            }
            else
            {
                EstadoPrestamo = EstadoPrestamo.Normal;
            }
            return EstadoPrestamo;
        }

        /// <summary>
        /// Resumen:Este metodo nos permite saber si el prestamo se encuenta retrasado
        /// </summary>
        /// <returns>True si esta retrasado, False en caso contrario</returns>
        public bool Retrasado()//
        {
            if ((DateTime.Now.Date > Convert.ToDateTime(FechaLimite).Date))
            {
                if (string.IsNullOrEmpty(FechaDevolucion))
                { return true; }
                else return false;
            }
            else return false;
        }
        /// <summary>
        /// Resumen:Este metodo nos permite saber si un prestamo esta proximo a vencerse
        /// </summary>
        /// <returns>True si esta proximo a vencerse y false en caso contrario</returns>
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

        /// <summary>
        /// Resumen:Este metodo nos permite actualizar el scoring de un usario luego de devuelto el ejemplar
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Puntaje del usuario actualizado</returns>
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

        /// <summary>
        /// Resumen:Este metodo nos permite permite registrar la devolucion de un ejemplar
        /// </summary>
        /// <param name="estadoDevolucion"></param>
        public void RegistrarDevolucion(EstadoEjemplar estadoDevolucion)
        {
            EstadoDevolucion = estadoDevolucion;
            if (estadoDevolucion == EstadoEjemplar.Malo)
            {
                Ejemplar.Disponible = false;
                Ejemplar.Estado = estadoDevolucion;
                Ejemplar.Baja = true;
            }
            else
            {
                Ejemplar.Disponible = true;
                Ejemplar.Estado = estadoDevolucion;
                Ejemplar.Baja = false;
            }
            FechaDevolucion = DateTime.Now.Date.ToString();
            Usuario.Scoring = CalcularScoring(Usuario);
        }
    }
}
