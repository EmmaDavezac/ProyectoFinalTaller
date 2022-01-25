using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;//Libreria de la capa de acceso a datos,nos permite interactuar con la base de datos, brindandonos control sobre la misma
//using DAL.EntityFramework;//libreria de implementacion de IUnitOfWork con entityFramework
using Dominio;//Liberia que contiene las clases de dominio  
using ServiciosAPILibros;//Libreria que nos permite interactuar con la API de libros, pudiendo hacer consultas y obtener informacion acerca de libros
using NotificacionAUsuario;//Libreria que nos permite notificar a usuarios con prestamos retrasados o proximos a vencer
using Bitacora;//Libreria que nos permite registrar logs en la bitacora

namespace Nucleo
//El nucleo es la libreria que nos permite acceder a todas las funciones del programa
{
    public class FachadaNucleo//Fachada principal del nucleo programa que nos permite usar las funciones del programa sin dar a conocer como funcionan por dentro
    {
        private FachadaDAL interfazDAL = new FachadaDAL();
        //Instancia de la fachada de la libreria DAL
        private FachadaAPILibros interfazAPILibros = new FachadaAPILibros();
        //Instancia de la fachada de la libreria ServiciosAPILibros
        private FachadaNotificarUsuario interfazNotificarUsuario = new FachadaNotificarUsuario();
        //Instancia de la fachada de la libreria NotificacionUsuario

        public FachadaNucleo()//Constructor de la clase
        {
        }
        public bool AñadirUsuario(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono)
        //Permite registrar un nuevo usuario simple, y devuelve el valor true si la operacion es exitosa y false si fue erronea
        {    return interfazDAL.AñadirUsuario(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), fechaNacimiento, mail, telefono);
        }


    public UsuarioSimple ObtenerUsuario(string pNombreUsuario)
    //Nos permite obtener un usuario simple de la base de datos a partir del nombreUsuario del usuario
    {
        return interfazDAL.ObtenerUsuario(pNombreUsuario);
    }

    public void ActualizarUsuario(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
    //Permite actualizar la informacion de un usuario simple
    {
        interfazDAL.ActualizarUsuario(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), pFechaNacimiento, mail, telefono);
    }

    public bool AñadirAdministrador(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono)
    //Permite registrar un nuevo usuario administrador
    {
        return interfazDAL.AñadirAdministrador(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), fechaNacimiento, mail, contraseña, telefono);
    }


    public UsuarioAdministrador ObtenerAdministrador(string pNombreUsuarioOEmail)
    //Nos permite obtener un usuario administrador de la base de datos a partir del nombreUsuario del usuario
    {
        return interfazDAL.ObtenerAdministrador(pNombreUsuarioOEmail);
    }
    public void ActualizarAdministrador(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
    //Permite actualizar la informacion de un usuario administrador
    {
        interfazDAL.ActualizarAdministrador(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), pFechaNacimiento, mail, telefono);
    }
    public void ActualizarContraseñaAdministrador(string nombreUsuario, string contraseña)
    //Permite actualizar la contraseña de un administrador
    {
        interfazDAL.ActualizarContraseñaAdministrador(nombreUsuario, contraseña);
    }

    public void AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion, int pCantidadEjempalares)
    //Permite registrar un nuevo libro
    {
        interfazDAL.AñadirLibro(unISBN, titulo, autor, añoPublicacion, pCantidadEjempalares);
    }
    public Libro ObtenerLibro(int id)
    //Permite obtener un libro de la base de datos a partir del id del mismo 
    {
        return interfazDAL.ObtenerLibro(id);
    }
    public int ObtenerCantidadEjemplaresLibro(int id)
    //devuelve la cantidad total de ejemplares de un libro
    {
        return interfazDAL.ObtenerCantEjemplaresLibro(id);
    }
    public List<Ejemplar> ObtenerEjemplaresEnBuenEstadoLibro(int id)
    //devuelve la lista de ejemplares en buen estado de un libro
    {
        return interfazDAL.ObtenerEjemplaresEnBuenEstadoLibro(id);
    }

    public void AñadirEjemplares(int idLibro, int pCantidad)
    //Permite añadir mas ejemplares a un libro
    {
        interfazDAL.AñadirEjemplares(idLibro, pCantidad);
    }
    public void EliminarEjemplaresDeUnLibro(int idLibro, int pCantidad)
    //Permite disminuir la cantidad de ejemplares de un libro
    {
        interfazDAL.EliminarEjemplaresDeUnLibro(idLibro, pCantidad);
    }
    public void DarDeBajaUnLibro(int pIdLibro)
    //Permite dar de baja un libro
    {
        interfazDAL.DarDeBajaUnLibro(pIdLibro);
    }
    public void DarDeAltaUnLibro(int pIdLibro)
    //Permite dar de alta un libro que ha sido dado de baja 
    {
        interfazDAL.DarDeAltaUnLibro(pIdLibro);
    }
  
   

    public List<Ejemplar> ObtenerEjemplaresDisponibles(int id)
    //Permite obtener la lista de ejemplares disponibles de un libro
    {
        return interfazDAL.ObtenerEjemplaresDisponibles(Convert.ToInt32(id));
    }

    public List<Ejemplar> ObtenerEjemplaresTotales(int id)
    //Permite obtener la lista total de ejemplares  de un libro
    {
        return interfazDAL.ObtenerEjemplaresTotales(id);
    }
   
    public void RegistrarPrestamo(string pNombreUsuario, int idEjemplar, int idLibro)
    //Permite registrar un nuevo prestamo
    {
        interfazDAL.RegistrarPrestamo(pNombreUsuario, idEjemplar, idLibro);
    }
    public Prestamo ObtenerPrestamo(int id)
    //Permite obtener un prestamo de la base de datos a partir del id del prestamo
    {
        return interfazDAL.ObtenerPrestamo(id);
    }

    public void ActualizarLibro(int id, string unISBN, string titulo, string autor, string añoPublicacion)
    //Permite actualizar la informacion de un libro
    {
        interfazDAL.ActualizarLibro(id, unISBN, titulo, autor, añoPublicacion);
    }

    public UsuarioSimple ObtenerUsuarioDePrestamo(int id)
    //Permite obtener el usuario de un prestamo a patir del id del prestamo
    {
        return interfazDAL.ObtenerUsuarioDePrestamo(id);
    }

    public void RegistrarDevolucion(int idPrestamo, string estado)
    //Permite registrar la devolucion de un prestamo
    {
        interfazDAL.RegistrarDevolucion(idPrestamo, estado);
    }

    public void ModificarFechasPrestamo(int pIdPrestamo, string pFechaPrestamo, string pFechaLimite)
    //permite modificar las fechas de realizacion y limite de un prestamo(funcion solo para versiones de prueba)
    {
        interfazDAL.ModificarFechasPrestamo(pIdPrestamo, pFechaPrestamo, pFechaLimite);
    }
  
    

    public bool VerficarContraseña(string pNombreUsuario, string contraseña)
    //permite verificar que la combinacion NombreUsuario-Contraseña sea correcta
    {
        return interfazDAL.VerficarContraseña(pNombreUsuario, contraseña);
    }
    public IEnumerable<UsuarioSimple> ObtenerUsuarios()
    //permite obtener la lista total de usuarios simples
    { return interfazDAL.ObtenerUsuarios(); }

    public IEnumerable<UsuarioAdministrador> ObtenerAdministradores()
    //permite obtener la lista total de usuarios adminitradores
    { return interfazDAL.ObtenerAdministradores(); }

    public IEnumerable<Libro> ObtenerLibros()
    //permite obtener la lista total de libros
    { return interfazDAL.ObtenerLibros(); }

    

    public IEnumerable<Prestamo> ObtenerPrestamos()
    //permite obtener la lista total de prestamos
    { return interfazDAL.ObtenerPrestamos(); }

    public int ObtenerUltimoIdLibro()
    //devuelve el id del ultimo plibro registrado
    { return ObtenerLibros().Last().Id; }

    

    public int ObtenerUltimoIdPrestamo()
    //devuelve el id del ultimo prestamo registrado
    { return ObtenerPrestamos().Last().Id; }

    public List<Prestamo> ObtenerListadePrestamosProximosAVencerse()
    //Devuelve la lista de prestamos proximos a vencer
    {
        return interfazDAL.ObtenerListadePrestamosProximosAVencerse();
    }

    public List<Prestamo> ObtenerListadePrestamosRetrasados()
    //Devuelve la lista de prestamos retasados
    {
        return interfazDAL.ObtenerListadePrestamosRetrasados();
    }

    public List<Libro> ListarLibrosDeAPIPorCoincidencia(string unaCadena)//realiza un busqueda en la api de libros y devuelve una lista de libros
    { return interfazAPILibros.ListarLibrosDeAPIPorCoincidencia(unaCadena); }

   
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

        private void NotificarProximoAVencer(string pNombreUsuario)//notifica a un usuario que su prestamo esta proximo a vencer
    {
        RegistrarLog(interfazNotificarUsuario.NotificarProximoAVencer(ObtenerUsuario(pNombreUsuario)));
    }
    private void NotificarRetraso(string pNombreUsuario)//notifica a un usuario que su prestamo esta retrasado
    {
        RegistrarLog(interfazNotificarUsuario.NotificarRetraso(ObtenerUsuario(pNombreUsuario)));
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
    public void NotificarPrestamosProximosAVencer()//notifica a todos los usuarios con prestamos proximos a vencer
    {
        foreach (var item in ObtenerListadePrestamosProximosAVencerse())
        {
            UsuarioSimple usuario = ObtenerUsuarioDePrestamo(item.Id);
            NotificarProximoAVencer(usuario.NombreUsuario);
        }
    }

    private void NotificarPrestamosRetrasados()//notifica a todos los usuarios con prestamos retrasados
    {
        foreach (var item in ObtenerListadePrestamosRetrasados())
        {
            UsuarioSimple usuario = ObtenerUsuarioDePrestamo(item.Id);
            NotificarRetraso(usuario.NombreUsuario);
        }
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

    public void NotificarUsuarios()
    //notifica a todos los usuarios con prestamos retrasados o proximos a vencer en el caso de que la hora este entre las 9 y 10 am
    {
        if (DateTime.Now.Hour == 9)
        {
            NotificarPrestamosRetrasados();
            NotificarPrestamosProximosAVencer();
        }
    }

    public void RegistrarLog(string sLog)//Permite registrar un nuevo log en la bitacora
    {

        FachadaBitacora oLog = new FachadaBitacora();//abrimos o creamos el archivo en caso de no existir
        oLog.Add(sLog);//añadimos el log en la bitacora

    }

    public bool DarDeBajaUsuario(string pNombreUsuario)
    //pemite dar de baja un usuario simple
    {
        return interfazDAL.DarDeBajaUsuario(pNombreUsuario);
    }

    public bool DarDeBajaAdministrador(string pNombreUsuario)
    //Permite dar de baja un usuario administrador
    {
        return interfazDAL.DarDeBajaAdministrador(pNombreUsuario);
    }

    public void DarDeAltaUsuario(string pNombreUsuario)
    //Permite dar de alta un usuario simple dado de baja
    {
        interfazDAL.DarDeAltaUsuario(pNombreUsuario);
    }

    public void DarDeAltaAdministrador(string pNombreUsuario)
    //Permite dar de alta un administrador dado de baja
    {
        interfazDAL.DarDeAltaAdministrador(pNombreUsuario);
    }
}
}