using System;
using System.Collections.Generic;

namespace Dominio
{
    /// <summary>
    /// Resumen: Esta clase hereda de la clase Usuario y representa un Usuario Simple  que es quien solicita un prestamo y no usa el Sistema
    /// </summary>
    public class UsuarioSimple : Usuario
    {
        /// <summary>
        /// Resumen: Lista de prestamos del Usuario
        /// </summary>
        public virtual List<Prestamo> Prestamos { get; set; }

        /// <summary>
        /// Resumen: Puntaje del Usuario
        /// </summary>
        public int Scoring { get; set; }

        /// <summary>
        /// Resumen: Constructor de la clase que utiliza el constructor de la clase padre
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="mail"></param>
        /// <param name="telefono"></param>
        /// <param name="pNombreUsuario"></param>
        public UsuarioSimple(string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono, string pNombreUsuario) : base(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario)
        {
            Scoring = 0;
        }


        /// <summary>
        /// Resumen: Constructor de la clase que no toma parametros
        /// </summary>
        public UsuarioSimple()
        {
        }

        /// <summary>
        /// Resumen: Verifica si el usuario se puede dar de baja o no cumple con las condiciones
        /// </summary>
        /// <returns></returns>
        public bool ValidarBaja()
        {
            bool resultado = true;
            if (Prestamos == null)
            {
                resultado = true;
            }
            else
            {
                foreach (var item in Prestamos)
                {
                    if (item.FechaDevolucion == null)
                    {
                        resultado = false;
                    }
                }
            }
            return resultado;
        }
    }
}