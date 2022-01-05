using Dominio;

namespace DAL.EntityFramework
{
    public class RepositorioPrestamos : Repositorio<Prestamo, AdministradorDePrestamosDbContext>, IRepositorioPrestamos
    {
        public RepositorioPrestamos(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
