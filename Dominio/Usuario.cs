using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Usuario //Clase que representa un usuario, a partir de esta heredan las clases UsuarioSimple y UsuarioAdministrador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }//Nombre o nombres del usuario
        public string Apellido { get; set; }//Apellido o Apellidos del usuario
        public DateTime FechaNacimiento { get; set; }//Fecha de nacimiento del usuario
        public string Mail { get; set; }//Email del usuario
        public string Telefono { get; set; }//Numero de telefono del usuario
        [Key]
        public string NombreUsuario { get; set; }//Nos permite diferenciar a los usuarios
        public bool Baja { get; set; }//Campo para dar una baja logica al usuario

        public Usuario(string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono, string pNombreUsuario)//constructor de la clase
        {
            
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Mail = mail;
            Telefono = telefono;
            NombreUsuario = pNombreUsuario;
            Baja = false;
        }

        public Usuario()//constructor de la clase sin parametro
        {

        }
    }
}
