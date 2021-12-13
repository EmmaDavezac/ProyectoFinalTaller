
using System.Data.Entity;
using Dominio;

namespace DAL.EntityFramework
{
    public class AdministradorDePrestamosDbContext:DbContext
        
    {
        
        public AdministradorDePrestamosDbContext(string cadena):base(cadena)
        {

        }
      

        public IDbSet<Libro> Libros { get; set; }

        public IDbSet<Ejemplar> Ejemplares { get; set; }

        public IDbSet<Prestamo> Prestamos { get; set; }
        public IDbSet<UsuarioSimple> Usuarios { get; set; }
        public IDbSet<UsuarioAdministrador> Administradores { get; set; }
    }
}
