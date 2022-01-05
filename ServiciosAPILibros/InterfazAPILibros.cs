using Dominio;
using System.Collections.Generic;

namespace ServiciosAPILibros
{
    public class InterfazAPILibros//Fachada de la libreria
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
