using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
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
