using Dominio;
using System.Collections.Generic;

namespace ServiciosAPILibros
{
    /// <summary>
    /// Resumen:Interface que nos consultar  informacion sobre libros en alguna API de libros
    /// </summary>
    public interface IServicioAPILibros
    {   /// <summary>
        /// Resumen: Nos permite obtener una lista de libros que coinciden con el termino buscado
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Una lista de libros</returns>
        List<Libro> ConsultarlistadoDeLibros(string cadena);


    }
}
