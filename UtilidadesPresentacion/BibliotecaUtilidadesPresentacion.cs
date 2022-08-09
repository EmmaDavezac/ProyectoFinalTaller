using System.Collections.Generic;
using System.Linq;


namespace UtilidadesPresentacion
{
    public class BibliotecaUtilidadesPresentacion
    {
        public BibliotecaUtilidadesPresentacion()
        {
        }

        public List<string> TransformarISBNsALista(string pLista)//Transforma el campo isbns de un libro ofrecido por la api de libros en una lista de isbn
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

        public string SacarAutorDeLaLista(string pLista)
        //devuelve el autor de un libro, a partir de la lista de autores de un libro ofrecido por la api de libros
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

        public List<string> TransformarAñosALista(string pLista)//Transforma el campo años de publicacion de un libro ofrecido por la api de libros en una lista de años
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

        public bool EsUnEmailValido(string email)//indica si una cadena tiene el formato de mail valido
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

        public string MayusculaPrimeraLetra(string source)//transforma en mayuscula la primer letra de la cadena
        {
            if (string.IsNullOrEmpty(source))
            { return string.Empty; }
            else
            {
                char[] letters = source.ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                return new string(letters);
            }
        }
    }
}
