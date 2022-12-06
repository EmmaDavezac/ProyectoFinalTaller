using System;
using System.Data.Entity.Migrations;

namespace DAL.Migrations
{   /// <summary>
/// Resumen: esta clase es el archivo de configuracion de la migracion de la base de datos
/// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EntityFramework.AdministradorDePrestamosDbContext>
    {   /// <summary>
        /// RESUMEN: Constructor de la clase
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        /// <summary>
        /// Resumen: al momento de hacer la migracion, en caso de no existir el usuario admin, se agrega a la base de los datos y en el caso de existir se sobrescriben los datos.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DAL.EntityFramework.AdministradorDePrestamosDbContext context)
        {
            context.Administradores.AddOrUpdate(x => x.NombreUsuario, new Dominio.UsuarioAdministrador()
            {
                NombreUsuario = "admin",
                Pass = "admin",
                Nombre = "admin",
                Apellido = "admin",
                Mail = "admin@gmail.com",
                Telefono = "34421234",
                FechaNacimiento = new DateTime(1900, 1, 1),
            });
        }
    }
}
