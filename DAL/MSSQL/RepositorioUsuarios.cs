using Dominio;

namespace DAL.EntityFramework
{   
/// <summary>
/// RESUMEN: Esta clase hereda de repositorio y es un repositorio de Usuarios
/// </summary>
    class RepositorioUsuarios : Repositorio<UsuarioSimple, AdministradorDePrestamosDbContext>, IRepositorioUsuarios
    {   /// <summary>
        /// RESUMEN:Constructor de la clase
        /// </summary>
        /// <param name="pDbContext"></param>
        public RepositorioUsuarios(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
    }
}
