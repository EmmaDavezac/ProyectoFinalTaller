using Dominio;
using System.Collections.Generic;

namespace DAL
{   /// <summary>
/// RESUMEN: Esta interface hereda de IRepositorio y establece los metodos que debe tener una implementacion de Repositorio de Libros
/// </summary>
    public interface IRepositorioLibros : IRepositorio<Libro>
    {
        List<string> GetAllISBNs();
        List<string> GetAllTitulos();
        bool ContainsISBN(string unISBN);
        bool ContainsTitulos(string unTitulo);
    }
}
