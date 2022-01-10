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
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                ArchivoDeLog oLog = new ArchivoDeLog();
                string msg;
                try
                {
                    msg = "Usuario " + pNombreUsuario + " Registrado con exito.";
                    unitOfWork.RepositorioUsuarios.Add(usuario);
                    unitOfWork.Complete();
                    
                    oLog.Add(msg);
                    return true;
                }
                catch (Exception ex)
                {
                    msg = "Error al registrar usuario (" + nombre + "-" + apellido + ") " + ex;
                    
                    oLog.Add(msg);
                    return false;
  
                }
                
            }
        }

        public UsuarioSimple ObtenerUsuario(string pNombreUsuarioOEmail)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioUsuarios.Get(pNombreUsuarioOEmail);
            }
        }

        public void ActualizarUsuario(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Nombre = nombre;
                unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Apellido = apellido;
                unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).FechaNacimiento = Convert.ToDateTime(pFechaNacimiento);
                unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Mail = mail;
                unitOfWork.RepositorioUsuarios.Get(pNombreUsuario).Telefono = telefono;
                unitOfWork.Complete();
            }
        }

        public bool AñadirAdministrador(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono)
        {
            UsuarioAdministrador usuario = new UsuarioAdministrador(nombre, apellido, fechaNacimiento, mail, contraseña, telefono, pNombreUsuario);
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                try
                {
                    unitOfWork.RepositorioAdministradores.Add(usuario);
                    unitOfWork.Complete();
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
                return true;
            }
        }

        public List<Ejemplar> ObtenerEjemplaresEnBuenEstadoLibro(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioLibros.Get(id).EjemplaresEnBuenEstado();
            }
        }

        public UsuarioAdministrador ObtenerAdministrador(string pNombreUsuarioOEmail)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioAdministradores.Get(pNombreUsuarioOEmail);
            }
        }
        public void ActualizarAdministrador(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
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
        public void ActualizarContraseñaAdministrador(string pNombreUsuario, string contraseña)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioAdministradores.Get(pNombreUsuario).Pass = contraseña;

                unitOfWork.Complete();
            }
        }

        public void AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion, int pCantidadEjempalares)
        {
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
        public Libro ObtenerLibro(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                Libro libro = unitOfWork.RepositorioLibros.Get(id);
                unitOfWork.Complete();
                return libro;
            }
        }


        public int ObtenerCantEjemplaresLibro(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioLibros.Get(id).Ejemplares.Count();
            }
        }

        public void AñadirEjemplares(int pIdLibro, int pCantidad)
        {

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

        public void EliminarEjemplaresDeUnLibro(int pIdLibro, int pCantidad)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioLibros.Get(pIdLibro).EliminarEjemplares(pCantidad);
                unitOfWork.Complete();
            }
        }

        public void DarDeBajaUnLibro(int pIdLibro)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                Libro libro = unitOfWork.RepositorioLibros.Get(pIdLibro);
                libro.DarDeBaja();
                unitOfWork.Complete();
            }
        }

        public void DarDeAltaUnLibro(int pIdLibro)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioLibros.Get(pIdLibro).DarDeAlta();
                unitOfWork.Complete();
            }
        }
        public void ActualizarEjemplar(string idLibro, string estado)
        {
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
        public Ejemplar ObtenerEjemplar(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioEjemplares.Get(id);
            }

        }
        public List<Ejemplar> ObtenerEjemplaresDisponibles(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                List<Ejemplar> lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresDisponibles();
                return lista;
            }
        }

        public List<Ejemplar> ObtenerEjemplaresTotales(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                List<Ejemplar> lista = unitOfWork.RepositorioLibros.Get(id).EjemplaresTotales();
                return lista;
            }
        }

        public void RegistrarPrestamo(string pNombreUsuario, int idEjemplar, int idLibro)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                Prestamo prestamo = new Prestamo(unitOfWork.RepositorioUsuarios.Get(pNombreUsuario), unitOfWork.RepositorioEjemplares.Get(idEjemplar), unitOfWork.RepositorioLibros.Get(idLibro));

                unitOfWork.RepositorioEjemplares.Get(idEjemplar).Disponible = false;
                unitOfWork.RepositorioPrestamos.Add(prestamo);
                unitOfWork.Complete();
            }
        }
        public Prestamo ObtenerPrestamo(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioPrestamos.Get(id);
            }
        }

        public void ActualizarLibro(int id, string unISBN, string titulo, string autor, string añoPublicacion)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioLibros.Get(id).ISBN = unISBN;
                unitOfWork.RepositorioLibros.Get(id).Titulo = titulo;
                unitOfWork.RepositorioLibros.Get(id).Autor = autor;
                unitOfWork.RepositorioLibros.Get(id).AñoPublicacion = añoPublicacion;
                unitOfWork.Complete();
            }

        }

        public UsuarioSimple ObtenerUsuarioDePrestamo(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioPrestamos.Get(id).Usuario;
            }
        }

        public void RegistrarDevolucion(int idPrestamo, string estado)
        {
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