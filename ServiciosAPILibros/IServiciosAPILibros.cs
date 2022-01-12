using Dominio;
using System.Collections.Generic;

namespace ServiciosAPILibros
{
    public interface IServiciosAPILibros//Interface que nos permite buscar informacion sobre libros en una API de libros
    {
        List<Libro> ListaPorCoincidecia(string cadena);//Metodo que nos permite obtener una lista de libros que coinciden con el termino buscado
        
    }
}
