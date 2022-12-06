using Dominio;

namespace DAL.EntityFramework
{   /// <summary>
/// RESUMEN: Esta clase hereda de repositorio y es un repositorio de Ejemplares
/// </summary>
    public class RepositorioEjemplares : Repositorio<Ejemplar, AdministradorDePrestamosDbContext>, IRepositorioEjemplares
    {   // <summary>
        /// RESUMEN:constructor de la clase
        /// </summary>
        /// <param name="pDbContext"></param>
        public RepositorioEjemplares(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
    }
}
