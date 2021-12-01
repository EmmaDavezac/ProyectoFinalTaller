using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UsuarioAdministrador:Usuario
    {
        public string Pass{ get; set; }
        public bool VerificarContraseña(string contraseña)
        { return contraseña == Pass; }

        public UsuarioAdministrador()
        {
            
        }
        public UsuarioAdministrador(string nombre, string apellido, DateTime fechaNacimiento, string mail,string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Mail = mail;
            Pass = contraseña;
        }
    }
}
