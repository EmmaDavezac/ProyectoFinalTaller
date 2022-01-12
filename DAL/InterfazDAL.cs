using DAL.EntityFramework;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using Bitacora;


namespace DAL
{
    public class InterfazDAL
    {
        static string[] implementacionesBase = new string[] { "ConnectionSQLServerLocal", "ConnectionSQLServerHosting" };//cadenas de conexion a bases de datos
        static private string implementacionBase = implementacionesBase[1];
        private IUnitOfWork GetUnitOfWork(string pCadenaConexion)//implementaciones posibles para las base de datos, interactua con la interfaz IUnitOfWork, esta abtraccion nos permite poder trabajar con distintas implementaciones
        {
            switch (pCadenaConexion)
            {
                case "ConnectionSQLServerHosting": { return new UnitOfWork(new AdministradorDePrestamosDbContext(pCadenaConexion)); }//implementacion en una base de datos relacional de SQLServer con hosting en un servidor proporcionado por  la web https://www.smarterasp.net/
                case "ConnectionSQLServerLocal": { return new UnitOfWork(new AdministradorDePrestamosDbContext(pCadenaConexion)); }//implementacion en una base de datos relacional de SQLServer en un servidor local de MSQLSERVER
                default: { return new UnitOfWork(new AdministradorDePrestamosDbContext(implementacionesBase[0])); }//implementacion por defecto,implementacion en una base de datos relacional de SQLServer en un servidor local de MSQLSERVER

            }
        }

        public InterfazDAL()
        {
        }
        public bool AñadirUsuario(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono)
        {
            UsuarioSimple usuario = new UsuarioSimple(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario);//Instanciamos un usuario con los datos pasados por parametro
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            try
            {
                msg = "Usuario " + pNombreUsuario + " Registrado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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

        public UsuarioSimple ObtenerUsuario(string pNombreUsuarioOEmail)
        {
            
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Usuario " + pNombreUsuarioOEmail + " Obtenido con exito.";
                UsuarioSimple usuario;//Creamos una variable de tipo usuario que sera devuelta por el metodo
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {   
                    usuario= unitOfWork.RepositorioUsuarios.Get(pNombreUsuarioOEmail);//Asignamos al usuario el valor obtenido por el get a la base de datos
                }
                oLog.Add(msg);//Añadimos el mensaje al log
                return usuario;//Devolvemos el usuario

            }
            catch (Exception ex)
            {

                msg = "Error al obtener el usuario (" +pNombreUsuarioOEmail + ") " + ex.Message+ex.StackTrace;
                oLog.Add(msg);//Añadimos el mensaje al log
                return null;//Devolvemos el usuario
            }
        }

        public void ActualizarUsuario(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Usuario " + pNombreUsuario + " Actualizado con exito.";
                
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            UsuarioAdministrador usuario = new UsuarioAdministrador(nombre, apellido, fechaNacimiento, mail, contraseña, telefono, pNombreUsuario);//Instanciamos un administrador con los datos pasados por parametro
            try
            {
                msg = "Administrador " + pNombreUsuario + " registrado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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

        public List<Ejemplar> ObtenerEjemplaresEnBuenEstadoLibro(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Ejemplar> lista = new List<Ejemplar>(); //Creamos un listado que contenga objetos del tipo Ejemplar para ser devuelto por el metodo
            try
            {
                msg = "lista de ejemplares del libro (id libro: "+id+") en buen estado obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresEnBuenEstado();//Asignamos a la lista creada, la lista que nos devuelve el metodo que EjemplaresEnBuenEstado que posee el libro, cuya id es id.
                }
                

            }
            catch (Exception ex)
            {
                msg = "Error al obtener lista de ejemplares en buen estado del libro (id libro: " + id + ")" + ex.Message + ex.StackTrace;
                
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return lista;//Devolvemos la lista
        }

        public UsuarioAdministrador ObtenerAdministrador(string pNombreUsuario)
        {
            UsuarioAdministrador administrador = new UsuarioAdministrador();//Instanciamos un administrador para que luego sea devuelto como resultado
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Administrador " + pNombreUsuario + " Obtenido con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    administrador= unitOfWork.RepositorioAdministradores.Get(pNombreUsuario);//Asignamos a la variable administrado instanciada el valor que nos devuelve el get.
                }

            }
            catch (Exception ex)
            {
                msg = "Error al obtener el administrador (" + pNombreUsuario + " ) " + ex.Message + ex.StackTrace;
               
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return administrador;//Devolvemos el administrador
        }
        public void ActualizarAdministrador(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Administrador " + pNombreUsuario + " actualizado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
        public void ActualizarContraseñaAdministrador(string pNombreUsuario, string contraseña)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Contraseña del administrador " + pNombreUsuario + " actualizada con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Pass = contraseña;//Modificamos la contraseña actual por la que pasamos como parametro
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar la contraseña del administrador (" + pNombreUsuario + " ) " + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);//Añadimos el mensaje al log


        }

        public void AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion, int pCantidadEjempalares)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Libro ( Titulo: "+titulo+" Autor: "+autor+" ISBN:" + unISBN + " ) registrado con exito.";
                Libro libro = new Libro(unISBN, titulo, autor, añoPublicacion);//Instanciamos un libro con los parametros pasados al metodo.
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
            catch ( Exception ex)
            {

                msg = "Error al registrar el libro ( Titulo: " + titulo + " Autor: " + autor + " ISBN:" + unISBN + " ) ." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
        }
        public Libro ObtenerLibro(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            Libro libro = new Libro();//Instanciamos un libro que sera devuelto por el metodo
            try
            {
                msg = "Libro (Id: " + id + " ) Obtenido con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                     libro = unitOfWork.RepositorioLibros.Get(id);//Obtenemos el libro a travez del metodo get con la id pasada por parametro y se lo asignamos a la variable creada.
                     unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch (Exception ex )
            {
                msg = "Error al obtener el libro (Id: " + id + " ) ." + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return libro;//Devolvemos el libro
        }


        public int ObtenerCantEjemplaresLibro(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            int cant = 0;//Entero que nos permitira almacenar la cantidad de ejemplares
            try
            {
                msg = "Cantidad de ejemplares del Libro (Id: " + id + " ) Obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    cant= unitOfWork.RepositorioLibros.Get(id).Ejemplares.Count();//Le asignamos a la variable cant lo que devuele el metodo count sobre la lista de ejemplares del libro.
                }
            }
            catch (Exception ex)
            {

                msg = "Error al obtener la cantidad de ejemplares del libro (Id: " + id + " ) ." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return cant;//Devolvemos la cantidad

        }

        public void AñadirEjemplares(int pIdLibro, int pCantidad)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = ("Ejemplares Añadidos a libro con exito (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ").");
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = ("Ejemplares del libro eliminados con exito (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ").");
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {  msg="Libro Dado de baja con exito (Id: "+pIdLibro+").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Libro Dado de alta con exito (Id: " + pIdLibro + ").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Ejemplar> lista = new List<Ejemplar>();//Instanciamos una lista de ejemplares que sera devuelta por el metodo
            try
            {
                msg = "Lista de ejemplares Disponibles del libro (id: " + id + ") obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresDisponibles();//Asignamos a la lista, los valores que devuelve la lista del metodo EjemplaresDisponible del libro
                    return lista;//Devolvemos la lista
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de ejemplares Disponibles del libro (id: " + id + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return lista;
        }

        public List<Ejemplar> ObtenerEjemplaresTotales(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Ejemplar> lista = new List<Ejemplar>();//Instanciamos una lista de ejemplares que sera devuelta por el metodo
            try
            {
                msg = "Lista de ejemplares total del libro (id: " + id + ") obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                 lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresTotales();//Asignamos a la lista, los valores que devuelve la lista del metodo EjemplaresTotales del libro

                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista total de ejemplares del libro (id: " + id + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return lista;//Devolvemos la lista
        }

        public void RegistrarPrestamo(string pNombreUsuario, int idEjemplar, int idLibro)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Prestamo registrado con exito (idLibro: " + idLibro + "Id Ejemplar: "+idEjemplar+" Usuario: "+pNombreUsuario+") obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    Prestamo prestamo = new Prestamo(unitOfWork.RepositorioUsuarios.Get(pNombreUsuario), unitOfWork.RepositorioEjemplares.Get(idEjemplar), unitOfWork.RepositorioLibros.Get(idLibro));//Instancia de un prestamo con los valores que pasamos como parametro
                    unitOfWork.RepositorioEjemplares.Get(idEjemplar).Disponible = false;//El ejemplar del prestamo pasa a estar no diponible
                    unitOfWork.RepositorioPrestamos.Add(prestamo);//Añadimos el pretamo a la base de datos
                    unitOfWork.Complete();//Guardamos los cambios
                }
            }
            catch ( Exception ex)
            {
                msg = "Error al registrar el Prestamo  (idLibro: " + idLibro + "Id Ejemplar: " + idEjemplar + " Usuario: " + pNombreUsuario + ") ." + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);//Añadimos el mensaje al log
        }
        public Prestamo ObtenerPrestamo(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            Prestamo prestamo = new Prestamo();//Instanciamos un objeto del tipo prestamo que luego sera devuelto por el metodo
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    msg = "Prestamo (Id: " + id + ") Obtenido con exito.";
                    prestamo=unitOfWork.RepositorioPrestamos.Get(id);//Obtenemos el prestamo y lo asignamos a la variable prestamo creada
                }
            }
            catch (Exception ex)
            {

                msg = "Error al obtener el prestamo (Id: "+ id + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return prestamo;//Devolvemos el prestamo
        }

        public void ActualizarLibro(int id, string unISBN, string titulo, string autor, string añoPublicacion)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Libro " + titulo + " " + autor + " actualizado con exito (Id: " + id + ").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
            }
            oLog.Add(msg);//Añadimos el mensaje al log
        }

        public UsuarioSimple ObtenerUsuarioDePrestamo(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            UsuarioSimple usuario = new UsuarioSimple();//Instanciamos un objeto del tipo UsuariosSimple que luego sera devuelto por el metodo
            try
            {
                msg = "Usuario de Prestamo obtenido con exito (Id Prestamo: " + id + ")." ;
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
                {
                    usuario=unitOfWork.RepositorioPrestamos.Get(id).Usuario;//Obtenemos el usuario y se lo asignamos a la variable creada anteriormente
                }
            }
            catch (Exception ex)
            {

                msg = "Error, el usuario del prestamo (Id Prestamo: " + id + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return usuario;//Devolvemos el usuario
        }

        public void RegistrarDevolucion(int idPrestamo, string estado)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                msg = "Devolucion de prestamo registrada exitosamente(Id Prestamo: " + idPrestamo + " Estado:" + estado + ")" ;
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioPrestamos.Get(pIdPrestamo).FechaPrestamo = pFechaPrestamo;
                unitOfWork.RepositorioPrestamos.Get(pIdPrestamo).FechaLimite = pFechaLimite;
                unitOfWork.Complete();
            }
        }

        public bool VerficarContraseña(string pNombreUsuario, string contraseña)
        {
            return ObtenerAdministrador(pNombreUsuario).VerificarContraseña(contraseña);//Obtiene el administrador y llama a su metodo VerificarContraseña con la contraseña pasada como paramtetro
        }
        public IEnumerable<UsuarioSimple> ObtenerUsuarios()
        { return GetUnitOfWork(implementacionBase).RepositorioUsuarios.GetAll(); }//Obtiene todos los usuarios simples con el metodo getall del repositorio
        public IEnumerable<UsuarioAdministrador> ObtenerAdministradores()
        { return GetUnitOfWork(implementacionBase).RepositorioAdministradores.GetAll(); }//Obtiene todos los usuarios administradores con el metodo getall del repositorio
        public IEnumerable<Libro> ObtenerLibros()
        { return GetUnitOfWork(implementacionBase).RepositorioLibros.GetAll(); }//Obtiene todos los libros con el metodo getall del repositorio
        public IEnumerable<Prestamo> ObtenerPrestamos()
        { return GetUnitOfWork(implementacionBase).RepositorioPrestamos.GetAll(); }//Obtiene todos los prestamos con el metodo getall del repositorio
        public List<Prestamo> ObtenerListadePrestamosProximosAVencerse()
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            List<Prestamo> lista = new List<Prestamo>();//Instancia de una lista de prestamos que sera devuelta por el metodo
            try
            {
                foreach (var item in GetUnitOfWork(implementacionBase).RepositorioPrestamos.GetAll())//Recorre la lista de prestamos de la base de datos
                {
                    if (item.ProximoAVencerse())//Para cada elemento se pregunta si esta proximo a vencerse
                    {
                        lista.Add(item);//Añade el item a la lista anteriormente creada
                    }
                }
                msg = "La lista de prestamos proximos a vencerse ha sido obtenida correctamente.";
            }
            catch (Exception ex)
            {
                msg = "Error, la lista de prestamos proximos a vencerse no pudo obtenerse." + ex.Message + ex.StackTrace;
                throw;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return lista;//Devuelve la lista            
        }
        public List<Prestamo> ObtenerListadePrestamosRetrasados()

        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            List<Prestamo> lista = new List<Prestamo>();//Instancia de una lista de prestamos que sera devuelta por el metodo
            try
            {
                foreach (var item in GetUnitOfWork(implementacionBase).RepositorioPrestamos.GetAll())//Recorre la lista de prestamos de la base de datos
                {
                    if (item.Retrasado())//Para cada elemento se pregunta si esta restrasado
                    {
                        lista.Add(item);//Añade el item a la lista anteriormente creada
                    }
                }
                msg = "La lista de prestamos retrasados ha sido obtenida correctamente.";
            }
            catch (Exception ex)
            {
                msg = "Error, la lista de prestamos retrasados no pudo obtenerse. " + ex.Message + ex.StackTrace;
                throw;
            }
            oLog.Add(msg);//Añadimos el mensaje al log
            return lista;//Devuelve la lista 
        }

        public bool EsUnEmailValido(string email)
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

        public bool DarDeBajaUsuario(string pNombreUsuario)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            bool resultado;//Booleano que se devolvera como resultado
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
                throw;
            }
        }

        public bool DarDeBajaAdministrador(string pNombreUsuario)
        {
            if (pNombreUsuario == "admin")//Verifica si el administrador que quiere darse de baja no es el admin principal
            {
                return false;
            }
            else 
            {
                ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
                string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
                try
                {
                    using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
                    throw;
                }
            }
            
        }

        public void DarDeAltaUsuario(string pNombreUsuario)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
                throw;
            }
            
        }

        public void DarDeAltaAdministrador(string pNombreUsuario)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();//Instancia de un objeto ArchivoLog para guardar mensajes en el log
            string msg;//String que nos permite guardar el mensaje que vamos a mandar al log
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))//Definimos el ambito donde se va a usar el objet unitOfWork
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
                throw;
            }
        }
    }
}