using System;
using System.IO;

namespace Bitacora
{
    public class Bitacora:IBitacora//esta clase nos permite crear y manipular una bitacora del programa donde se registraran las operaciones del programa y los errores que surgan durante la ejecucion del mismo
    {
        private string Path = "Logs";//establece la direccion relativa del los archivos de la bitacora


        public Bitacora()//contructor de la clase
        {

        }

        public void RegistrarLog(string sLog)//añadir entrada a la bitacora
        {
            CrearDirectorio();//crea un directorio en el caso de que no exista
            string nombre = ObtenerNombreArchivo();//obtiene el nombre del archivo
            string cadena =""+ DateTime.Now + " - " + sLog + Environment.NewLine;//el texto que se va a escribir en la entrada

            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);//establece una transmision para escribir el archivo
            sw.Write(cadena);//escribe la entrada en el archivo
            sw.Close();//cierra el archivo

        }


        private string ObtenerNombreArchivo()//metodo que devuelve el nombre para un nuevo archivo de la bitacora
        {
           

            string nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";//el formato de nombre del archivo es log_año_mes_dia.txt

            return nombre;//devuelve el nombre del archivo
        }

        private void CrearDirectorio()//metodo que crea el directorio de la bitacora en el caso de que no exista
        {
            try
            {
                if (!Directory.Exists(Path)) //verifica si existe la ruta de directorio especificada
                    Directory.CreateDirectory(Path);//si el directorio no existe lo crea
            }
            catch (DirectoryNotFoundException ex) //en el caso de ocurrir un error captura la excepcion
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
