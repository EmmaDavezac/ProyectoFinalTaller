using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.EntityFramework
{   /// <summary>
/// RESUMEN:Clase abastracta que implementa IRespositorio
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TDbContext"></typeparam>
    public abstract class Repositorio<TEntity, TDbContext> : IRepositorio<TEntity> where TEntity : class
                                                                                    where TDbContext : DbContext
    {
        /// <summary>
        /// RESUMEN:Atributo de solo lectura que alamcena el contexto de la base de datos
        /// </summary>
        protected readonly TDbContext iDbContext;
        /// <summary>
        /// RESUMEN:Constructor de la clase
        /// </summary>
        /// <param name="pDbContext"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Repositorio(TDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }

            this.iDbContext = pDbContext;
        }
        /// <summary>
        /// RESUMEN:Metodo para añadir un elemento a la base de datos
        /// </summary>
        /// <param name="pEntity"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }
            this.iDbContext.Set<TEntity>().Add(pEntity);
        }
        /// <summary>
        /// RESUMEN:Metodo para obtener  un elemento del repositorio con el identificador
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }
        /// <summary>
        /// /// RESUMEN:Metodo para obtener  un elemento del repositorio con el valor del elemento
        /// </summary>
        /// <param name="pValor"></param>
        /// <returns></returns>
        public TEntity Get(string pValor)
        {
            return this.iDbContext.Set<TEntity>().Find(pValor);
        }
        /// <summary>
        /// RESUMEN: metodo para obtener todos los elementos del repositorio
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>();
        }
        /// <summary>
        /// RESUMEN:metodo para eliminar un elemento del repositorio
        /// </summary>
        /// <param name="pEntity"></param>
        /// <exception cref="ArgumentNullException"></exception>
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
