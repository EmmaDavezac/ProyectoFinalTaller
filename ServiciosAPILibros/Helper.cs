using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosAPILibros
{
    internal static class Helper
    {
        /// <summary>
        /// Resumen: Transforma la cadena que queremos buscar en el formato requerido por la API Open Library para hacer una consulta.Ejemplo : palabra1 palabra2 ... palabraN -> palabra1+palabra2+...+palabraN
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Devuelve la cadena en el formato requerido por la API Open Library</returns>
        public static string TratarCadenaBusqueda(string cadena)
        {
            string[] palabrasSeparadas = cadena.Split(new char[] { ' ' });//Toma la cadena de entradas,la separa en subcadenas tomando como separador los espacios y las almacena en el array palabrasSeparadas
            string c = string.Empty;//Creamos una nueva cadena llamada se y le asignamos el valor de la cadena vacia
            foreach (string palabra in palabrasSeparadas) //recorremos todas las palabras del array
            {
                if (c.Length > 0)
                    c = c + "+" + palabra;//Si la cadena c no esta vacia concatenamos c con el caracter '+' y luego con la palabra
                else c += palabra;//si la cadena c esta vacia, la concatenamos con la palabra
            }
            return c.ToUpper();//Convertimos la cadena c a mayusculas y la devolvemos como resultado
        }
    }
}
