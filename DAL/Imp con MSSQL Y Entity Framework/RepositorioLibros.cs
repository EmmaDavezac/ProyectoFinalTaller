using Dominio;

namespace DAL.EntityFramework
{
    public class RepositorioLibros : Repositorio<Libro, AdministradorDePrestamosDbContext>, IRepositorioLibros
    {
        public RepositorioLibros(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
