using Dominio;

namespace DAL.EntityFramework
{
    class RepositorioAdministradores : Repositorio<UsuarioAdministrador, AdministradorDePrestamosDbContext>, IRepositorioAdministradores
    {
        public RepositorioAdministradores(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
