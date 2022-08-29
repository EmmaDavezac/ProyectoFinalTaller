using Dominio;
using System.Collections.Generic;

namespace DAL
{
    public interface IRepositorioPrestamos : IRepositorio<Prestamo>
    {
        List<Prestamo> GetAllRestrasados();
        List<Prestamo> GetAllProximosAVencerse();
    }
}
