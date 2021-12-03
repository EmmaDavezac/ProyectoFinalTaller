using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace ServiciosAPILibros
{
    public  interface IServiciosAPILibros
    {
         List<Libro> ListaPorCoincidecia(string cadena);
        void BuscarPorISBN(string isbn);//hay que corregirlo en APIOpenLibrary
    }
}
