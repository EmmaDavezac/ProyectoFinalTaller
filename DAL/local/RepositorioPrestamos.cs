using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dominio;

namespace DAL.local
{
    class RepositorioPrestamos : Repositorio<Prestamo, AdministradorDePrestamosDbContext>, IRepositorioPrestamos
    {
        public RepositorioPrestamos(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
