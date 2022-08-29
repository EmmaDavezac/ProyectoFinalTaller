using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.EntityFramework
{
    public abstract class Repositorio<TEntity, TDbContext> : IRepositorio<TEntity>  where TEntity : class
                                                                                    where TDbContext : DbContext
    {

        protected readonly TDbContext iDbContext;

        public Repositorio(TDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }

            this.iDbContext = pDbContext;
        }

        public void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }
            this.iDbContext.Set<TEntity>().Add(pEntity);
        }

        public TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }

        public TEntity Get(string pValor)
        {
            return this.iDbContext.Set<TEntity>().Find(pValor);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>();
        }

        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Remove(pEntity);
        }
    }
}
