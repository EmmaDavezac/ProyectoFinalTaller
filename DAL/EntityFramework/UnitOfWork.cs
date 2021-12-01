using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AdministradorDePrestamosDbContext iDbContext;

        private bool iDisposedValue = false;

        public UnitOfWork(AdministradorDePrestamosDbContext pDbContext)
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

        public IRepositorioUsuarios RepositorioUsuarios { get; private set; }

        public IRepositorioLibros RepositorioLibros { get; private set; }
        public IRepositorioPrestamos RepositorioPrestamos { get; private set; }
        public IRepositorioEjemplares RepositorioEjemplares { get; private set; }
        public IRepositorioAdministradores RepositorioAdministradores { get; private set; }

        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

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

        public void Dispose()
        {
            this.Dispose(true);
        }
    }
    }
