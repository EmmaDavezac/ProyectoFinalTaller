using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Prestamo//Esta clase tiene como finalidad representar un prestamo de un ejemplar
    {
        public int Id { get; set; }//Clave primaria que nos permite diferenciar los prestamos
        public string FechaPrestamo { get; set; }//Fecha en que se realizo el prestamo
        public string FechaLimite { get; set; }//Fecha en la que vence el presamo
        public string FechaDevolucion { get; set; }//Fecha en la que se devolvio el prestamo
        public EstadoPrestamo EstadoPrestamo { get; set; }//Estado del ejemplar(Normal,Proximo a vencer,Retrasado)
        public EstadoEjemplar EstadoDevolucion { get; set; }//Estado de devolucion del ejemplar
        public string nombreUsuario { get; set; }//Clave foranea que permite relacionar el usuario con el prestamo
        [ForeignKey("nombreUsuario")]
        public virtual UsuarioSimple Usuario { get; set; }// Instancia del usuario relacionado al prestamo
        public int idEjemplar { get; set; }//Clave foranea que nos permite relacionar el prestamo con el ejemplar
        [ForeignKey("idEjemplar")]
        public virtual Ejemplar Ejemplar { get; set; }//Instancia del ejemplar relacionado al prestamo
        public int idLibro { get; set; }//id del libro
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
        public Prestamo(UsuarioSimple usuario, Ejemplar ejemplar, Libro libro)//Constructor de la clase 
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
        public Prestamo()//Constructor de la clase sin parametros
        {

        }

        public EstadoPrestamo ActualizarEstado()//Este metodo nos permite actualizar el estado actual del prestamo y devolverlo
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

        public bool Retrasado()//Este metodo nos permite saber si el prestamo se encuenta retrasado
        {

            if ((DateTime.Now.Date > Convert.ToDateTime(FechaLimite).Date))
            {
                if (string.IsNullOrEmpty(FechaDevolucion))
                { return true; }
                else return false;
                }
            else return false;

        }
        public bool ProximoAVencerse()//Este metodo nos permite saber si un prestamo esta proximo a vencerse
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
        private int CalcularScoring(UsuarioSimple usuario)//Este metodo nos permite actualizar el scoring de un usario luego de devuelto el ejemplar
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
        public void RegistrarDevolucion(EstadoEjemplar estadoDevolucion)//Este metodo nos permite permite registrar la devolucion de un ejemplar
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
