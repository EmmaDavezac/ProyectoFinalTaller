using System;

namespace Dominio
{
    public class UsuarioAdministrador : Usuario//Esta clase hereda de la clase Usuario y representa un usuarioAdministrador que es quien usa el programa
    {
        public string Pass { get; set; }//Contraseña para acceder al programa
        public bool VerificarContraseña(string contraseña)//Metodo que nos permite saber si la contraseña ingresada para acceder es correcta sin divulgar la contraseña real
        { return contraseña == Pass; }

        public UsuarioAdministrador(string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono, string pNombreUsuario) : base(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario)//Constructor de la clase que hace uso del contructor de la clase padre
        {
            Pass = contraseña;
        }

        public UsuarioAdministrador()//Constructor de la clase sin argumentos
        {

        }
    }
}
