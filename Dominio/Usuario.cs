using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    /// <summary>
    /// Resumen:Clase abstracta que representa un usuario, a partir de esta heredan las clases UsuarioSimple y UsuarioAdministrador
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Resumen:Nombre o nombres del usuario
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Apellido { get; set; }//Apellido o Apellidos del usuario

        /// <summary>
        /// 
        /// </summary>
        public DateTime FechaNacimiento { get; set; }//Fecha de nacimiento del usuario

        /// <summary>
        /// 
        /// </summary>
        public string Mail { get; set; }//Email del usuario

        /// <summary>
        /// 
        /// </summary>
        public string Telefono { get; set; }//Numero de telefono del usuario

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public string NombreUsuario { get; set; }//Nos permite diferenciar a los usuarios

        /// <summary>
        /// 
        /// </summary>
        public bool Baja { get; set; }//Campo para dar una baja logica al usuario

        /// <summary>
        /// Resumen:constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="mail"></param>
        /// <param name="telefono"></param>
        /// <param name="pNombreUsuario"></param>
        public Usuario(string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono, string pNombreUsuario)//

        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Mail = mail;
            Telefono = telefono;
            NombreUsuario = pNombreUsuario;
            Baja = false;
        }

        /// <summary>
        /// Resumen:Constructor de la clase sin parametro
        /// </summary>
        public Usuario()
        {
        }
    }
}
