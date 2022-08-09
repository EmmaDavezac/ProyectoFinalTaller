using Dominio;

namespace DAL.EntityFramework
{
    public class RepositorioEjemplares : Repositorio<Ejemplar, AdministradorDePrestamosDbContext>, IRepositorioEjemplares
    {
        public RepositorioEjemplares(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
