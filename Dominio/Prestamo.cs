using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Prestamo
    {
        public int Id { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaLimite { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public EstadoEjemplar EstadoInicial { get; set; }
        public EstadoEjemplar EstadoDevolucion { get; set; }
       virtual public UsuarioSimple Usuario { get; set; }
        private DateTime CalcularFechaLimite()
        { int scoring = Usuario.Scoring;

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
        public Prestamo(UsuarioSimple usuario, Ejemplar ejemplar)
        {
            FechaPrestamo = DateTime.Now;
            FechaLimite = CalcularFechaLimite();
            EstadoInicial = ejemplar.Estado;
            ejemplar.Disponible = false;

        }
        public bool Retrasado()
        {
            if (DateTime.Now > FechaLimite)
            {
                return true;
            }
            else return false;

        }
        public bool ProximoAVencerse()
        {
            if (!Retrasado())
            {
                TimeSpan diferenciaEntreFechas = FechaLimite - DateTime.Now;
                int dias = diferenciaEntreFechas.Days;
                if (dias < 3)
                {
                    return true;
                }
                else return false;
            }
            else return true; }
        private int CalcularScoring()
        { 
            int scoring = Usuario.Scoring;
            if (EstadoDevolucion<EstadoInicial)
            {
                scoring -= 10;
            }
            if (Retrasado())
            {
                TimeSpan difFechas = FechaDevolucion - FechaLimite;
                int dias = difFechas.Days;
                scoring -= 2 * dias;
            }
            else if (!(EstadoDevolucion < EstadoInicial))
            {
                scoring += 5;
            }
            return scoring;
        }
       public void RegistrarDevolucion(EstadoEjemplar estadoDevolucion,Ejemplar ejemplar)
        {
            EstadoDevolucion = estadoDevolucion;
            ejemplar.Estado = EstadoDevolucion;
            FechaDevolucion = DateTime.Now;
            Usuario.Scoring = CalcularScoring();
        }

    }
}
