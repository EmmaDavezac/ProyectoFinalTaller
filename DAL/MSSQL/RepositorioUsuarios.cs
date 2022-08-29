using Dominio;

namespace DAL.EntityFramework
{
    class RepositorioUsuarios : Repositorio<UsuarioSimple, AdministradorDePrestamosDbContext>, IRepositorioUsuarios
    {
        public RepositorioUsuarios(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
    }
}
