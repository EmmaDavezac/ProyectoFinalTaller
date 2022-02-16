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
using DAL.EntityFramework;

namespace Nucleo
//El nucleo es la libreria que nos permite acceder a todas las funciones del programa
{
    public class FachadaNucleo//Fachada principal del nucleo programa que nos permite usar las funciones del programa sin dar a conocer como funcionan por dentro
    {
        //Instancia de la fachada de la libreria DAL
        private FachadaAPILibros interfazAPILibros = new FachadaAPILibros();
        //Instancia de la fachada de la libreria ServiciosAPILibros
        private FachadaNotificarUsuario interfazNotificarUsuario = new FachadaNotificarUsuario();
        //Instancia de la fachada de la libreria NotificacionUsuario
        static private string[] implementacionesBase = new string[] { "ConnectionSQLServerLocal", "ConnectionSQLServerHosting" };//Distintas implementaciones para la base de datos, en este caso ambas son base de datos de MSSQL, una en una base de datos local y otra en internet
        static private string implementacionBase = implementacionesBase[1];
        private IUnitOfWork GetUnitOfWork()//implementaciones posibles para las base de datos, interactua con la interfaz IUnitOfWork, esta abtraccion nos permite poder trabajar con distintas implementaciones
        {
            switch (implementacionBase)
            {
                case "ConnectionSQLServerHosting": { return new UnitOfWork(new AdministradorDePrestamosDbContext(implementacionBase)); }//implementacion en una base de datos relacional de SQLServer con hosting en un servidor proporcionado por  la web https://www.smarterasp.net/
                case "ConnectionSQLServerLocal": { return new UnitOfWork(new AdministradorDePrestamosDbContext(implementacionBase)); }//implementacion en una base de datos relacional de SQLServer en un servidor local de MSQLSERVER
                default: { return new UnitOfWork(new AdministradorDePrestamosDbContext("ConnectionSQLServerLocal")); }//implementacion por defecto,implementacion en una base de datos relacional de SQLServer en un servidor local de MSQLSERVER
            }
        }
        public FachadaNucleo()//Constructor de la clase
        {
        }
        public bool AñadirUsuario(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono)
        //Permite registrar un nuevo usuario simple, y devuelve el valor true si la operacion es exitosa y false si fue erronea
        {
            UsuarioSimple usuario = new UsuarioSimple(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario);//Instanciamos un usuario con los datos pasados por parametro
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            try
            {
                msg = "Usuario " + pNombreUsuario + " Registrado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioUsuarios.Add(usuario);//Añado el usuario a la base de datos
                    unitOfWork.Complete();//Guardamos los cambios
                }
                oLog.Add(msg);//Añadimos el mensaje al log
                return true;
            }
            catch (Exception ex)
            {
                msg = "Error al registrar usuario (" + nombre + "-" + apellido + ")" + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
                return false;
            }

        }


        public UsuarioSimple ObtenerUsuario(string pNombreUsuario)
    //Nos permite obtener un usuario simple de la base de datos a partir del nombreUsuario del usuario
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {

                UsuarioSimple usuario;//Creamos una variable de tipo usuario que sera devuelta por el metodo
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    usuario = unitOfWork.RepositorioUsuarios.Get(pNombreUsuario);//Asignamos al usuario el valor obtenido por el get a la base de datos
                }

                return usuario;//Devolvemos el usuario

            }
            catch (Exception ex)
            {

                msg = "Error al obtener el usuario (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
                return null;//Devolvemos el usuario
            }
        }

    public void ActualizarUsuario(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
    //Permite actualizar la informacion de un usuario simple
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Usuario " + pNombreUsuario + " Actualizado con exito.";

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Nombre = nombre;//Modificamos uno por uno los valores por los parametros pasados
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Apellido = apellido;
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).FechaNacimiento = Convert.ToDateTime(pFechaNacimiento);
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Mail = mail;
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Telefono = telefono;
                    unitOfWork.Complete();//Guardamos los cambios
                }
                oLog.Add(msg);//Añadimos el mensaje al log
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el usuario (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log

            }
    }

    public bool AñadirAdministrador(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono)
    //Permite registrar un nuevo usuario administrador
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            UsuarioAdministrador usuario = new UsuarioAdministrador(nombre, apellido, fechaNacimiento, mail, contraseña, telefono, pNombreUsuario);//Instanciamos un administrador con los datos pasados por parametro
            try
            {
                msg = "Administrador " + pNombreUsuario + " registrado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Add(usuario);//Añadimos el administrador a la base de datos
                    unitOfWork.Complete();//Guardamos los cambios
                }
                oLog.Add(msg);//Añadimos el mensaje al log
                return true;//Indicamos con true que se pudo añadir correctamente
            }
            catch (Exception ex)
            {
                msg = "Error al Registrar el administrador (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
                return false;//Indicamos con false que no se pudo añadir correctamente

            }
    }


    public UsuarioAdministrador ObtenerAdministrador(string pNombreAdministrador)
    //Nos permite obtener un usuario administrador de la base de datos a partir del nombreUsuario del usuario
    {
            UsuarioAdministrador administrador = new UsuarioAdministrador();//Instanciamos un administrador para que luego sea devuelto como resultado
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    administrador = unitOfWork.RepositorioAdministradores.Get(pNombreAdministrador);//Asignamos a la variable administrado instanciada el valor que nos devuelve el get.
                }

            }
            catch (Exception ex)
            {
                msg = "Error al obtener el administrador (" + pNombreAdministrador + " ) " + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log

            }

            return administrador;//Devolvemos el administrador
        }
    public void ActualizarAdministrador(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
    //Permite actualizar la informacion de un usuario administrador
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Administrador " + pNombreUsuario + " actualizado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Nombre = nombre;//Modificamos uno por uno los valores por los parametros pasados
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Apellido = apellido;
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).FechaNacimiento = Convert.ToDateTime(pFechaNacimiento);
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Mail = mail;
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Telefono = telefono;
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el administrador (" + pNombreUsuario + " ) " + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);//Añadimos el mensaje al log
    }
    public void ActualizarContraseñaAdministrador(string pNombreAdministrador, string contraseña)
    //Permite actualizar la contraseña de un administrador
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Contraseña del administrador " + pNombreAdministrador + " actualizada con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreAdministrador).Pass = contraseña;//Modificamos la contraseña actual por la que pasamos como parametro
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar la contraseña del administrador (" + pNombreAdministrador + " ) " + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);//Añadimos el mensaje al log
        }

    public bool AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion, int pCantidadEjempalares)
    //Permite registrar un nuevo libro
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            bool resultado = true;
            try
            {
                msg = "Libro ( Titulo: " + titulo + " Autor: " + autor + " ISBN:" + unISBN + " ) registrado con exito.";
                Libro libro = new Libro(unISBN, titulo, autor, añoPublicacion);//Instanciamos un libro con los parametros pasados al metodo.
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    foreach (var item in unitOfWork.RepositorioLibros.GetAllISBN())
                    {
                        if (item == unISBN)
                        {
                            resultado = false;
                            break;
                        }
                    }
                    if (resultado == true)
                    {
                        foreach (var item in unitOfWork.RepositorioLibros.GetAllTitulo())
                        {
                            if (item == titulo)
                            {
                                resultado = false;
                                break;
                            }
                        }
                    }
                    if (resultado == true)
                    {
                        unitOfWork.RepositorioLibros.Add(libro);//Añadimos el libro a la base de datos
                        for (int i = 0; i < pCantidadEjempalares; i++)//Añadimos la cantidad de ejemplares pasado como parametro al libro con un ciclo for.
                        {
                            Ejemplar ejemplarNuevo = new Ejemplar(libro);//Instanciamos el nuevo ejemplar y le pasamos el objeto libro como parametro.
                            unitOfWork.RepositorioEjemplares.Add(ejemplarNuevo);//Añadimos el ejemplar a la base de datos.
                        }
                        unitOfWork.Complete();//Guardamos los cambios
                    }
                }

            }
            catch (Exception ex)
            {

                msg = "Error al registrar el libro ( Titulo: " + titulo + " Autor: " + autor + " ISBN:" + unISBN + " ) ." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return resultado;
    }
    public Libro ObtenerLibro(int id)
    //Permite obtener un libro de la base de datos a partir del id del mismo 
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            Libro libro = new Libro();//Instanciamos un libro que sera devuelto por el metodo
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    libro = unitOfWork.RepositorioLibros.Get(id);//Obtenemos el libro a travez del metodo get con la id pasada por parametro y se lo asignamos a la variable creada.
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener el libro (Id: " + id + " ) ." + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log

            }

            return libro;//Devolvemos el libro
        }
    public int ObtenerCantidadEjemplaresLibro(int id)
    //devuelve la cantidad total de ejemplares de un libro
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            int cant = 0;//Entero que nos permitira almacenar la cantidad de ejemplares
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    cant = unitOfWork.RepositorioLibros.Get(id).Ejemplares.Count();//Le asignamos a la variable cant lo que devuele el metodo count sobre la lista de ejemplares del libro.
                }
            }
            catch (Exception ex)
            {

                msg = "Error al obtener la cantidad de ejemplares del libro (Id: " + id + " ) ." + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

            return cant;//Devolvemos la cantidad
        }
    public List<Ejemplar> ObtenerEjemplaresEnBuenEstadoLibro(int id)
    //devuelve la lista de ejemplares en buen estado de un libro
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Ejemplar> lista = new List<Ejemplar>(); //Creamos un listado que contenga objetos del tipo Ejemplar para ser devuelto por el metodo
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresEnBuenEstado();//Asignamos a la lista creada, la lista que nos devuelve el metodo que EjemplaresEnBuenEstado que posee el libro, cuya id es id.
                }


            }
            catch (Exception ex)
            {
                msg = "Error al obtener lista de ejemplares en buen estado del libro (id libro: " + id + ")" + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log

            }

            return lista;//Devolvemos la lista
    }

    public void AñadirEjemplares(int pIdLibro, int pCantidad)
    //Permite añadir mas ejemplares a un libro
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = ("Ejemplares Añadidos a libro con exito (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ").");
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    for (int i = 1; i <= pCantidad; i++)//Añadimos la cantidad de ejemplares pasado como parametro al libro con un ciclo for.
                    {
                        Ejemplar ejemplar = new Ejemplar(unitOfWork.RepositorioLibros.Get(pIdLibro));//Instanciamos el nuevo ejemplar y le pasamos el objeto libro como parametro.
                        unitOfWork.RepositorioEjemplares.Add(ejemplar);//Añadimos el ejemplar a la base de datos.
                    }
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }

            catch (Exception ex)
            {
                msg = "Error al Añadir ejemplares a libro (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ")." + ex.Message + ex.StackTrace;


            }
            oLog.Add(msg);//Añadimos el mensaje al log
        }
    public void EliminarEjemplaresDeUnLibro(int pIdLibro, int pCantidad)
    //Permite disminuir la cantidad de ejemplares de un libro
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = ("Ejemplares del libro eliminados con exito (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ").");
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioLibros.Get(pIdLibro).EliminarEjemplares(pCantidad);//Eliminamos la cantidad ejemplares pasados por parametro del libro.
                    unitOfWork.Complete();//guardamos los cambios
                }
            }

            catch (Exception ex)
            {
                msg = "Error al eliminar ejemplares del libro (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ")." + ex.Message + ex.StackTrace;


            }
            oLog.Add(msg);//Añadimos el mensaje al log
        }
    public void DarDeBajaUnLibro(int pIdLibro)
    //Permite dar de baja un libro
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Libro Dado de baja con exito (Id: " + pIdLibro + ").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    Libro libro = unitOfWork.RepositorioLibros.Get(pIdLibro);//Obtenemos el libro por medio del metodo get y lo asignamos a una variable libro.
                    libro.DarDeBaja();//Llamamos al metodo dar de baja del libro
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {

                msg = "Error al dar de baja el libro (Id: " + pIdLibro + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
        }
    public void DarDeAltaUnLibro(int pIdLibro)
    //Permite dar de alta un libro que ha sido dado de baja 
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Libro Dado de alta con exito (Id: " + pIdLibro + ").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioLibros.Get(pIdLibro).DarDeAlta();//Obtnemos el libro a traves del parametro pasado, y llamamos al metodo DarDeAlta.
                    unitOfWork.Complete();//Guardamos los cambios.
                }

            }
            catch (Exception ex)
            {

                msg = "Error al dar de alta el libro (Id: " + pIdLibro + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
    }
  
   

    public List<Ejemplar> ObtenerEjemplaresDisponibles(int id)
    //Permite obtener la lista de ejemplares disponibles de un libro
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Ejemplar> lista = new List<Ejemplar>();//Instanciamos una lista de ejemplares que sera devuelta por el metodo
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresDisponibles();//Asignamos a la lista, los valores que devuelve la lista del metodo EjemplaresDisponible del libro
                    return lista;//Devolvemos la lista
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de ejemplares Disponibles del libro (id: " + id + ")." + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

            return lista;
    }

    public List<Ejemplar> ObtenerEjemplaresTotales(int id)
    //Permite obtener la lista total de ejemplares  de un libro
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Ejemplar> lista = new List<Ejemplar>();//Instanciamos una lista de ejemplares que sera devuelta por el metodo
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresTotales();//Asignamos a la lista, los valores que devuelve la lista del metodo EjemplaresTotales del libro

                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista total de ejemplares del libro (id: " + id + ")." + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

            return lista;//Devolvemos la lista
        }
   
    public void RegistrarPrestamo(string pNombreUsuario, int idEjemplar, int idLibro)
    //Permite registrar un nuevo prestamo
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Prestamo registrado con exito (idLibro: " + idLibro + "Id Ejemplar: " + idEjemplar + " Usuario: " + pNombreUsuario + ") obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    Prestamo prestamo = new Prestamo(unitOfWork.RepositorioUsuarios.Get(pNombreUsuario), unitOfWork.RepositorioEjemplares.Get(idEjemplar), unitOfWork.RepositorioLibros.Get(idLibro));//Instancia de un prestamo con los valores que pasamos como parametro
                    unitOfWork.RepositorioEjemplares.Get(idEjemplar).Disponible = false;//El ejemplar del prestamo pasa a estar no diponible
                    unitOfWork.RepositorioPrestamos.Add(prestamo);//Añadimos el pretamo a la base de datos
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al registrar el Prestamo  (idLibro: " + idLibro + "Id Ejemplar: " + idEjemplar + " Usuario: " + pNombreUsuario + ") ." + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);//Añadimos el mensaje al log
        }
    public Prestamo ObtenerPrestamo(int id)
    //Permite obtener un prestamo de la base de datos a partir del id del prestamo
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            Prestamo prestamo = new Prestamo();//Instanciamos un objeto del tipo prestamo que luego sera devuelto por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {

                    prestamo = unitOfWork.RepositorioPrestamos.Get(id);//Obtenemos el prestamo y lo asignamos a la variable prestamo creada
                }
            }
            catch (Exception ex)
            {

                msg = "Error al obtener el prestamo (Id: " + id + ")." + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

            return prestamo;//Devolvemos el prestamo
    }

    public void ActualizarLibro(int id, string unISBN, string titulo, string autor, string añoPublicacion)
    //Permite actualizar la informacion de un libro
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioLibros.Get(id).ISBN = unISBN;//Modificamos uno por uno los atributos del libro por los parametros pasados.
                    unitOfWork.RepositorioLibros.Get(id).Titulo = titulo;
                    unitOfWork.RepositorioLibros.Get(id).Autor = autor;
                    unitOfWork.RepositorioLibros.Get(id).AñoPublicacion = añoPublicacion;
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el libro (Id: " + id + "titulo: " + titulo + "autor: " + autor + ")." + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

    }

        public UsuarioSimple ObtenerUsuarioDePrestamo(int id)
    //Permite obtener el usuario de un prestamo a patir del id del prestamo
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            UsuarioSimple usuario = new UsuarioSimple();//Instanciamos un objeto del tipo UsuariosSimple que luego sera devuelto por el metodo
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    usuario = unitOfWork.RepositorioPrestamos.Get(id).Usuario;//Obtenemos el usuario y se lo asignamos a la variable creada anteriormente
                }
            }
            catch (Exception ex)
            {

                msg = "Error, el usuario del prestamo (Id Prestamo: " + id + ")." + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

            return usuario;//Devolvemos el usuario
        }

    public void RegistrarDevolucion(int idPrestamo, string estado)
    //Permite registrar la devolucion de un prestamo
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = " Prestamo devuelto (Id Prestamo: " + idPrestamo + " Estado:" + estado + ")";
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    if (estado == "Bueno")
                    {
                        unitOfWork.RepositorioPrestamos.Get(idPrestamo).RegistrarDevolucion(EstadoEjemplar.Bueno);//Obtenemos el prestamo por idPrestamo, y llamamos a su metodo registrar debolucion pasandole un EstadoEjemplar bueno
                    }
                    else unitOfWork.RepositorioPrestamos.Get(idPrestamo).RegistrarDevolucion(EstadoEjemplar.Malo);//Obtenemos el prestamo por idPrestamo, y llamamos a su metodo registrar debolucion pasandole un EstadoEjemplar malo


                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {

                msg = "Error al registrar la devolucion del prestamo (Id Prestamo: " + idPrestamo + " Estado:" + estado + ")" + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);//Añadimos el mensaje al log

        }

        public void ModificarFechasPrestamo(int pIdPrestamo, string pFechaPrestamo, string pFechaLimite)
    //permite modificar las fechas de realizacion y limite de un prestamo(funcion solo para versiones de prueba)
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {

                using (IUnitOfWork unitOfWork = GetUnitOfWork())
                {
                    unitOfWork.RepositorioPrestamos.Get(pIdPrestamo).FechaPrestamo = pFechaPrestamo;
                    unitOfWork.RepositorioPrestamos.Get(pIdPrestamo).FechaLimite = pFechaLimite;
                    unitOfWork.Complete();
                }
            }
            catch (Exception ex)
            {
                msg = "Error al modificar las fechas  del prestamo (Id Prestamo: " + pIdPrestamo + " Fecha prestamo: " + pFechaPrestamo + " Fecha Limite: " + pFechaLimite + ")." + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

        }



        public bool VerficarContraseña(string pNombreUsuario, string contraseña)
    //permite verificar que la combinacion NombreUsuario-Contraseña sea correcta
    {
            return ObtenerAdministrador(pNombreUsuario).VerificarContraseña(contraseña);//Obtiene el administrador y llama a su metodo VerificarContraseña con la contraseña pasada como paramtetro para verificar que el usuario y contraseña son correctos para iniciar sesion
        }
    public IEnumerable<UsuarioSimple> ObtenerUsuarios()
    //permite obtener la lista total de usuarios simples
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            IEnumerable<UsuarioSimple> lista;
            try
            {

                lista = GetUnitOfWork().RepositorioUsuarios.GetAll();
            }//Obtiene todos los usuarios simples con el metodo getall del repositorio
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de usuarios." + ex.Message + ex.StackTrace; ;
                lista = null;
                oLog.Add(msg);//Añadimos el mensaje al log
            }


            return lista;
        }

    public IEnumerable<UsuarioAdministrador> ObtenerAdministradores()
    //permite obtener la lista total de usuarios adminitradores
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            IEnumerable<UsuarioAdministrador> lista;
            try
            {

                lista = GetUnitOfWork().RepositorioAdministradores.GetAll();//Obtiene todos los usuarios administradores con el metodo getall del repositorio
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de administradores." + ex.Message + ex.StackTrace; ;
                lista = null;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

            return lista;
        }

    public IEnumerable<Libro> ObtenerLibros()
    //permite obtener la lista total de libros
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            IEnumerable<Libro> lista;
            try
            {

                lista = GetUnitOfWork().RepositorioLibros.GetAll();//Obtiene todos los usuarios administradores con el metodo getall del repositorio
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de libros." + ex.Message + ex.StackTrace; ;
                lista = null;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

            return lista;
        }

    

    public IEnumerable<Prestamo> ObtenerPrestamos()
    //permite obtener la lista total de prestamos
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            IEnumerable<Prestamo> lista;
            try
            {

                lista = GetUnitOfWork().RepositorioPrestamos.GetAll();//Obtiene todos los usuarios administradores con el metodo getall del repositorio
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de prestamos." + ex.Message + ex.StackTrace; ;
                lista = null;
                oLog.Add(msg);//Añadimos el mensaje al log
            }

            return lista;
        }

    public int ObtenerUltimoIdLibro()
    //devuelve el id del ultimo plibro registrado
    { return ObtenerLibros().Last().Id; }

    

    public int ObtenerUltimoIdPrestamo()
    //devuelve el id del ultimo prestamo registrado
    { return ObtenerPrestamos().Last().Id; }

    public List<Prestamo> ObtenerListadePrestamosProximosAVencerse()
    //Devuelve la lista de prestamos proximos a vencer
    {
            FachadaBitacora oLog = new FachadaBitacora();
            string msg;
            List<Prestamo> lista = new List<Prestamo>();//Instancia de una lista de prestamos que sera devuelta por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())
                {
                    lista = unitOfWork.RepositorioPrestamos.GetAllProximosAVencerse();
                }
                msg = "La lista de prestamos proximos a vencerse ha sido obtenida correctamente.";
            }
            catch (Exception ex)
            {
                msg = "Error, la lista de prestamos proximos a vencerse no pudo obtenerse." + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return lista;//Devuelve la lista            
        }

    public List<Prestamo> ObtenerListadePrestamosRetrasados()
    //Devuelve la lista de prestamos retasados
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Prestamo> lista = new List<Prestamo>();//Instancia de una lista de prestamos que sera devuelta por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())
                {
                    lista = unitOfWork.RepositorioPrestamos.GetAllRestrasados();
                }
                msg = "La lista de prestamos retrasados ha sido obtenida correctamente.";
            }
            catch (Exception ex)
            {
                msg = "Error, la lista de prestamos retrasados no pudo obtenerse. " + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return lista;//Devuelve la lista 
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

        private void NotificarProximoAVencer(string pNombreUsuario,string titulo,string fechaLimite)//notifica a un usuario que su prestamo esta proximo a vencer
    {
        RegistrarLog(interfazNotificarUsuario.NotificarProximoAVencer(ObtenerUsuario(pNombreUsuario), titulo, fechaLimite));
    }
    private void NotificarRetraso(string pNombreUsuario,string titulo,string fechaLimite)//notifica a un usuario que su prestamo esta retrasado
    {
        RegistrarLog(interfazNotificarUsuario.NotificarRetraso(ObtenerUsuario(pNombreUsuario), titulo, fechaLimite));
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
            Libro libro = ObtenerLibro(item.idLibro);
            NotificarProximoAVencer(usuario.NombreUsuario,libro.Titulo,item.FechaLimite);
        }
    }

    private void NotificarPrestamosRetrasados()//notifica a todos los usuarios con prestamos retrasados
    {
        foreach (var item in ObtenerListadePrestamosRetrasados())
        {
            UsuarioSimple usuario = ObtenerUsuarioDePrestamo(item.Id);
                Libro libro = ObtenerLibro(item.idLibro);
                NotificarRetraso(usuario.NombreUsuario, libro.Titulo, item.FechaLimite);
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
        if (DateTime.Now.Hour ==9)
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
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            bool resultado;//Booleano que se devolvera como resultado
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    resultado = unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).ValidarBaja();//Obtiene el usuario y llama a su metodo ValidarBaja. El valor que devuelve este metodo se guarda en la variable anterior nombrada.
                    if (resultado == true)//Si el resultado devuelto anterior mente es true
                    {
                        unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Baja = true;//Da de baja al usuario
                    }
                    unitOfWork.Complete();
                    msg = "El usuario " + pNombreUsuario + "ha sido dado de baja exitosamente. ";
                    oLog.Add(msg);//Añadimos el mensaje al log
                    return resultado;//Devuelve el resultado
                }
            }
            catch (Exception ex)
            {
                msg = "Error, el usuario " + pNombreUsuario + " no ha podido darse de baja. " + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
                return false;

            }
        }

    public bool DarDeBajaAdministrador(string pNombreUsuario)
    //Permite dar de baja un usuario administrador
    {
            if (pNombreUsuario == "admin")//Verifica si el administrador que quiere darse de baja no es el admin principal
            {
                return false;
            }
            else
            {
                FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
                string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
                try
                {
                    using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                    {
                        unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Baja = true;//Obtiene el administrador y coloca en su atributo baja el valor true
                        unitOfWork.Complete();//Guardamos los cambios
                    }
                    msg = "El administrador " + pNombreUsuario + " ha sido dado de baja correctamente. ";
                    oLog.Add(msg);//Añadimos el mensaje al log
                    return true;
                }
                catch (Exception ex)
                {
                    msg = "Error, el administrador " + pNombreUsuario + " no ha podido darse de baja. " + ex.Message + ex.StackTrace;
                    oLog.Add(msg);//Añadimos el mensaje al log
                    return false;

                }
            }
        }

    public void DarDeAltaUsuario(string pNombreUsuario)
    //Permite dar de alta un usuario simple dado de baja
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Baja = false;//Obtiene el usuario y coloca en su atributo baja el valor false
                    unitOfWork.Complete();//Guardamos los cambios
                }
                msg = "El usuario " + pNombreUsuario + " ha sido dado de alta correctamente";
                oLog.Add(msg);//Añadimos el mensaje al log
            }
            catch (Exception ex)
            {
                msg = "Error, el usuario " + pNombreUsuario + " no ha podido darse de alta. " + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log

            }

        }

        public void DarDeAltaAdministrador(string pNombreUsuario)
    //Permite dar de alta un administrador dado de baja
    {
            FachadaBitacora oLog = new FachadaBitacora();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork())//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Baja = false;//Obtiene el administrador y coloca en su atributo baja el valor false
                    unitOfWork.Complete();//Guardamos los cambios
                }
                msg = "El administrador" + pNombreUsuario + " ha sido dado de alta correctamente. ";
                oLog.Add(msg);//Añadimos el mensaje al log
            }
            catch (Exception ex)
            {
                msg = "Error, el administrador" + pNombreUsuario + " no ha podido darse de alta. " + ex.Message + ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log

            }
        }
}
}