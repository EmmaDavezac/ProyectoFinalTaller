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
        private InterfazDAL interfazDAL = new InterfazDAL();
        private InterfazAPILibros interfazAPILibros = new InterfazAPILibros();
        private InterfazNotificarUsuario interfazNotificarUsuario = new InterfazNotificarUsuario();       
        private IServiciosAPILibros GetIServiciosAPILibros(string unIServiciosAPILibros)///Implementacion posibles para la api que nos brinda informacion sobre libros, interactua con la interfaz IAPIlibros, esta abtraccion nos permite poder trabajar con distintas implementaciones
        {
            return interfazAPILibros.GetIServiciosAPILibros(unIServiciosAPILibros);
        }
        private INotificarUsuario GetNotificarUsuario(string unNotificarCliente)
        {
            return interfazNotificarUsuario.GetNotificarUsuario(unNotificarCliente);
        }

        public InterfazNucleo()
        {
        }
        public bool AñadirUsuario(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono)
        {
            return interfazDAL.AñadirUsuario(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), fechaNacimiento, mail, telefono);
        }
        public UsuarioSimple ObtenerUsuarioPorId(int id)
        {
            return interfazDAL.ObtenerUsuarioPorId(id);
        }

        public UsuarioSimple ObtenerUsuarioPorNombreOMail(string pNombreUsuarioOEmail)
        {
            return interfazDAL.ObtenerUsuarioPorNombreOMail(pNombreUsuarioOEmail);
        }

        public void ActualizarUsuario(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            interfazDAL.ActualizarUsuario(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), pFechaNacimiento,mail, telefono);
        }

        public bool AñadirAdministrador(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono)
        {
            return interfazDAL.AñadirAdministrador(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), fechaNacimiento, mail, contraseña, telefono);
        }
        public UsuarioAdministrador ObtenerAdministradorPorId(int id)
        {
            return interfazDAL.ObtenerAdministradorPorId(id);
        }

        public UsuarioAdministrador ObtenerAdministradorPorNombreOMail(string pNombreUsuarioOEmail)
        {
            return interfazDAL.ObtenerAdministradorPorNombreOMail(pNombreUsuarioOEmail);
        }
        public void ActualizarAdministrador(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            interfazDAL.ActualizarAdministrador(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), pFechaNacimiento, mail, telefono);
        }
        public void ActualizarContraseñaAdministrador(string idAdministrador, string contraseña)
        {
            interfazDAL.ActualizarContraseñaAdministrador(idAdministrador, contraseña);
        }

        public void AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion,int pCantidadEjempalares)
        {
            interfazDAL.AñadirLibro(unISBN, titulo, autor, añoPublicacion, pCantidadEjempalares);
        }
        public Libro ObtenerLibro(int id)
        {
            return interfazDAL.ObtenerLibro(id);
        }
        public int ObtenerCantidadEjemplaresLibro(int id)
        {
            return interfazDAL.ObtenerCantEjemplaresLibro(id);
        }


        public void AñadirEjemplar(int idLibro)
        {
            interfazDAL.AñadirEjemplar(idLibro);
        }
        public void ActualizarEjemplar(string idLibro, string estado)
        {
            interfazDAL.ActualizarEjemplar(idLibro, estado);
        }
        public Ejemplar ObtenerEjemplar(int id)
        {
            return interfazDAL.ObtenerEjemplar(id);

        }
        public List<Ejemplar> ObtenerEjemplaresDisponibles(int id)
        {
            return interfazDAL.ObtenerEjemplaresDisponibles(id);
        }
        public Libro ObtenerLibroDeEjemplar(int id)
        {
            return interfazDAL.ObtenerLibroDeEjemplar(id);
        }
        public void RegistrarPrestamo(int idUsuario, int idEjemplar)
        {
            interfazDAL.RegistrarPrestamo(idUsuario, idEjemplar);
        }
        public Prestamo ObtenerPrestamo(int id)
        {
            return interfazDAL.ObtenerPrestamo(id);
        }

        public void ActualizarLibro(int id, string unISBN, string titulo, string autor, string añoPublicacion)
        {
            interfazDAL.ActualizarLibro(id, unISBN, titulo, autor, añoPublicacion);
        }

        public UsuarioSimple ObtenerUsuarioDePrestamo(int id)
        {
            return interfazDAL.ObtenerUsuarioDePrestamo(id);
        }

        public void RegistrarDevolucion(int idPrestamo, string estado)
        {
            interfazDAL.RegistrarDevolucion(idPrestamo, estado);
        }
        public Libro ObtenerLibroDePrestamo(int id)
        {
            return interfazDAL.ObtenerLibroDePrestamo(id);
        }
        public Ejemplar ObtenerEjemplarDePrestamo(int id)
        {
            return interfazDAL.ObtenerEjemplarDePrestamo(id);
        }

        public bool VerficarContraseña(string pNombreUsuario, string contraseña)
        {
            return interfazDAL.VerficarContraseña(pNombreUsuario, contraseña);
        }
        public IEnumerable<UsuarioSimple> ObtenerUsuarios()
        { return interfazDAL.ObtenerUsuarios(); }
        public IEnumerable<UsuarioAdministrador> ObtenerAdministradores()
        { return interfazDAL.ObtenerAdministradores(); }
        public IEnumerable<Libro> ObtenerLibros()
        { return interfazDAL.ObtenerLibros(); }
        public IEnumerable<Ejemplar> ObtenerEjemplares()
        { return interfazDAL.ObtenerEjemplares(); }
        public IEnumerable<Prestamo> ObtenerPrestamos()
        { return interfazDAL.ObtenerPrestamos(); }

        public string ObtenerUltimoIdUsuario()

        { return ObtenerUsuarios().Last().NombreUsuario; }
        public string ObtenerUltimoIdAdministrador()

        { return ObtenerAdministradores().Last().NombreUsuario; }
        public int ObtenerUltimoIdLibro()

        { return ObtenerLibros().Last().Id; }
        public int ObtenerUltimoIdEjemplar()

        { return ObtenerEjemplares().Last().Id; }
        public int ObtenerUltimoIdPrestamo()

        { return ObtenerPrestamos().Last().Id; }
        public List<Prestamo> ObtenerListadePrestamosProximosAVencerse()

        {
            return interfazDAL.ObtenerListadePrestamosProximosAVencerse();
        }
        public List<Prestamo> ObtenerListadePrestamosRetrasados()
        {
            return interfazDAL.ObtenerListadePrestamosRetrasados();
        }

        public List<Libro> ListarLibrosDeAPIPorCoincidencia(string unaCadena)
        { return interfazAPILibros.ListarLibrosDeAPIPorCoincidencia(unaCadena); }
        public bool EsUnEmailValido(string email)
        {
            return interfazDAL.EsUnEmailValido(email);
        }

        public void NotificarUsuario(string pNombreUsuario)
        {
            interfazNotificarUsuario.NotificarUsuario(ObtenerUsuarioPorNombreOMail(pNombreUsuario));
        }
        public string MayusculaPrimeraLetra(string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;
            char[] letters = source.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
        public void NotificarPrestamosProximosAVencer()
        {
            foreach (var item in ObtenerListadePrestamosProximosAVencerse())
            {
                UsuarioSimple usuario = ObtenerUsuarioDePrestamo(item.Id);
                NotificarUsuario(usuario.NombreUsuario);
            }
        }

        public List<string> TransformarISBNsALista(string pLista)
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
        public List<string> TransformarAñosALista(string pLista)
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
        {
            if (pLista == "desconocido")
            {
                return "Desconocido";
            }
            else
            {
                return TransformarISBNsALista(pLista).First();
            }
        }
    }
}