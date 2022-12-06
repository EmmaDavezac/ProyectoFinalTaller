using System;

namespace Dominio
{
    /// <summary>
    /// Resumen:Esta clase hereda de la clase Usuario y representa un usuarioAdministrador que es quien usa el programa
    /// </summary>
    public class UsuarioAdministrador : Usuario
    {   /// <summary>
        /// Resumen:Contraseña para acceder al programa
        /// </summary>
        public string Pass { get; set; }

        /// <summary>
        /// Resumen>:Metodo que nos permite saber si la contraseña ingresada para acceder es correcta sin divulgar la contraseña real
        /// </summary>
        /// <param name="contraseña"></param>
        /// <returns>True si las contraseñas coinciden, False en caso contrario</returns>
        public bool VerificarContraseña(string contraseña)
        {
            return contraseña == Pass;
        }

        /// <summary>
        /// Resumen:Constructor de la clase que hace uso del contructor de la clase padre
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="mail"></param>
        /// <param name="contraseña"></param>
        /// <param name="telefono"></param>
        /// <param name="pNombreUsuario"></param>
        public UsuarioAdministrador(string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono, string pNombreUsuario) : base(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario)
        {
            Pass = contraseña;
        }

        /// <summary>
        /// Resumen:Constructor de la clase sin parametros
        /// </summary>
        public UsuarioAdministrador()
        {
        }
    }
}
