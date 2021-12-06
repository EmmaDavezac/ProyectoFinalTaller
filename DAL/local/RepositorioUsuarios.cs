using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dominio;

namespace DAL.local
{
    class RepositorioUsuarios : Repositorio<UsuarioSimple, AdministradorDePrestamosDbContext>, IRepositorioUsuarios
    {
        public RepositorioUsuarios(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}
