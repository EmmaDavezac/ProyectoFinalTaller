using System;

namespace DAL.EntityFramework
{   /// <summary>
/// RESUMEN: esta clase es la encargada de manejar las transacciones con la base de datos.
/// </summary>
    public class UnitOfWorkMSSQL : IUnitOfWork
    {   /// <summary>
        /// RESUMEN: Contexto de la base de datos
        /// </summary>
        private readonly AdministradorDePrestamosDbContext iDbContext;
        /// <summary>
        /// RESUMEN:indica si se elimino la conexion con la base de datos
        /// </summary>
        private bool iDisposedValue = false;
        /// <summary>
        /// RESUMEN:Contructor de la clase
        /// </summary>
        /// <param name="pDbContext"></param>
        /// <exception cref="NotImplementedException"></exception>
        public UnitOfWorkMSSQL(AdministradorDePrestamosDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new NotImplementedException();
            }

            this.iDbContext = pDbContext;
            this.RepositorioUsuarios = new RepositorioUsuarios(pDbContext);
            this.RepositorioLibros = new RepositorioLibros(pDbContext);
            this.RepositorioPrestamos = new RepositorioPrestamos(pDbContext);
            this.RepositorioEjemplares = new RepositorioEjemplares(pDbContext);
            this.RepositorioAdministradores = new RepositorioAdministradores(pDbContext);
        }
        /// <summary>
        /// RESUMEN:Repositorio de Usuarios
        /// </summary>
        public IRepositorioUsuarios RepositorioUsuarios { get; private set; }
        /// <summary>
        /// RESUMEN:Repositorio de Libros
        /// </summary>
        public IRepositorioLibros RepositorioLibros { get; private set; }
        /// <summary>
        /// RESUMEN:Repositorio de Prestamos
        /// </summary>
        public IRepositorioPrestamos RepositorioPrestamos { get; private set; }
        /// <summary>
        /// RESUMEN:Repositorio de Ejemplares
        /// </summary>
        public IRepositorioEjemplares RepositorioEjemplares { get; private set; }
        /// <summary>
        /// RESUMEN:Repositorio de Administradores
        /// </summary>
        public IRepositorioAdministradores RepositorioAdministradores { get; private set; }

        /// <summary>
        /// RESUMEN:Cuando temine la transaccion se guardan los datos
        /// </summary>
        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }
        /// <summary>
        /// RESUMEN:Cambia el valor de iDisposedValue
        /// </summary>
        /// <param name="pDisposing"></param>
        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposedValue)
            {
                if (pDisposing)
                {
                    this.iDbContext.Dispose();
                }

                this.iDisposedValue = true;
            }
        }
        /// <summary>
        /// RESUMEN:Elimina la conexion con la base de datos
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }
    }
}
