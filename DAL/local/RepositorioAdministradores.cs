using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dominio;

namespace DAL.local
{
    class RepositorioAdministradores : Repositorio<UsuarioAdministrador, AdministradorDePrestamosDbContext>, IRepositorioAdministradores
    {
        public RepositorioAdministradores(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
