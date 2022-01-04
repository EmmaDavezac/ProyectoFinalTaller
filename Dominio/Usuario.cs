using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        [Key]
        public string NombreUsuario { get; set; }
        public bool Baja { get; set; }

        public Usuario(string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono, string pNombreUsuario)
        {
            Id = 3;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Mail = mail;
            Telefono = telefono;
            NombreUsuario = pNombreUsuario;
            Baja = false;
        }

        public Usuario()
        {

        }
    }
}