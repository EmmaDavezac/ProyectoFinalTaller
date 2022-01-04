using System;

namespace Dominio
{
    public class UsuarioAdministrador : Usuario
    {
        public string Pass { get; set; }
        public bool VerificarContraseña(string contraseña)
        { return contraseña == Pass; }

        public UsuarioAdministrador(string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono, string pNombreUsuario) : base(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario)
        {
            Pass = contraseña;
        }

        public UsuarioAdministrador()
        {

        }
    }
}
