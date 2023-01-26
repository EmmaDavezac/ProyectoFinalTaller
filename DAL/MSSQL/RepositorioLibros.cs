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
        public List<string> GetAllISBNs()
        {
            return this.iDbContext.Set<Libro>().Select(x => x.ISBN).ToList();
        }
        /// <summary>
        /// RESUMEN: Este metodo devuelve todos los isbn del repositorio de libros
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllTitulos()
        {
            return this.iDbContext.Set<Libro>().Select(x => x.Titulo).ToList();
        }

        /// <summary>
        /// Resumen: Booleano que indica si existe algun libro en el repositorio con ese valor de ISBN
        /// </summary>
        /// <param name="pISBN"></param>
        /// <returns></returns>
        public bool ContainsISBN(string pISBN)
        {
            return this.GetAllISBNs().Contains(pISBN);
        }

        /// <summary>
        /// Resumen: Booleano que indica si existe algun libro en el repositorio con ese titulo
        /// </summary>
        /// <param name="pTitulo"></param>
        /// <returns></returns>
        public bool ContainsTitulo(string pTitulo)
        {
                return this.GetAllTitulos().Contains(pTitulo);
        }
    }
}
