namespace Bitacora
{
    /// <summary>
    /// Interfaz con procedimientos en comun para bitacoras o logs
    /// </summary>
    public interface IBitacora
    {


        /// <summary>
        /// Añade una entrada a la bitacora
        /// </summary>
        /// <param name="entradaLog"></param>
        void RegistrarLog(string entradaLog);
    }
}
