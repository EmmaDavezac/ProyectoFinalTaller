using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.EntityFramework;//libreria de implementacion de IUnitOfWork con entityFramework
using Dominio;
using ServiciosAPILibros;
namespace Nucleo
{
    public class InterfazNucleo
    {
        private const string implementacionBase = "EntityFramework";
        private const string implementacionAPILibros = "OpenLibrary";
        private IUnitOfWork GetUnitOfWork(string unIUnit)
        {
            switch (unIUnit)
            {
                case "EntiryFramework": { return new UnitOfWork(new AdministradorDePrestamosDbContext()); }//implementacion con entityframework
                default:
                    { return new UnitOfWork(new AdministradorDePrestamosDbContext()); }//implementacion por defecto

            }
        }
        private IServiciosAPILibros GetIServiciosAPILibros(string unIServiciosAPILibros)
        {
            switch (unIServiciosAPILibros)
            {
                case "APIOpenLibrary": { return new APIOpenLibrary(); }//implementacion con OpenLibrary
                default:
                    { return new APIOpenLibrary(); }//implementacion por defecto

            }
        }

        public InterfazNucleo()
        {
        }
        public void AñadirUsuario(string nombre, string apellido, DateTime fechaNacimiento, string mail)
        {
            UsuarioSimple usuario = new UsuarioSimple(nombre, apellido, fechaNacimiento, mail);
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
        public void AñadirAdministrador(string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña)
        {
            UsuarioAdministrador usuario = new UsuarioAdministrador(nombre, apellido, fechaNacimiento, mail, contraseña);
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
        public void AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion)
        {
            Libro libro = new Libro(unISBN, titulo,  autor, añoPublicacion);
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
            { Ejemplar ejemplar = new Ejemplar ( unitOfWork.RepositorioLibros.Get(idLibro), estado);
                unitOfWork.RepositorioEjemplares.Add(ejemplar);
                    unitOfWork.RepositorioLibros.Get(idLibro).Ejemplares.Add(ejemplar);
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
        public void RegistrarPrestamo(int idUsuario,int idEjemplar)
        {
            using (IUnitOfWork unitOfWork = GetUnitOfWork(implementacionBase))
            {
                Prestamo prestamo = new Prestamo (unitOfWork.RepositorioUsuarios.Get(idUsuario),unitOfWork.RepositorioEjemplares.Get(idEjemplar));

               unitOfWork.RepositorioEjemplares.Get(idEjemplar).Disponible=false;
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

        public List<Libro> ListarPorCoincidencia(string unaCadena)
        { return GetIServiciosAPILibros(implementacionAPILibros).ListaPorCoincidecia(unaCadena); }
    }

    
}
