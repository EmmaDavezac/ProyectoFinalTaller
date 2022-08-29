using Dominio;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.EntityFramework
{
    public class RepositorioLibros : Repositorio<Libro, AdministradorDePrestamosDbContext>, IRepositorioLibros
    {
        public RepositorioLibros(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
        public List<string> GetAllISBN()
        {
            return this.iDbContext.Set<Libro>().Select(x => x.ISBN).ToList();
        }

        public List<string> GetAllTitulo()
        {
            return this.iDbContext.Set<Libro>().Select(x => x.Titulo).ToList();
        }
    }
}
