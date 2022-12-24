using System;
using System.IO;
using log4net;


namespace Bitacora
{

    /// <summary>
    /// Resumen: Esta clase nos permite crear y manipular una bitacora del programa donde se registraran las operaciones del programa y los errores que surgan durante la ejecucion del mismo
    /// </summary>
    public class ImplementacionBitacoraConLog4Net : IBitacora//
    {   /// <summary>
        /// establece la direccion relativa del los archivos de la bitacora
        /// </summary>
        private string Path = "Logs";

        /// <summary>
        /// contructor de la clase
        /// </summary>
        public ImplementacionBitacoraConLog4Net()
        {
        }

        /// <summary>
        /// añadir entrada a la bitacora
        /// </summary>
        /// <param name="entradaLog"></param>
        public void RegistrarLog(string entradaLog)
        {
             log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            log.Info(entradaLog);
          
        }

        /// <summary>
        /// metodo que devuelve el nombre para un nuevo archivo de la bitacora
        /// </summary>
        /// <returns>(String) Nombre del Archivo</returns>
        private string ObtenerNombreArchivo()
        {
            string nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";//el formato de nombre del archivo es log_año_mes_dia.txt
            return nombre;//devuelve el nombre del archivo
        }

        /// <summary>
        /// metodo que crea el directorio de la bitacora en el caso de que no exista
        /// </summary>
        private void CrearDirectorio()
        {
            if (!Directory.Exists(Path)) //verifica si existe la ruta de directorio especificada
            {
                Directory.CreateDirectory(Path);//si el directorio no existe lo crea
            }
        }
    }
}
