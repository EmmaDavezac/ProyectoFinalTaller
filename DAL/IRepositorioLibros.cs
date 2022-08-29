using Dominio;
using System.Collections.Generic;

namespace DAL
{
    public interface IRepositorioLibros : IRepositorio<Libro>
    {
        List<string> GetAllISBN();
        List<string> GetAllTitulo();
    }
}
