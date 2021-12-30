using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosAPILibros
{
    public class InterfazAPILibros
    {
        static string[] implementacionesAPILibros = new string[] { "OpenLibrary" };
        static private string implementacionAPILibros = implementacionesAPILibros[0];
        public IServiciosAPILibros GetIServiciosAPILibros(string unIServiciosAPILibros)///Implementacion posibles para la api que nos brinda informacion sobre libros, interactua con la interfaz IAPIlibros, esta abtraccion nos permite poder trabajar con distintas implementaciones
        {
            switch (unIServiciosAPILibros)
            {
                case "APIOpenLibrary": { return new APIOpenLibrary(); }//implementacion con OpenLibrary
                default:
                    { return new APIOpenLibrary(); }//implementacion por defecto, implemetacion con OpenLibrery

            }
        }
        public List<Libro> ListarLibrosDeAPIPorCoincidencia(string unaCadena)
        { return GetIServiciosAPILibros(implementacionAPILibros).ListaPorCoincidecia(unaCadena); }

    }
}
