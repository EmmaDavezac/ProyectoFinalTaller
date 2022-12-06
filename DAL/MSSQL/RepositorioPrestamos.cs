using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EntityFramework
{     /// <summary>
/// RESUMEN: Esta clase hereda de repositorio y es un repositorio de Prestamos
/// </summary>
    public class RepositorioPrestamos : Repositorio<Prestamo, AdministradorDePrestamosDbContext>, IRepositorioPrestamos
    {   /// <summary>
        /// Resumen:Constructor de la clase
        /// </summary>
        /// <param name="pDbContext"></param>
        public RepositorioPrestamos(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
        /// <summary>
        /// RESUMEN: Este metodo devuelve todos los prestamos proximos a vencer del repositorio
        /// </summary>
        /// <returns></returns>
        public List<Prestamo> GetAllProximosAVencerse()
        {
            return this.iDbContext.Set<Prestamo>().ToList().Where(x => x.ProximoAVencerse() == true).ToList();
        }
        /// <summary>
        /// RESUMEN: Este metodo devuelve todos los prestamos proximos a vencer del repositorio
        /// </summary>
        /// <returns></returns>
        public List<Prestamo> GetAllRestrasados()
        {
            return this.iDbContext.Set<Prestamo>().ToList().Where(x => x.Retrasado() == true).ToList();
        }
    }
}
