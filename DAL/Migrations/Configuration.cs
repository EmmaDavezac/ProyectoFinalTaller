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
