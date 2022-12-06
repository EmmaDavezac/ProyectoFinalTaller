using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EntityFramework
{   /// <summary>
/// RESUMEN: Esta clase hereda de repositorio y es un repositorio de Libros
/// </summary>
    public class RepositorioLibros : Repositorio<Libro, AdministradorDePrestamosDbContext>, IRepositorioLibros
    {    // <summary>
        /// RESUMEN:constructor de la clase
        /// </summary>
        /// <param name="pDbContext"></param>
        public RepositorioLibros(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
        /// <summary>
        /// RESUMEN: Este metodo devuelve todos los isbn del repositorio de libros
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllISBN()
        {
            return this.iDbContext.Set<Libro>().Select(x => x.ISBN).ToList();
        }
        /// <summary>
        /// RESUMEN: Este metodo devuelve todos los isbn del repositorio de libros
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllTitulo()
        {
            return this.iDbContext.Set<Libro>().Select(x => x.Titulo).ToList();
        }
    }
}
