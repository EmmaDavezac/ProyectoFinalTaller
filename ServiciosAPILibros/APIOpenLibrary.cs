﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;
using Dominio;


namespace ServiciosAPILibros
{
    public class APIOpenLibrary:IServiciosAPILibros
    {
        public string TratarCadenaBusqueda(string ca)
        {

            string[] separado = ca.Split(new char[] { ' ' });
            string c = string.Empty;
            foreach (string palabra in separado)
            {
                if (c.Length > 0)
                    c = c + "+" + palabra;
                else c = c + palabra;
            }
            return c.ToUpper();

        }
        public List<Libro> ListaPorCoincidecia(string cadena)
        {  // Establecimiento del protocolo ssl de transporte
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            List<Libro> lista = new List<Libro>();
            // Url de ejemplo
            var mUrl = "http://openlibrary.org/search.json?q=" + TratarCadenaBusqueda(cadena);
            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

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

                    foreach (var bResponseItem in mResponseJSON.docs)
                    {
                        


                        if (bResponseItem.title != null)
                        {
                             titulo = HttpUtility.HtmlDecode(bResponseItem.title.ToString());
                        }
                        else {  titulo = "desconocido"; }
                            if (bResponseItem.author_name != null)
                            {
                             autor= HttpUtility.HtmlDecode(bResponseItem.author_name.ToString());
                            }
                            else {  autor = "desconocido"; }
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
                        lista.Add(new Libro(isbn,titulo, autor, añoPublicacion));
                    }
                }
                
            }
            catch (WebException ex)
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    String mErrorText = mReader.ReadToEnd();

                    System.Console.WriteLine("Error: {0}", mErrorText);
                }
            }
            return lista;
        }
       
    }
    }
