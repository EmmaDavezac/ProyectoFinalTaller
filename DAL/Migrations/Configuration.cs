namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EntityFramework.AdministradorDePrestamosDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.EntityFramework.AdministradorDePrestamosDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Administradores.AddOrUpdate(x => x.NombreUsuario, new Dominio.UsuarioAdministrador()
            {
                NombreUsuario = "admin",
                Pass = "admin",
                Nombre = "admin",
                Apellido="admin",
                Id = 1,
                FechaNacimiento = new DateTime(1900, 1, 1),
            }); ;
        }
    }
}
