using System.Collections.Generic;

namespace DAL
{   /// <summary>
/// RESUMEN: Esta interface establece los metodos que debe poseer toda impletementacion de un respositorio
/// </summary>
/// <typeparam name="TEntity"></typeparam>
    public interface IRepositorio<TEntity> where TEntity : class
    {   /// <summary>
        /// RESUMEN:Añade un elemento al respositorio
        /// </summary>
        /// <param name="pEntity"></param>
        void Add(TEntity pEntity);
        /// <summary>
        /// RESUMEN:Elimina un elemento del respositorio
        /// </summary>
        /// <param name="pEntity"></param>
        void Remove(TEntity pEntity);
        /// <summary>
        /// RESUMEN: Nos permite obtener un elemento del repositorio
        /// </summary>
        /// <param name="pId">identificador del elemento</param>
        /// <returns></returns>
        TEntity Get(int pId);
        /// <summary>
        /// RESUMEN: Nos permite obtener un elemento del repositorio
        /// </summary>
        /// <param name="pValor">valor del elemento</param>
        /// <returns></returns>
        TEntity Get(string pValor);
        /// <summary>
        /// RESUMEN: Nos permite obtener todos los elementos del repositorio
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
    }
}
