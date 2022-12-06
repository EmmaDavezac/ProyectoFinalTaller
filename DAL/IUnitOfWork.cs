using System;

namespace DAL
{   /// <summary>
/// Resumen: esta interfaz establece los metodos que debe tener una implementacion de UnitOfWork( encargada de manejar las transacciones con la base de datos)
/// </summary>
    public interface IUnitOfWork : IDisposable
    {
        void Complete();
        IRepositorioLibros RepositorioLibros { get; }
        IRepositorioEjemplares RepositorioEjemplares { get; }
        IRepositorioPrestamos RepositorioPrestamos { get; }
        IRepositorioUsuarios RepositorioUsuarios { get; }
        IRepositorioAdministradores RepositorioAdministradores { get; }
    }
}
