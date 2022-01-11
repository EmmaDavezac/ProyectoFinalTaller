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
            UsuarioSimple usuario = new UsuarioSimple(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario);
            string msg;
            ArchivoDeLog oLog = new ArchivoDeLog();
            try
            {
                msg = "Usuario " + pNombreUsuario + " Registrado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {                       
                        unitOfWork.RepositorioUsuarios.Add(usuario);
                        unitOfWork.Complete();
                }
                oLog.Add(msg);
                return true;
            }
            catch (Exception ex)
            {
                msg = "Error al registrar usuario (" + nombre + "-" + apellido + ") " + ex.Message + ex.StackTrace;
                oLog.Add(msg);
                return false;
            }
            
            
        }

        public UsuarioSimple ObtenerUsuario(string pNombreUsuarioOEmail)
        {
            
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Usuario " + pNombreUsuarioOEmail + " Obtenido con exito.";
                
                UsuarioSimple usuario;
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {   
                    usuario= unitOfWork.RepositorioUsuarios.Get(pNombreUsuarioOEmail);
                }
                oLog.Add(msg);
                return usuario;

            }
            catch (Exception ex)
            {

                msg = "Error al obtener el usuario (" +pNombreUsuarioOEmail + ") " + ex.Message+ex.StackTrace;
                oLog.Add(msg);
                return null;
            }
        }

        public void ActualizarUsuario(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Usuario " + pNombreUsuario + " Actualizado con exito.";
                
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Nombre = nombre;
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Apellido = apellido;
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).FechaNacimiento = Convert.ToDateTime(pFechaNacimiento);
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Mail = mail;
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Telefono = telefono;
                    unitOfWork.Complete();
                }
                oLog.Add(msg);
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el usuario (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                oLog.Add(msg);

            }
        }

        public bool AñadirAdministrador(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            UsuarioAdministrador usuario = new UsuarioAdministrador(nombre, apellido, fechaNacimiento, mail, contraseña, telefono, pNombreUsuario);
            try
            {
                msg = "Administrador " + pNombreUsuario + " registrado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {unitOfWork.RepositorioAdministradores.Add(usuario);
                unitOfWork.Complete();
                }
                oLog.Add(msg);
                return true;
        }
                catch (Exception ex)
            {
                msg = "Error al Registrar el administrador (" + pNombreUsuario + ") " + ex.Message + ex.StackTrace;
                oLog.Add(msg);
                return false;

            }
        }

        public List<Ejemplar> ObtenerEjemplaresEnBuenEstadoLibro(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            List<Ejemplar> lista = new List<Ejemplar>(); 
            try
            {
                msg = "lista de ejemplares del libro (id libro: "+id+")en buen estado obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresEnBuenEstado();
                }
                

            }
            catch (Exception ex)
            {
                msg = "Error al obtener lista de ejemplares en buen estado del libro (id libro: " + id + ")" + ex.Message + ex.StackTrace;
                
            }
            oLog.Add(msg);
            return lista;
        }

        public UsuarioAdministrador ObtenerAdministrador(string pNombreUsuarioOEmail)
        {
            UsuarioAdministrador administrador = new UsuarioAdministrador();
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Administrador " + pNombreUsuarioOEmail + " Obtenido con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    administrador= unitOfWork.RepositorioAdministradores.Get(pNombreUsuarioOEmail);
                }

            }
            catch (Exception ex)
            {
                msg = "Error al obtener el administrador (" + pNombreUsuarioOEmail + " ) " + ex.Message + ex.StackTrace;
               
            }
            oLog.Add(msg);
            return administrador;
        }
        public void ActualizarAdministrador(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Administrador " + pNombreUsuario + " actualizado con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Nombre = nombre;
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Apellido = apellido;
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).FechaNacimiento = Convert.ToDateTime(pFechaNacimiento);
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Mail = mail;
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Telefono = telefono;
                    unitOfWork.Complete();
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el administrador (" + pNombreUsuario + " ) " + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);

        }
        public void ActualizarContraseñaAdministrador(string pNombreUsuario, string contraseña)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Contraseña del administrador " + pNombreUsuario + " actualizada con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Pass = contraseña;
                    unitOfWork.Complete();
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar la contraseña del administrador (" + pNombreUsuario + " ) " + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);


        }

        public void AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion, int pCantidadEjempalares)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Libro ( Titulo: "+titulo+" Autor: "+autor+" ISBN:" + unISBN + " ) registrado con exito.";
                Libro libro = new Libro(unISBN, titulo, autor, añoPublicacion);
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    unitOfWork.RepositorioLibros.Add(libro);
                    for (int i = 0; i < pCantidadEjempalares; i++)
                    {
                        Ejemplar ejemplarNuevo = new Ejemplar(libro);
                        unitOfWork.RepositorioEjemplares.Add(ejemplarNuevo);
                    }
                    unitOfWork.Complete();
                }
            }
            catch ( Exception ex)
            {

                msg = "Error al registrar el libro ( Titulo: " + titulo + " Autor: " + autor + " ISBN:" + unISBN + " ) ." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);
        }
        public Libro ObtenerLibro(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            Libro libro = new Libro();
            try
            {
                msg = "Libro (Id: " + id + " ) Obtenido con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                     libro = unitOfWork.RepositorioLibros.Get(id);
                    unitOfWork.Complete();
                   
                }
            }
            catch (Exception ex )
            {
                msg = "Error al obtener el libro (Id: " + id + " ) ." + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);
            return libro;
        }


        public int ObtenerCantEjemplaresLibro(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            int cant = 0;
            try
            {
                msg = "Cantidad de ejemplares del Libro (Id: " + id + " ) Obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    cant= unitOfWork.RepositorioLibros.Get(id).Ejemplares.Count();
                }
            }
            catch (Exception ex)
            {

                msg = "Error al obtener la cantidad de ejemplares del libro (Id: " + id + " ) ." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);
            return cant;
            
        }

        public void AñadirEjemplares(int pIdLibro, int pCantidad)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = ("Ejemplares Añadidos a libro con exito (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ").");
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    for (int i = 1; i <= pCantidad; i++)
                    {
                        Ejemplar ejemplar = new Ejemplar(unitOfWork.RepositorioLibros.Get(pIdLibro));
                        unitOfWork.RepositorioEjemplares.Add(ejemplar);
                    }
                    unitOfWork.Complete();
                }
            }

            catch (Exception ex)
            {
                msg = "Error al Añadir ejemplares a libro (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ")." + ex.Message + ex.StackTrace;


            }
            oLog.Add(msg);
           
        }

        public void EliminarEjemplaresDeUnLibro(int pIdLibro, int pCantidad)
        {ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = ("Ejemplares del libro eliminados con exito (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ").");
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioLibros.Get(pIdLibro).EliminarEjemplares(pCantidad);
                unitOfWork.Complete();
            }
            }

            catch (Exception ex)
            {
                msg = "Error al eliminar ejemplares del libro (ID LIbro: " + pIdLibro + " Cantidad: " + pCantidad + ")." + ex.Message + ex.StackTrace;


            }
            oLog.Add(msg);
        }

        public void DarDeBajaUnLibro(int pIdLibro)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {  msg="Libro Dado de baja con exito (Id: "+pIdLibro+").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    Libro libro = unitOfWork.RepositorioLibros.Get(pIdLibro);
                    libro.DarDeBaja();
                    unitOfWork.Complete();
                }
            }
            catch (Exception ex)
            {

                msg = "Error al dar de baja el libro (Id: " + pIdLibro + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);
        }

        public void DarDeAltaUnLibro(int pIdLibro)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Libro Dado de alta con exito (Id: " + pIdLibro + ").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioLibros.Get(pIdLibro).DarDeAlta();
                unitOfWork.Complete();
            }

            }
            catch (Exception ex)
            {

                msg = "Error al dar de alta el libro (Id: " + pIdLibro + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);
        }
        public void ActualizarEjemplar(string idLibro, string estado)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Ejemplar actualizado con exito (Id libro: " + idLibro + " Estado: " + estado + ")";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    if (estado == "Bueno")
                    {
                        unitOfWork.RepositorioEjemplares.Get(Convert.ToInt32(idLibro)).Estado = EstadoEjemplar.Bueno;
                    }
                    else
                    {
                        unitOfWork.RepositorioEjemplares.Get(Convert.ToInt32(idLibro)).Estado = EstadoEjemplar.Malo;
                    }

                    unitOfWork.Complete();
                }
            }
            catch (Exception ex)
            {
                msg = "Error al actualizar el Ejemplar (Id libro: " + idLibro + " Estado: " + estado + ")" + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);
        }
        public Ejemplar ObtenerEjemplar(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            Ejemplar ejemplar = new Ejemplar();
            try
            {
                msg = "Ejemplar (Id: " + id + " ) Obtenido con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    ejemplar= unitOfWork.RepositorioEjemplares.Get(id);
                }
            }
            catch (Exception ex )
            {
                msg = "Error al obtener el ejemplar (Id: " + id + " ) ." + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);
            return ejemplar;

        }
        public List<Ejemplar> ObtenerEjemplaresDisponibles(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            List<Ejemplar> lista = new List<Ejemplar>();
            try
            {
                msg = "Lista de ejemplares Disponibles del libro (id: " + id + ") obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresDisponibles();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista de ejemplares Disponibles del libro (id: " + id + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);
            return lista;
        }

        public List<Ejemplar> ObtenerEjemplaresTotales(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            List<Ejemplar> lista = new List<Ejemplar>();
            try
            {
                msg = "Lista de ejemplares total del libro (id: " + id + ") obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                 lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresTotales();
               
            }
            }
            catch (Exception ex)
            {
                msg = "Error al obtener la lista total de ejemplares del libro (id: " + id + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);
            return lista;
        }

        public void RegistrarPrestamo(string pNombreUsuario, int idEjemplar, int idLibro)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Prestamo registrado con exito (idLibro: " + idLibro + "Id Ejemplar: "+idEjemplar+" Usuario: "+pNombreUsuario+") obtenida con exito.";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    Prestamo prestamo = new Prestamo(unitOfWork.RepositorioUsuarios.Get(pNombreUsuario), unitOfWork.RepositorioEjemplares.Get(idEjemplar), unitOfWork.RepositorioLibros.Get(idLibro));

                    unitOfWork.RepositorioEjemplares.Get(idEjemplar).Disponible = false;
                    unitOfWork.RepositorioPrestamos.Add(prestamo);
                    unitOfWork.Complete();
                }
            }
            catch ( Exception ex)
            {
                msg = "Error al registrar el Prestamo  (idLibro: " + idLibro + "Id Ejemplar: " + idEjemplar + " Usuario: " + pNombreUsuario + ") ." + ex.Message + ex.StackTrace;

            }
            oLog.Add(msg);
        }
        public Prestamo ObtenerPrestamo(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            Prestamo prestamo = new Prestamo();
            try
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    msg = "Prestamo (Id: " + id + ") Obtenido con exito.";
                    prestamo=unitOfWork.RepositorioPrestamos.Get(id);
                }
            }
            catch (Exception ex)
            {

                msg = "Error al obtener el prestamo (Id: "+ id + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);
            return prestamo;
        }

        public void ActualizarLibro(int id, string unISBN, string titulo, string autor, string añoPublicacion)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Libro actualizado con exito (Id: " + id + ").";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    unitOfWork.RepositorioLibros.Get(id).ISBN = unISBN;
                    unitOfWork.RepositorioLibros.Get(id).Titulo = titulo;
                    unitOfWork.RepositorioLibros.Get(id).Autor = autor;
                    unitOfWork.RepositorioLibros.Get(id).AñoPublicacion = añoPublicacion;
                    unitOfWork.Complete();
                }
            }
            catch (Exception ex)
            {

                msg = "Error al actualizar el libro (Id: " + id + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);
        }

        public UsuarioSimple ObtenerUsuarioDePrestamo(int id)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            UsuarioSimple usuario = new UsuarioSimple();
            try
            {
                msg = "Usuario de Prestamo obtenido con exito (Id Prestamo: " + id + ")." ;
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    usuario=unitOfWork.RepositorioPrestamos.Get(id).Usuario;
                }
            }
            catch (Exception ex)
            {

                msg = "Error al el usuario del prestamo (Id Prestamo: " + id + ")." + ex.Message + ex.StackTrace;
            }
            oLog.Add(msg);
            return usuario;
        }

        public void RegistrarDevolucion(int idPrestamo, string estado)
        {
            ArchivoDeLog oLog = new ArchivoDeLog();
            string msg;
            try
            {
                msg = "Devolucion de prestamo registrada exitosamente(Id Prestamo: " + idPrestamo + " Estado:" + estado + ")";
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    if (estado == "Bueno")
                    {
                        unitOfWork.RepositorioPrestamos.Get(idPrestamo).RegistrarDevolucion(EstadoEjemplar.Bueno);
                    }
                    else unitOfWork.RepositorioPrestamos.Get(idPrestamo).RegistrarDevolucion(EstadoEjemplar.Malo);


                    unitOfWork.Complete();
                }
            }
            catch (Exception ex)
            {

                msg = "Error al registrar la devolucion del prestamo (Id Prestamo: " + idPrestamo + " Estado:" + estado + ")";
            }
            oLog.Add(msg);
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
            return ObtenerAdministrador(pNombreUsuario).VerificarContraseña(contraseña);
        }
        public IEnumerable<UsuarioSimple> ObtenerUsuarios()
        { return GetUnitOfWork(implementacionBase).RepositorioUsuarios.GetAll(); }
        public IEnumerable<UsuarioAdministrador> ObtenerAdministradores()
        { return GetUnitOfWork(implementacionBase).RepositorioAdministradores.GetAll(); }
        public IEnumerable<Libro> ObtenerLibros()
        { return GetUnitOfWork(implementacionBase).RepositorioLibros.GetAll(); }
        public IEnumerable<Ejemplar> ObtenerEjemplares()
        { return GetUnitOfWork(implementacionBase).RepositorioEjemplares.GetAll(); }
        public IEnumerable<Prestamo> ObtenerPrestamos()
        { return GetUnitOfWork(implementacionBase).RepositorioPrestamos.GetAll(); }
        public List<Prestamo> ObtenerListadePrestamosProximosAVencerse()

        {
            List<Prestamo> lista = new List<Prestamo>();
            foreach (var item in GetUnitOfWork(implementacionBase).RepositorioPrestamos.GetAll())
            {
                if (item.ProximoAVencerse())
                {
                    lista.Add(item);
                }

            }
            return lista;
        }
        public List<Prestamo> ObtenerListadePrestamosRetrasados()

        {
            List<Prestamo> lista = new List<Prestamo>();
            foreach (var item in GetUnitOfWork(implementacionBase).RepositorioPrestamos.GetAll())
            {
                if (item.Retrasado())
                {
                    lista.Add(item);
                }
            }
            return lista;
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
            bool resultado;

            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                resultado = unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).ValidarBaja();
                if (resultado == true)
                {
                    unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Baja = true;
                }
                unitOfWork.Complete();
                return resultado;
            }


        }

        public bool DarDeBajaAdministrador(string pNombreUsuario)
        {
            if (pNombreUsuario == "admin")
            {
                return false;
            }
            else 
            {
                using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
                {
                    unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Baja = true;
                    unitOfWork.Complete();
                }
                return true;
            }
            
        }

        public void DarDeAltaUsuario(string pNombreUsuario)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                 unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Baja = false;
                 unitOfWork.Complete();
            }
        }

        public void DarDeAltaAdministrador(string pNombreUsuario)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                 unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Baja = false;
                 unitOfWork.Complete();
            }
        }
    }
}