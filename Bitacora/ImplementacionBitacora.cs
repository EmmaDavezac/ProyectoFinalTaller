using System;
using System.IO;

namespace Bitacora
{

    /// <summary>
    /// Resumen: Esta clase nos permite crear y manipular una bitacora del programa donde se registraran las operaciones del programa y los errores que surgan durante la ejecucion del mismo
    /// </summary>
    public class ImplementacionBitacora : IBitacora//
    {   /// <summary>
        /// establece la direccion relativa del los archivos de la bitacora
        /// </summary>
        private string Path = "Logs";

        /// <summary>
        /// contructor de la clase
        /// </summary>
        public ImplementacionBitacora()
        {
        }

        /// <summary>
        /// añadir entrada a la bitacora
        /// </summary>
        /// <param name="entradaLog"></param>
        public void RegistrarLog(string entradaLog)
        {
            CrearDirectorio();//crea un directorio en el caso de que no exista
            string nombre = ObtenerNombreArchivo();//obtiene el nombre del archivo
            string cadena = "" + DateTime.Now + " - " + entradaLog + Environment.NewLine;//el texto que se va a escribir en la entrada
            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);//establece una transmision para escribir el archivo
            sw.Write(cadena);//escribe la entrada en el archivo
            sw.Close();//cierra el archivo
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
