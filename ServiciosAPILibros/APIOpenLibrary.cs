using Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using Bitacora;



namespace ServiciosAPILibros
{
    public class APIOpenLibrary : IServicioAPILibros//ESta clase es una implementacion de IServiciosAPILibros con la API De busueda de OpenLibrery
    {
        private string TratarCadenaBusqueda(string ca)//Este metodo transforma la cadena que queremos buscar en el formato solicitado por la api para hacer una consulta(palabra+palabra+...+palabra)
        {

            string[] palabrasSeparadas = ca.Split(new char[] { ' ' });//Toma la cadena de entradas,la separa en subcadenas tomando como separador los espacios y las almacena en el array palabrasSeparadas
            string c = string.Empty;//Creamos una nueva cadena llamada se y le asignamos la cadena vacia
            foreach (string palabra in palabrasSeparadas) //recorremos todas las palabras del array
            {
                if (c.Length > 0)
                    c = c + "+" + palabra;//Si la cadena c no esta vacia concatenamos c con el caracter '+' y luego con la palabra
                else c += palabra;//si la cadena c esta vacia, la concatenamos con la palabra
            }
            return c.ToUpper();//Convertimos la cadena c a mayusculas y la devolvemos como resultado

        }
        public List<Libro> ListarPorCoincidecia(string cadena)//Este metodo nos permite realizar una busqueda en la API de OPenLibrery y obtener como resultado una lista de libros que conincidan con el termino buscado
        {  
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Establecimiento del protocolo ssl de transporte
            List<Libro> lista = new List<Libro>();//Creamos una lista de libro
            string terminoDeBusqueda=TratarCadenaBusqueda(cadena);//Convertimos la cadena al formato necesario para realizar una busqueda solicitado por la API
            var mUrl = "http://openlibrary.org/search.json?q=" +terminoDeBusqueda ;
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);            // Se crea el request http

            Bitacora.Bitacora oLog = new Bitacora.Bitacora();// Instancia del objeto que maneja los logs.
            string msg;//Mensaje a guardar en el log.

            try
            {
                
                // Se ejecuta la consulta
                WebResponse mResponse = mRequest.GetResponse();

                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());



                    // Se iteran cada uno de los resultados.
                    string titulo;
                    string autor;
                    string añoPublicacion;
                    string isbn;

                    foreach (var bResponseItem in mResponseJSON.docs)//Recorremos cada item de la respuesta que nos dio la api
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
                        lista.Add(new Libro(isbn, titulo, autor, añoPublicacion));//creamos una instancia de la clase Libro y lo añadimos a la lista de libros
                    }
                }
                msg = "Listado por coincidencia con la api OpenLibrary a funcionado correctemente.";
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
                msg = "Error al intentar conectarse con la api OpenLibrary. Se intento traer un listado por coincidencia. (termino de busqueda: "+terminoDeBusqueda+" cadena: "+cadena+")" +ex.Message+ex.StackTrace+ ex.Response;
                oLog.RegistrarLog(msg);
            }
            return lista;
        }
        
    }
}
