using System.Collections.Generic;
using System.Linq;

namespace UtilidadesPresentacion
{   /// <summary>
/// Resumen:esta clase posee un conjunto de metodos que brindan soporte a los formularios de la presentacion
/// </summary>
    public class BibliotecaUtilidadesPresentacion
    {   /// <summary>
        /// Resumen: Constructor de la clase
        /// </summary>
        public BibliotecaUtilidadesPresentacion()
        {
        }
        /// <summary>
        /// Resumen: Transforma el campo isbns de un libro ofrecido por la api de libros en una lista de isbn
        /// </summary>
        /// <param name="pLista"></param>
        /// <returns></returns>
        public List<string> TransformarISBNsALista(string pLista)
        {
            string palabra = "";
            int contador = 0;
            List<string> resultadoIntermedio = new List<string>();
            List<string> resultado = new List<string>();
            for (int i = 0; i < pLista.Length; i++)
            {
                if (pLista.Substring(i, 1) == "[" || pLista.Substring(i, 1) == "," || pLista.Substring(i, 1) == "]")
                {
                }
                if (pLista.Substring(i, 1) == '"'.ToString())
                {
                    contador = 1;
                }
                if (pLista.Substring(i, 1) == '"'.ToString() && contador == 1)
                {
                    contador = 0;
                    resultadoIntermedio.Add(palabra);
                    palabra = "";
                }
                else
                {
                    palabra = palabra + pLista.Substring(i, 1);
                }
            }
            for (int i = 1; i < resultadoIntermedio.Count; i += 2)
            {
                resultado.Add(resultadoIntermedio[i]);
            }
            HashSet<string> hashWithoutDuplicates = new HashSet<string>(resultado);
            List<string> listWithoutDuplicates = hashWithoutDuplicates.ToList();
            return listWithoutDuplicates;
        }

        /// <summary>
        /// Resumen: Devuelve el autor de un libro, a partir de la lista de autores de un libro ofrecido por la api de libros
        /// </summary>
        /// <param name="pLista"></param>
        /// <returns>(String) Autor del libro</returns>
        public string SacarAutorDeLaLista(string pLista)

        {
            if (pLista == "desconocido" || pLista == "Unknown")
            {
                return "Desconocido";
            }
            else
            {
                return TransformarISBNsALista(pLista).First();
            }
        }

        /// <summary>
        /// Resumen: Transforma el campo años de publicacion de un libro ofrecido por la api de libros en una lista de años
        /// </summary>
        /// <param name="pLista"></param>
        /// <returns> List String </returns>
        public List<string> TransformarAñosALista(string pLista)
        {
            string palabra = "";
            pLista = pLista.Remove(0, 1);
            List<string> resultado = new List<string>();
            for (int i = 0; i < pLista.Length; i++)
            {
                if (pLista.Substring(i, 1) == ','.ToString() || pLista.Substring(i, 1) == "]")
                {
                    resultado.Add(palabra.Remove(1, 3));
                    palabra = "";
                }
                else
                {
                    palabra = palabra + pLista.Substring(i, 1);
                }
            }
            HashSet<string> hashWithoutDuplicates = new HashSet<string>(resultado);
            List<string> listWithoutDuplicates = hashWithoutDuplicates.ToList();
            return listWithoutDuplicates.OrderBy(x => x).ToList();
        }

        /// <summary>
        /// Resumen:indica si una cadena tiene el formato de mail valido
        /// </summary>
        /// <param name="email"></param>
        /// <returns>True si la cadena tiene el formato de mail valido y False en caso contrario </returns>
        public bool EsUnEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
}
