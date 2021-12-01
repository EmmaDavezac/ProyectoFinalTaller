using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dominio;

namespace DAL.EntityFramework
{
    public class RepositorioLibros:Repositorio <Libro, AdministradorDePrestamosDbContext>, IRepositorioLibros
    {
        public RepositorioLibros(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
