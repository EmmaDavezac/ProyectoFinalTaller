using Dominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL.EntityFramework
{   /// <summary>
/// RESUMEN: Esta clase, perteneciente al paquete de EntityFrameWork, nos permitirá entre otras cosas configurar las entidades (tablas) de nuestra base de datos, configurar los índices compuestos de las tablas y acceder a los datos de dichas tablas mediante código C#.
/// </summary>
    public class AdministradorDePrestamosDbContext : DbContext
    {   /// <summary>
        /// Resumen: este array contine las distintas cadenas de conexion a base de datos. En este caso una es de una base de datos local y la otra a una en un servidor remoto. Ambas son base de datos MSSQLSERVER
        /// </summary>
        private static string[] cadenasDeConexionMSSQLSERVER = new string[] {
                                                                                "ConnectionSQLServerLocal",
                                                                                "ConnectionSQLServerHosting"
                                                                            };
        /// <summary>
        /// Resumen: Este atributo almacena la cadena de conexion que utilizaremos, en nuestro caso el de la base de datos local.
        /// </summary>
        private static string cadenaDeConexion = cadenasDeConexionMSSQLSERVER[0];
        /// <summary>
        /// RESUMEN: Constructor de la clase
        /// </summary>
        public AdministradorDePrestamosDbContext() :
            base(cadenaDeConexion)
        {
            if (!Database.Exists())
            {
                Database
                    .SetInitializer(new MigrateDatabaseToLatestVersion<AdministradorDePrestamosDbContext, DAL.Migrations.Configuration>());
            }
        }
        /// <summary>
        /// RESUMEN:representa la colección de todos los Libros del contexto, o que se pueden consultar desde la base de datos
        /// </summary>
        public IDbSet<Libro> Libros { get; set; }
        /// <summary>
        /// RESUMEN:representa la colección de todos los Ejemplares del contexto, o que se pueden consultar desde la base de datos
        /// </summary>
        public IDbSet<Ejemplar> Ejemplares { get; set; }
        /// <summary>
        /// RESUMEN:representa la colección de todos los Prestamos del contexto, o que se pueden consultar desde la base de datos
        /// </summary>
        public IDbSet<Prestamo> Prestamos { get; set; }
        /// <summary>
        /// RESUMEN:representa la colección de todos los Usuarios del contexto, o que se pueden consultar desde la base de datos
        /// </summary>
        public IDbSet<UsuarioSimple> Usuarios { get; set; }
        /// <summary>
        /// RESUMEN:representa la colección de todos los Administradores del contexto, o que se pueden consultar desde la base de datos
        /// </summary>
        public IDbSet<UsuarioAdministrador> Administradores { get; set; }
        /// <summary>
        /// RESUMEN:Generador que se usa para construir el modelo para este contexto
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
