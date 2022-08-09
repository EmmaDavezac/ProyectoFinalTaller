
using Dominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL.EntityFramework
{
    public class AdministradorDePrestamosDbContext : DbContext
    {
     
        static private string[] cadenasDeConexionMSSQLSERVER = new string[] { "ConnectionSQLServerLocal", "ConnectionSQLServerHosting" };
        static private string cadenaDeConexion = cadenasDeConexionMSSQLSERVER[0];
        public AdministradorDePrestamosDbContext() : base(cadenaDeConexion)
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
