using Dominio;
using System.Collections.Generic;

namespace DAL
{   /// <summary>
/// RESUMEN: Esta interface hereda de IRepositorio y establece los metodos que debe tener una implementacion de Repositorio de Prestamos
/// </summary>
    public interface IRepositorioPrestamos : IRepositorio<Prestamo>
    {
        List<Prestamo> GetAllRestrasados();
        List<Prestamo> GetAllProximosAVencerse();
    }
}
