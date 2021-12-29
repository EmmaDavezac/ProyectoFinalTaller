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
        
    }
}
