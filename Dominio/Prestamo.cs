﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Prestamo
    {
        public int Id { get; set; }
        public string FechaPrestamo { get; set; }
        public string FechaLimite { get; set; }
        public string FechaDevolucion { get; set; }
        public EstadoEjemplar EstadoInicial { get; set; }
        public EstadoEjemplar EstadoDevolucion { get; set; }
        public string nombreUsuario { get; set; }
        [ForeignKey("nombreUsuario")]
        virtual public UsuarioSimple Usuario { get; set; }
        public int idEjemplar { get; set; }
        [ForeignKey("idEjemplar")]
        public virtual Ejemplar Ejemplar { get; set; }
        private DateTime CalcularFechaLimite(UsuarioSimple usuario)
        { int scoring = usuario.Scoring;

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
            FechaPrestamo = DateTime.Now.ToString();
            FechaLimite = CalcularFechaLimite(usuario).Date.ToString();
            Usuario = usuario;
            Ejemplar = ejemplar;
            EstadoInicial = ejemplar.Estado;


        }
        public Prestamo()
        {

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
        {   int cantDiasParaConsiderarseProximo = 5;
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
            if (EstadoDevolucion<EstadoInicial)
            {
                scoring -= 10;
            }
            if (Retrasado())
            {
                TimeSpan difFechas = Convert.ToDateTime(FechaDevolucion) - Convert.ToDateTime(FechaLimite);
                int dias = difFechas.Days;
                scoring -= 2 * dias;
            }
            else if (!(EstadoDevolucion < EstadoInicial))
            {
                scoring += 5;
            }
            return scoring;
        }
       public void RegistrarDevolucion(EstadoEjemplar estadoDevolucion)
        {
            EstadoDevolucion = estadoDevolucion;
            Ejemplar.Estado = EstadoDevolucion;
            Ejemplar.Disponible = true;
            FechaDevolucion = DateTime.Now.Date.ToString();
            Usuario.Scoring = CalcularScoring(Usuario);
        }

    }
}
