using System;

namespace DAL
{
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
