
using System.Data.Entity;
using Dominio;

namespace DAL.EntityFramework
{
    public class AdministradorDePrestamosDbContext:DbContext
    {
        public IDbSet<Libro> Libros { get; set; }

        public IDbSet<Ejemplar> Ejemplares { get; set; }

        public IDbSet<Prestamo> prestamos { get; set; }

        public IDbSet<UsuarioSimple> Usuarios { get; set; }
        public IDbSet<UsuarioAdministrador> Administradors { get; set; }
    }
}
