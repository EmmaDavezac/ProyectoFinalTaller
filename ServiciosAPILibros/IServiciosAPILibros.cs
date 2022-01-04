using Dominio;
using System.Collections.Generic;

namespace ServiciosAPILibros
{
    public interface IServiciosAPILibros
    {
        List<Libro> ListaPorCoincidecia(string cadena);
        void BuscarPorISBN(string isbn);//hay que corregirlo en APIOpenLibrary
    }
}
