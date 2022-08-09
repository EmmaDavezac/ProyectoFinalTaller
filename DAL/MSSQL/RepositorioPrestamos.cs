using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EntityFramework
{
    public class RepositorioPrestamos : Repositorio<Prestamo, AdministradorDePrestamosDbContext>, IRepositorioPrestamos
    {
        public RepositorioPrestamos(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {

        }

        public List<Prestamo> GetAllProximosAVencerse()
        {
            return this.iDbContext.Set<Prestamo>().ToList().Where(x => x.ProximoAVencerse() == true).ToList();
        }

        public List<Prestamo> GetAllRestrasados()
        {
            return this.iDbContext.Set<Prestamo>().ToList().Where(x => x.Retrasado() == true).ToList();
        }
    }
}
