using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.EntityFramework;//libreria de implementacion de IUnitOfWork con entityFramework
using Dominio;
using ServiciosAPILibros;
using NotificacionAUsuario;
namespace Nucleo
{
     public class InterfazNucleo
    {
        static string[] implementacionesBase = new string[] { "ConnectionSQLServerLocal", "ConnectionSQLServerHosting" };//cadenas de conexion a bases de datos
        static private string implementacionBase = implementacionesBase[1];
        static string[] implementacionesAPILibros = new string[] { "OpenLibrary" };
        static private string implementacionAPILibros = implementacionesAPILibros[0];
        static string[] implementacionesNotificar = new string[] { "MailOutlook" };
        static private string implementacionNotificar= implementacionesBase[0];
        private IUnitOfWork GetUnitOfWork(string pCadenaConexion)//implementaciones posibles para las base de datos, interactua con la interfaz IUnitOfWork, esta abtraccion nos permite poder trabajar con distintas implementaciones
        {
            switch (pCadenaConexion)
            {
                case "ConnectionSQLServerHosting": { return new UnitOfWork(new AdministradorDePrestamosDbContext(pCadenaConexion)); }//implementacion en una base de datos relacional de SQLServer con hosting en un servidor proporcionado por  la web https://www.smarterasp.net/
                case "ConnectionSQLServerLocal": { return new UnitOfWork(new AdministradorDePrestamosDbContext(pCadenaConexion)); }//implementacion en una base de datos relacional de SQLServer en un servidor local de MSQLSERVER
                default: { return new UnitOfWork(new AdministradorDePrestamosDbContext(implementacionesBase[0])); }//implementacion por defecto,implementacion en una base de datos relacional de SQLServer en un servidor local de MSQLSERVER

            }
        }
        private IServiciosAPILibros GetIServiciosAPILibros(string unIServiciosAPILibros)///Implementacion posibles para la api que nos brinda informacion sobre libros, interactua con la interfaz IAPIlibros, esta abtraccion nos permite poder trabajar con distintas implementaciones
        {
            switch (unIServiciosAPILibros)
            {
                case "APIOpenLibrary": { return new APIOpenLibrary(); }//implementacion con OpenLibrary
                default:
                    { return new APIOpenLibrary(); }//implementacion por defecto, implemetacion con OpenLibrery

            }
        }
        private INotificarUsuario GetNotificarUsuario(string unNotificarCliente)
        {
            switch (unNotificarCliente)
            {
                case "MailOutlook": { return new EnviarMailOutlook(); }
                default:
                    { return new EnviarMailOutlook(); }

            }
        }    

        public InterfazNucleo()
        {
        }
        public void AñadirUsuario(string nombre, string apellido, DateTime fechaNacimiento, string mail,string telefono)
        {
            UsuarioSimple usuario = new UsuarioSimple(nombre, apellido, fechaNacimiento, mail,telefono);
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioUsuarios.Add(usuario);
                unitOfWork.Complete();
            }
        }
        public UsuarioSimple ObtenerUsuario(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioUsuarios.Get(id);
            }
        }
        public void ActualizarUsuario(string idUsuario, string nombre, string apellido, string mail,string telefono)
        {
            int id = Convert.ToInt32(idUsuario);
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioUsuarios.Get(id).Nombre = nombre;
                unitOfWork.RepositorioUsuarios.Get(id).Apellido = apellido;
                unitOfWork.RepositorioUsuarios.Get(id).Mail = mail;
                unitOfWork.RepositorioUsuarios.Get(id).Telefono = telefono;
                unitOfWork.Complete();
            }
        }

         public void AñadirAdministrador(string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña,string telefono)
        {
            UsuarioAdministrador usuario = new UsuarioAdministrador(nombre, apellido, fechaNacimiento, mail, contraseña,telefono);
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioAdministradores.Add(usuario);
                unitOfWork.Complete();
            }
        }
        public UsuarioAdministrador ObtenerAdministrador(int id)
        {

            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioAdministradores.Get(id);
            }
        }
        public void ActualizarAdministrador(string idAdministrador, string nombre, string apellido, string mail,string telefono)
        {
            int id = Convert.ToInt32(idAdministrador);
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioAdministradores.Get(id).Nombre = nombre;
                unitOfWork.RepositorioAdministradores.Get(id).Apellido = apellido;
                unitOfWork.RepositorioAdministradores.Get(id).Mail = mail;
                unitOfWork.RepositorioAdministradores.Get(id).Telefono = telefono;
                unitOfWork.Complete();
            }
        }
        public void ActualizarContraseñaAdministrador(string idAdministrador, string contraseña)
        {
            int id = Convert.ToInt32(idAdministrador);
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioAdministradores.Get(id).Pass = contraseña;

                unitOfWork.Complete();
            }
        }

        public void AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion)
        {
            Libro libro = new Libro(unISBN, titulo, autor, añoPublicacion);
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                unitOfWork.RepositorioLibros.Add(libro);
                unitOfWork.Complete();
            }
        }
        public Libro ObtenerLibro(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioLibros.Get(id);
            }
        }


        public void AñadirEjemplar(int idLibro, string estado)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                Ejemplar ejemplar = new Ejemplar(unitOfWork.RepositorioLibros.Get(idLibro), estado);
                unitOfWork.RepositorioEjemplares.Add(ejemplar);
                unitOfWork.RepositorioLibros.Get(idLibro).Ejemplares.Add(ejemplar);
                unitOfWork.Complete();
            }
        }
        public void ActualizarEjemplar(string idLibro, string estado)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                if (estado=="Bueno")
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
        public Libro ObtenerLibroDeEjemplar(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioEjemplares.Get(id).Libro;
            }
        }
        public void RegistrarPrestamo(int idUsuario, int idEjemplar)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                Prestamo prestamo = new Prestamo(unitOfWork.RepositorioUsuarios.Get(idUsuario), unitOfWork.RepositorioEjemplares.Get(idEjemplar));

                unitOfWork.RepositorioEjemplares.Get(idEjemplar).Disponible = false;
                unitOfWork.RepositorioPrestamos.Add(prestamo);
                unitOfWork.RepositorioUsuarios.Get(idUsuario).Prestamos.Add(prestamo);
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
        public Libro ObtenerLibroDePrestamo(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioPrestamos.Get(id).Ejemplar.Libro;
            }
        }
        public Ejemplar ObtenerEjemplarDePrestamo(int id)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                return unitOfWork.RepositorioPrestamos.Get(id).Ejemplar;
            }
        }

        public bool VerficarContraseña(int id, string contraseña)
        {
            return ObtenerAdministrador(id).VerificarContraseña(contraseña);
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

        public int ObtenerUltimoIdUsuario()

        { return ObtenerUsuarios().Last().Id; }
         public int ObtenerUltimoIdAdministrador()

        { return ObtenerAdministradores().Last().Id; }
        public int ObtenerUltimoIdLibro()

        { return ObtenerLibros().Last().Id; }
        public int ObtenerUltimoIdEjemplar()

        { return ObtenerEjemplares().Last().Id; }
        public int ObtenerUltimoIdPrestamo()

        { return ObtenerPrestamos().Last().Id; }
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

        public List<Libro> ListarLibrosDeAPIPorCoincidencia(string unaCadena)
        { return GetIServiciosAPILibros(implementacionAPILibros).ListaPorCoincidecia(unaCadena); }
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

        public void NotificarUsuario(int idUsuario)
        { 
            GetNotificarUsuario(implementacionNotificar).Notificar(ObtenerUsuario(idUsuario));

        }
        public void NotificarPrestamosProximosAVencer()
        {
            foreach (var item in ObtenerListadePrestamosProximosAVencerse())
            {
                UsuarioSimple usuario = ObtenerUsuarioDePrestamo(item.Id);
                NotificarUsuario(usuario.Id);
            } }

    }    
}
