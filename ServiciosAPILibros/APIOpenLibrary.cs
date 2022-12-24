using Bitacora;
using Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace ServiciosAPILibros

{   /// <summary>
    /// Resumen: Esta clase nos permite realizar consultas a la base de datos de Open Library, es una implementacion de la interfaz IServiciosAPILibros con la API De busqueda de OpenLibrery
    /// </summary>
    public class APIOpenLibrary : IServicioAPILibros//
    {   /// <summary>
    /// Resumen: Nos permite realizar una consulta a la API Open Library y nos devuelve el resultado de la consulta contenido en un objeto Dinamico
    /// </summary>
    /// <param name="cadena"></param>
    /// <returns>Objeto dinamico con el resultado de la consulta</returns>
        public dynamic ConsultaAPI(string cadena)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Establecimiento del protocolo ssl de transporte
            string terminoDeBusqueda = Helper.TratarCadenaBusqueda(cadena);//Convertimos la cadena al formato necesario para realizar una busqueda solicitado por la API
            var mUrl = "http://openlibrary.org/search.json?q=" + terminoDeBusqueda;
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);// Se crea el request http
            string msg;//Mensaje a guardar en el log.
            IBitacora oLog = new ImplementacionBitacoraConLog4Net();// Instancia del objeto que maneja los logs.
            dynamic mResponseJSON = null; //Objeto dinamico que contendra el resultado
            try
            {
                // Se ejecuta la consulta
                WebResponse mResponse = mRequest.GetResponse();
                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                    mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());


                }
                msg = "Consulta a la API OpenLibrary exitosa";
                oLog.RegistrarLog(msg);//Registramos la operacion en la bitacora

            }
            catch (WebException ex)//Manejamos la excepcion
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    String mErrorText = mReader.ReadToEnd();
                    System.Console.WriteLine("Error: {0}", mErrorText);
                }
                msg = "ERROR al intentar hacer una consulta a la api OpenLibrary. Se intento traer un listado por coincidencia. (termino de busqueda: " + terminoDeBusqueda + " cadena: " + cadena + ")" + ex.Message + ex.StackTrace + ex.Response;
                oLog.RegistrarLog(msg);
            }
            return mResponseJSON;
        }

        /// <summary>
        /// Resumen: Procesa una consulta realizada a la APi, convirtiendo el objeto dinamico resultante de la busqueda en un Listado de Libros
        /// </summary>
        /// <param name="dinamico"></param>
        /// <returns>Listado de Libros</returns>
        public List<Libro> ProcesarConsulta(dynamic dinamico)
        {
            IBitacora oLog = new ImplementacionBitacoraConLog4Net();// Instancia del objeto que maneja los logs.
            string msg;//Mensaje a guardar en el log.
            List<Libro> lista = new List<Libro>();
            try
            {

                // Se iteran cada uno de los resultados.
                string titulo;
                string autor;
                string añoPublicacion;
                string isbn;
                List<Libro> listaAuxiliar = new List<Libro>();
                foreach (var bResponseItem in dinamico.docs)//Recorremos cada item de la respuesta que nos dio la api
                {

                    //Convertimos el objeto que obtenemos como respuesta por parte de la api y lo convertimos en una lista de libros
                    if (bResponseItem.title != null)//si el item posee el atributo title leemos el atributo, lo convertimos en una cadena y lo asignamoa a la variable titulo
                    {
                        titulo = HttpUtility.HtmlDecode(bResponseItem.title.ToString());
                    }
                    else { titulo = "desconocido"; }//si no posee el atributo le asignamos a la variable titulo "desconocido"
                    if (bResponseItem.author_name != null)
                    {
                        autor = HttpUtility.HtmlDecode(bResponseItem.author_name.ToString());
                    }
                    else { autor = "desconocido"; }
                    if (bResponseItem.publish_year != null)
                    {
                        añoPublicacion = HttpUtility.HtmlDecode(bResponseItem.publish_year.ToString());
                    }
                    else { añoPublicacion = "desconocido"; }

                    if (bResponseItem.isbn != null)
                    {
                        isbn = HttpUtility.HtmlDecode(bResponseItem.isbn.ToString());
                    }
                    else { isbn = "desconocido"; }
                    listaAuxiliar.Add(new Libro(isbn, titulo, autor, añoPublicacion));//creamos una instancia de la clase Libro y lo añadimos a la lista de libros
                }
                lista = listaAuxiliar;
                msg = "Procesado de la consulta a OpenLibrary Exito.";
                oLog.RegistrarLog(msg);//Registramos la operacion en la bitacora
            }

            catch (Exception ex)//Manejamos la excepcion
            {
                msg = "Error al intentar procesar la consulta a OpenLibrary. " + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);
            }
            return lista;
        }

        /// <summary>
        /// Resumen: Permite realizar una busqueda en la API de OPenLibrery y obtener como resultado una lista de libros que conincidan con el termino buscado
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Una lista de libros</returns>
        public List<Libro> ConsultarlistadoDeLibros(string cadena)
        { dynamic respuestaConsulta=ConsultaAPI(cadena);
            List<Libro> listadoDeLibros = this.ProcesarConsulta(respuestaConsulta);
            return listadoDeLibros;
        }

       

    }
}
