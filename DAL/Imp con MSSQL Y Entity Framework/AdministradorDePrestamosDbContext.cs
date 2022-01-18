
using Dominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL.EntityFramework
{
    public class AdministradorDePrestamosDbContext : DbContext
    {
        static private string[] implementacionesBase = new string[] { "ConnectionSQLServerLocal", "ConnectionSQLServerHosting" };
        static private string implementacionBase = implementacionesBase[1];

        public AdministradorDePrestamosDbContext(string cadena) : base(cadena)
        {
        
        }

        public AdministradorDePrestamosDbContext() : base(implementacionBase)
        {

        }

        public IDbSet<Libro> Libros { get; set; }

        public IDbSet<Ejemplar> Ejemplares { get; set; }

        public IDbSet<Prestamo> Prestamos { get; set; }
        public IDbSet<UsuarioSimple> Usuarios { get; set; }
        public IDbSet<UsuarioAdministrador> Administradores { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
