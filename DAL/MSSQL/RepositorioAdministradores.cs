using Dominio;

namespace DAL.EntityFramework
{   /// <summary>
/// RESUMEN: Esta clase hereda de repositorio y es un repositorio de Administradores
/// </summary>
    class RepositorioAdministradores : Repositorio<UsuarioAdministrador, AdministradorDePrestamosDbContext>, IRepositorioAdministradores
    {   /// <summary>
        /// RESUMEN:constructor de la clase
        /// </summary>
        /// <param name="pDbContext"></param>
        public RepositorioAdministradores(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
    }
}
