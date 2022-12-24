using DAL;//Libreria de la capa de acceso a datos,nos permite interactuar con la base de datos, brindandonos control sobre la misma
using DAL.EntityFramework;//ORM para la base de datos
using Dominio;//Liberia que contiene las clases de dominio  
using NotificacionAUsuario;//Libreria que nos permite notificar a usuarios con prestamos retrasados o proximos a vencer
using ServiciosAPILibros;//Libreria que nos permite interactuar con la API de libros, pudiendo hacer consultas y obtener informacion acerca de libros
using System;
using System.Collections.Generic;
using System.Linq;


namespace Nucleo

{

    /// <summary>
    ///  Resumen: Representa la fachada del programa, nos permite acceder a todas las funciones del programa sin dar a conocer como funcionan por dentro
    /// </summary>

    public class Nucleo
    {
        private IServicioAPILibros ServicioAPILibros = new APIOpenLibrary();
        private INotificadorUsuario NotificadorUsuarios = new NotificadorOutlook();







        /// <summary>
        /// Resumen: Nos permite crear una instancia de la Fachada del programa.
        /// </summary>
        public Nucleo()
        {
        }

        /// <summary>
        ///Resumen:   Permite registrar un nuevo usuario simple, y devuelve el valor true si la operacion es exitosa y false si fue erronea 
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="mail"></param>
        /// <param name="telefono"></param>
        /// <returns>verdadero si el registro fue exitoso y false en el caso contrario</returns>
        //
        // 
        public bool AñadirUsuario(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono)
        {
            UsuarioSimple usuario = new UsuarioSimple(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario);//Instanciamos un usuario con los datos pasados por parametro
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            try
            {
                msg = "Usuario " + pNombreUsuario + " Registrado con exito.";
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    unitOfWork.RepositorioUsuarios.Add(usuario);//Añado el usuario a la base de datos
                    unitOfWork.Complete();//Guardamos los cambios
                }
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
                return true;
            }
            catch (Exception ex)
            {
                msg = "Error al registrar usuario (" + nombre + "-" + apellido + ")" + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
                return false;
            }
        }

        /// <summary>
        /// Resumen: Nos permite obtener un usuario simple de la base de datos a partir del nombreUsuario del usuario
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <returns>El usuario que posee ese nombre de usuario</returns>
        public UsuarioSimple ObtenerUsuario(string pNombreUsuario)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {

                UsuarioSimple usuario;//Creamos una variable de tipo usuario que sera devuelta por el metodo
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    usuario = unitOfWork.RepositorioUsuarios.Get(pNombreUsuario);//Asignamos al usuario el valor obtenido por el get a la base de datos
                }
                return usuario;//Devolvemos el usuario
            }
            catch (Exception ex)
            {
                msg = "Error al obtener el usuario (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
                return null;//Devolvemos el usuario
            }
        }

        /// <summary>
        /// Resumen:Resumen: Permite actualizar la informacion de un usuario simple (No administrador)
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="pFechaNacimiento"></param>
        /// <param name="mail"></param>
        /// <param name="telefono"></param>
        public void ActualizarUsuario(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a registrar en el log
            try
            {
                msg = "Usuario " + pNombreUsuario + " Actualizado con exito.";
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Nombre = nombre;//Modificamos uno por uno los valores por los parametros pasados
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Apellido = apellido;
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).FechaNacimiento = Convert.ToDateTime(pFechaNacimiento);
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Mail = mail;
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Telefono = telefono;
                    unitOfWork.Complete();//Guardamos los cambios
                }
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el usuario (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log

            }
        }

        /// <summary>
        /// Resumen:Este metodo nos permite resgistrar un nuevo Usuario Administrador
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="mail"></param>
        /// <param name="contraseña"></param>
        /// <param name="telefono"></param>
        /// <returns>Verdadero si la operacion fue exitosa y Falso en el caso contrario</returns>
        public bool AñadirAdministrador(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono)
        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            UsuarioAdministrador usuario = new UsuarioAdministrador(nombre, apellido, fechaNacimiento, mail, contraseña, telefono, pNombreUsuario);//Instanciamos un administrador con los datos pasados como parametro
            try
            {
                msg = "Administrador " + pNombreUsuario + " registrado con exito.";
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Add(usuario);//Añadimos el administrador a la base de datos
                    unitOfWork.Complete();//Guardamos los cambios
                }
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
                return true;//Indicamos con true que se pudo añadir correctamente
            }
            catch (Exception ex)
            {
                msg = "Error al Registrar el administrador (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
                return false;//Indicamos con false que no se pudo añadir correctamente

            }
        }

        /// <summary>
        /// Resumen: Nos permite obtener un usuario administrador de la base de datos a partir del nombreUsuario del usuario
        /// </summary>
        /// <param name="pNombreAdministrador"></param>
        /// <returns>Un Usuario, el Usuario solicitado en el caso de que exista y un Usuario vacio en el caso de que no</returns>
        public UsuarioAdministrador ObtenerAdministrador(string pNombreAdministrador)

        {
            UsuarioAdministrador administrador = new UsuarioAdministrador();//Instanciamos un administrador para que luego sea devuelto como resultado
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {

                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext())) //Definimos el ambito donde se va a usar la unitOfWork
                {
                    administrador = unitOfWork.RepositorioAdministradores.Get(pNombreAdministrador);//Asignamos a la variable administrado instanciada el valor que nos devuelve el get.
                }

            }
            catch (Exception ex)
            {
                msg = "Error al obtener el administrador (" + pNombreAdministrador + " ) " + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log

            }
            return administrador;//Devolvemos el administrador
        }


        /// <summary>
        /// Resumen: Permite actualizar la informacion de un Usuario Administrador
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="pFechaNacimiento"></param>
        /// <param name="mail"></param>
        /// <param name="telefono"></param>
        public void ActualizarAdministrador(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        //Permite actualizar la informacion de un usuario administrador
        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Administrador " + pNombreUsuario + " actualizado con exito.";
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
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
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
        }

        /// <summary>
        /// Resumen: Nos permite actualizar la contraseña de un Usuario Administrador
        /// </summary>
        /// <param name="pNombreAdministrador"></param>
        /// <param name="contraseña"></param>
        public void ActualizarContraseñaAdministrador(string pNombreAdministrador, string contraseña)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Contraseña del administrador " + pNombreAdministrador + " actualizada con exito.";
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreAdministrador).Pass = contraseña;//Modificamos la contraseña actual por la que pasamos como parametro
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar la contraseña del administrador (" + pNombreAdministrador + " ) " + ex.Message + ex.StackTrace;
            }
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
        }

        /// <summary>
        /// Resumen:Permite registrar un nuevo libro
        /// </summary>
        /// <param name="unISBN"></param>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="añoPublicacion"></param>
        /// <param name="pCantidadEjempalares"></param>
        /// <returns></returns>
        public bool AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion, int pCantidadEjempalares)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            bool resultado = true;
            try
            {
                msg = "Libro ( Titulo: " + titulo + " Autor: " + autor + " ISBN:" + unISBN + " ) registrado con exito.";
                Libro libro = new Libro(unISBN, titulo, autor, añoPublicacion);//Instanciamos un libro con los parametros pasados al metodo.
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar  unitOfWork
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
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            return resultado;
        }

        /// <summary>
        /// Permite obtener un libro de la base de datos a partir del id del mismo 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Un libro, el libros solicitado en el caso de exista y un libro vacio en el caso contrario</returns>
        public Libro ObtenerLibro(int id)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            Libro libro = new Libro();//Instanciamos un libro que sera devuelto por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    libro = unitOfWork.RepositorioLibros.Get(id);//Obtenemos el libro a travez del metodo get con la id pasada por parametro y se lo asignamos a la variable creada.
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener el libro (Id: " + id + " ) ." + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }

            return libro;//Devolvemos el libro
        }

        /// <summary>
        /// Resumen:Nos permite obtener la lista de ejemplares en buen estado de un libro
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List Ejemplar </returns>
        public List<Ejemplar> ObtenerEjemplaresEnBuenEstadoLibro(int id)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Ejemplar> lista = new List<Ejemplar>(); //Creamos un listado que contenga objetos del tipo Ejemplar para ser devuelto por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresEnBuenEstado();//Asignamos a la lista creada, la lista que nos devuelve el metodo que EjemplaresEnBuenEstado que posee el libro, cuya id es id.
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener lista de ejemplares en buen estado del libro (id libro: " + id + ")" + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            return lista;//Devolvemos la lista
        }

        /// <summary>
        /// Resumen: Permite añadir mas ejemplares a un libro
        /// </summary>
        /// <param name="pIdLibro"></param>
        /// <param name="pCantidad"></param>
        public void AñadirEjemplares(int pIdLibro, int pCantidad)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = ("Ejemplares Añadidos a libro con exito (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ").");
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext())) //Definimos el ambito donde se va a usar la unitOfWork
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
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
        }

        /// <summary>
        /// Resumen: Permite disminuir la cantidad de ejemplares de un libro
        /// </summary>
        /// <param name="pIdLibro"></param>
        /// <param name="pCantidad"></param>
        public void EliminarEjemplaresDeUnLibro(int pIdLibro, int pCantidad)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = ("Ejemplares del libro eliminados con exito (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ").");
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    unitOfWork.RepositorioLibros.Get(pIdLibro).EliminarEjemplares(pCantidad);//Eliminamos la cantidad ejemplares pasados por parametro del libro.
                    unitOfWork.Complete();//guardamos los cambios
                }
            }

            catch (Exception ex)
            {
                msg = "Error al eliminar ejemplares del libro (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ")." + ex.Message + ex.StackTrace;

            }
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
        }

        /// <summary>
        /// Resumen: Permite dar de baja un libro
        /// </summary>
        /// <param name="pIdLibro"></param>
        public void DarDeBajaUnLibro(int pIdLibro)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Libro Dado de baja con exito (Id: " + pIdLibro + ").";
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
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
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
        }

        /// <summary>
        /// Resumen: Permite dar de alta un libro que se encuentra dado de baja
        /// </summary>
        /// <param name="pIdLibro"></param>
        public void DarDeAltaUnLibro(int pIdLibro)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Libro Dado de alta con exito (Id: " + pIdLibro + ").";
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    unitOfWork.RepositorioLibros.Get(pIdLibro).DarDeAlta();//Obtnemos el libro a traves del parametro pasado, y llamamos al metodo DarDeAlta.
                    unitOfWork.Complete();//Guardamos los cambios.
                }
            }
            catch (Exception ex)
            {

                msg = "Error al dar de alta el libro (Id: " + pIdLibro + ")." + ex.Message + ex.StackTrace;
            }
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
        }

        /// <summary>
        /// Resumen:Permite obtener la lista de ejemplares disponibles de un libro
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List Ejemplar</returns>
        public List<Ejemplar> ObtenerEjemplaresDisponibles(int id)
        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Ejemplar> lista = new List<Ejemplar>();//Instanciamos una lista de ejemplares que sera devuelta por el metodo
            try
            {

                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresDisponibles();//Asignamos a la lista, los valores que devuelve la lista del metodo EjemplaresDisponible del libro
                    return lista;//Devolvemos la lista
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de ejemplares Disponibles del libro (id: " + id + ")." + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            return lista;
        }

        /// <summary>
        /// Resumen:Permite obtener la lista total de ejemplares de un libro
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List Ejemplar</returns>
        public List<Ejemplar> ObtenerEjemplaresTotales(int id)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Ejemplar> lista = new List<Ejemplar>();//Instanciamos una lista de ejemplares que sera devuelta por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar launitOfWork
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresTotales();//Asignamos a la lista, los valores que devuelve la lista del metodo EjemplaresTotales del libro

                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista total de ejemplares del libro (id: " + id + ")." + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            return lista;//Devolvemos la lista
        }

        /// <summary>
        /// Resumen:Permite registrar un nuevo prestamo
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <param name="idEjemplar"></param>
        /// <param name="idLibro"></param>
        public void RegistrarPrestamo(string pNombreUsuario, int idEjemplar, int idLibro)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Prestamo registrado con exito (idLibro: " + idLibro + "Id Ejemplar: " + idEjemplar + " Usuario: " + pNombreUsuario + ") obtenida con exito.";
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
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
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
        }

        /// <summary>
        /// Resumen: Permite obtener un prestamo de la base de datos a partir del id del prestamo
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Prestamo</returns>
        public Prestamo ObtenerPrestamo(int id)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            Prestamo prestamo = new Prestamo();//Instanciamos un objeto del tipo prestamo que luego sera devuelto por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    prestamo = unitOfWork.RepositorioPrestamos.Get(id);//Obtenemos el prestamo y lo asignamos a la variable prestamo creada
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener el prestamo (Id: " + id + ")." + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            return prestamo;//Devolvemos el prestamo
        }

        /// <summary>
        /// Resumen: Permite actualizar la informacion de un Libro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="unISBN"></param>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="añoPublicacion"></param>
        public void ActualizarLibro(int id, string unISBN, string titulo, string autor, string añoPublicacion)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
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
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
        }

        /// <summary>
        /// Resumen: Permite obtener el Usuario de un prestamo a patir del id del prestamo
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Usuario Simple</returns>
        public UsuarioSimple ObtenerUsuarioDePrestamo(int id)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            UsuarioSimple usuario = new UsuarioSimple();//Instanciamos un objeto del tipo UsuariosSimple que luego sera devuelto por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    usuario = unitOfWork.RepositorioPrestamos.Get(id).Usuario;//Obtenemos el usuario y se lo asignamos a la variable creada anteriormente
                }
            }
            catch (Exception ex)
            {
                msg = "Error, el usuario del prestamo (Id Prestamo: " + id + ")." + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            return usuario;//Devolvemos el usuario
        }

        /// <summary>
        /// Resumen: Permite registrar la devolucion de un prestamo
        /// </summary>
        /// <param name="idPrestamo"></param>
        /// <param name="estado"></param>
        public void RegistrarDevolucion(int idPrestamo, string estado)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = " Prestamo devuelto (Id Prestamo: " + idPrestamo + " Estado:" + estado + ")";
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
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
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
        }



        /// <summary>
        /// Resumen: Permite verificar que la combinacion NombreUsuario-Contraseña sea correcta
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <param name="contraseña"></param>
        /// <returns>(Boolean) Verdadero si la combinacion es correcta y Falso en caso contrario</returns>
        public bool VerficarContraseña(string pNombreUsuario, string contraseña)

        {
            return ObtenerAdministrador(pNombreUsuario).VerificarContraseña(contraseña);//Obtiene el administrador y llama a su metodo VerificarContraseña con la contraseña pasada como paramtetro para verificar que el usuario y contraseña son correctos para iniciar sesion
        }

        /// <summary>
        /// Resumen: Permite obtener la lista total Usuarios Simples
        /// </summary>
        /// <returns>List UsuarioSimple</returns>
        public IEnumerable<UsuarioSimple> ObtenerUsuarios()
        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            IEnumerable<UsuarioSimple> lista;
            try
            {
                IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext());
                lista = unitOfWork.RepositorioUsuarios.GetAll();
            }//Obtiene todos los usuarios simples con el metodo getall del repositorio
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de usuarios." + ex.Message + ex.StackTrace; ;
                lista = null;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }

            return lista;
        }

        /// <summary>
        /// Resumen: Permite obtener la lista total Usuarios Administradores
        /// </summary>
        /// <returns>List UsuarioAdministrador</returns>
        public IEnumerable<UsuarioAdministrador> ObtenerAdministradores()

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            IEnumerable<UsuarioAdministrador> lista;
            try
            {
                IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext());

                lista = unitOfWork.RepositorioAdministradores.GetAll();//Obtiene todos los usuarios administradores con el metodo getall del repositorio

            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de administradores." + ex.Message + ex.StackTrace; ;
                lista = null;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            return lista;
        }

        /// <summary>
        /// Resumen: Permite obtener la lista total de Libros
        /// </summary>
        /// <returns>List Libro</returns>
        public IEnumerable<Libro> ObtenerLibros()
        //permite obtener la lista total de libros
        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            IEnumerable<Libro> lista;
            try
            {
                IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext());

                lista = unitOfWork.RepositorioLibros.GetAll();//Obtiene todos los usuarios administradores con el metodo getall del repositorio

            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de libros." + ex.Message + ex.StackTrace; ;
                lista = null;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            return lista;
        }

        /// <summary>
        /// Resumen: Permite obtener la lista total de prestamos
        /// </summary>
        /// <returns>List Prestamo</returns>
        public IEnumerable<Prestamo> ObtenerPrestamos()

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            IEnumerable<Prestamo> lista;
            try
            {

                IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext());
                lista = unitOfWork.RepositorioPrestamos.GetAll();//Obtiene todos los usuarios administradores con el metodo getall del repositorio


            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de prestamos." + ex.Message + ex.StackTrace; ;
                lista = null;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            return lista;
        }

        /// <summary>
        /// Resumen: Devuelve el id del ultimo plibro registrado
        /// </summary>
        /// <returns> (Int) id del ultimo plibro registrado</returns>
        public int ObtenerUltimoIdLibro()

        {
            return ObtenerLibros().Last().Id;
        }

        /// <summary>
        /// Resumen: Devuelve la lista de prestamos proximos a vencerse
        /// </summary>
        /// <returns>List Prestamo </returns>
        public List<Prestamo> ObtenerListadePrestamosProximosAVencerse()
        //Devuelve la lista de prestamos proximos a vencer
        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;
            List<Prestamo> lista = new List<Prestamo>();//Instancia de una lista de prestamos que sera devuelta por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))
                {
                    lista = unitOfWork.RepositorioPrestamos.GetAllProximosAVencerse();
                }
                msg = "La lista de prestamos proximos a vencerse ha sido obtenida correctamente.";
            }
            catch (Exception ex)
            {
                msg = "Error, la lista de prestamos proximos a vencerse no pudo obtenerse." + ex.Message + ex.StackTrace;

            }
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            return lista;//Devuelve la lista            
        }


        /// <summary>
        /// Resumen: Devuelve la lista de prestamos retasados
        /// </summary>
        /// <returns>List Prestamo </returns>
        public List<Prestamo> ObtenerListadePrestamosRetrasados()

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Prestamo> lista = new List<Prestamo>();//Instancia de una lista de prestamos que sera devuelta por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))
                {
                    lista = unitOfWork.RepositorioPrestamos.GetAllRestrasados();
                }
                msg = "La lista de prestamos retrasados ha sido obtenida correctamente.";
            }
            catch (Exception ex)
            {
                msg = "Error, la lista de prestamos retrasados no pudo obtenerse. " + ex.Message + ex.StackTrace;
            }
            oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            return lista;//Devuelve la lista 
        }

        /// <summary>
        /// Resumen: Realiza una consulta en la API de libros y devuelve una lista de libros que coincidan con el termino buscado
        /// </summary>
        /// <param name="unaCadena"></param>
        /// <returns>List Libro</returns>
        public List<Libro> ListarLibrosDeAPIPorCoincidencia(string unaCadena)
        {
            return ServicioAPILibros.ConsultarlistadoDeLibros(unaCadena);
        }

        /// <summary>
        /// Resumen: Notifica a todos los usuarios con prestamos proximos a vencer
        /// </summary>
        public void NotificarPrestamosProximosAVencer()
        {
            void NotificarProximoAVencer(string pNombreUsuario, string titulo, string fechaLimite)//notifica a un usuario que su prestamo esta proximo a vencer
            {
                Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
                oLog.RegistrarLog(NotificadorUsuarios.NotificarProximoAVencer(ObtenerUsuario(pNombreUsuario), titulo, fechaLimite));
            }
            foreach (var item in ObtenerListadePrestamosProximosAVencerse())
            {
                UsuarioSimple usuario = ObtenerUsuarioDePrestamo(item.Id);
                Libro libro = ObtenerLibro(item.idLibro);
                NotificarProximoAVencer(usuario.NombreUsuario, libro.Titulo, item.FechaLimite);
            }
        }

        /// <summary>
        /// Resumen:Notifica a todos los usuarios con prestamos retrasados
        /// </summary>
        public void NotificarPrestamosRetrasados()
        {
            void NotificarRetraso(string pNombreUsuario, string titulo, string fechaLimite)//notifica a un usuario que su prestamo esta retrasado
            {
                Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
                oLog.RegistrarLog(NotificadorUsuarios.NotificarRetraso(ObtenerUsuario(pNombreUsuario), titulo, fechaLimite));
            }
            foreach (var item in ObtenerListadePrestamosRetrasados())
            {
                UsuarioSimple usuario = ObtenerUsuarioDePrestamo(item.Id);
                Libro libro = ObtenerLibro(item.idLibro);
                NotificarRetraso(usuario.NombreUsuario, libro.Titulo, item.FechaLimite);
            }
        }

        /// <summary>
        /// Resumen: Notifica a todos los usuarios con prestamos retrasados o proximos a vencer,en el caso de que la hora este entre las 9 y 10 am
        /// </summary>
        public void NotificarUsuarios()
        {
                NotificarPrestamosRetrasados();
                NotificarPrestamosProximosAVencer();
        }

        /// <summary>
        /// Resumen: Permite dar de baja un Usuario
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <returns></returns>
        public bool DarDeBajaUsuario(string pNombreUsuario)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            bool resultado;//Booleano que se devolvera como resultado
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    resultado = unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).ValidarBaja();//Obtiene el usuario y llama a su metodo ValidarBaja. El valor que devuelve este metodo se guarda en la variable anterior nombrada.
                    if (resultado == true)//Si el resultado devuelto anterior mente es true
                    {
                        unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Baja = true;//Da de baja al usuario
                    }
                    unitOfWork.Complete();
                    msg = "El usuario " + pNombreUsuario + "ha sido dado de baja exitosamente. ";
                    oLog.RegistrarLog(msg);//Añadimos el mensaje al log
                    return resultado;//Devuelve el resultado
                }
            }
            catch (Exception ex)
            {
                msg = "Error, el usuario " + pNombreUsuario + " no ha podido darse de baja. " + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
                return false;
            }
        }

        /// <summary>
        /// Resumen: Permite dar de baja un Usuario Adminstrador
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <returns>Un Boolean que indica el exito de la operacion</returns>
        public bool DarDeBajaAdministrador(string pNombreUsuario)

        {
            if (pNombreUsuario == "admin")//Verifica si el administrador que quiere darse de baja no es el admin principal
            {
                return false;
            }
            else
            {
                Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
                string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
                try
                {
                    using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                    {
                        unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Baja = true;//Obtiene el administrador y coloca en su atributo baja el valor true
                        unitOfWork.Complete();//Guardamos los cambios
                    }
                    msg = "El administrador " + pNombreUsuario + " ha sido dado de baja correctamente. ";
                    oLog.RegistrarLog(msg);//Añadimos el mensaje al log
                    return true;
                }
                catch (Exception ex)
                {
                    msg = "Error, el administrador " + pNombreUsuario + " no ha podido darse de baja. " + ex.Message + ex.StackTrace;
                    oLog.RegistrarLog(msg);//Añadimos el mensaje al log
                    return false;
                }
            }
        }

        /// <summary>
        /// Resumen:Permite dar de alta a un Usuario Simple al cual se le dio una baja logica
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        public void DarDeAltaUsuario(string pNombreUsuario)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Baja = false;//Obtiene el usuario y coloca en su atributo baja el valor false
                    unitOfWork.Complete();//Guardamos los cambios
                }
                msg = "El usuario " + pNombreUsuario + " ha sido dado de alta correctamente";
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            catch (Exception ex)
            {
                msg = "Error, el usuario " + pNombreUsuario + " no ha podido darse de alta. " + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
        }

        /// <summary>
        /// Resumen:Permite dar de alta a un Usuario Administrador al cual se le dio una baja logica
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        public void DarDeAltaAdministrador(string pNombreUsuario)

        {
            Bitacora.ImplementacionBitacoraConLog4Net oLog = new Bitacora.ImplementacionBitacoraConLog4Net();
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = new UnitOfWorkMSSQL(new AdministradorDePrestamosDbContext()))//Definimos el ambito donde se va a usar la unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Baja = false;//Obtiene el administrador y coloca en su atributo baja el valor false
                    unitOfWork.Complete();//Guardamos los cambios
                }
                msg = "El administrador" + pNombreUsuario + " ha sido dado de alta correctamente. ";
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
            catch (Exception ex)
            {
                msg = "Error, el administrador" + pNombreUsuario + " no ha podido darse de alta. " + ex.Message + ex.StackTrace;
                oLog.RegistrarLog(msg);//Añadimos el mensaje al log
            }
        }
    }
}