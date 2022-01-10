using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Dominio;
using ServiciosAPILibros;
using NotificacionAUsuario;
using Bitacora;

namespace Nucleo
{
    public class InterfazNucleo//Fachada principal del proxima que nos permite usar las funciones del programa sin dar a conocer como funcionan por dentro
    {
        private InterfazDAL interfazDAL = new InterfazDAL();
        private InterfazAPILibros interfazAPILibros = new InterfazAPILibros();
        private InterfazNotificarUsuario interfazNotificarUsuario = new InterfazNotificarUsuario();
        

        public InterfazNucleo()
        {
        }
        public bool AñadirUsuario(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono)
        {
      
              
                return interfazDAL.AñadirUsuario(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), fechaNacimiento, mail, telefono);

           
        }
        public UsuarioSimple ObtenerUsuario(string pNombreUsuarioOEmail)
        {
            return interfazDAL.ObtenerUsuario(pNombreUsuarioOEmail);
        }

        public void ActualizarUsuario(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            interfazDAL.ActualizarUsuario(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), pFechaNacimiento, mail, telefono);
        }

        public bool AñadirAdministrador(string pNombreUsuario, string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono)
        {
            return interfazDAL.AñadirAdministrador(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), fechaNacimiento, mail, contraseña, telefono);
        }

        public UsuarioAdministrador ObtenerAdministrador(string pNombreUsuarioOEmail)
        {
            return interfazDAL.ObtenerAdministrador(pNombreUsuarioOEmail);
        }
        public void ActualizarAdministrador(string pNombreUsuario, string nombre, string apellido, string pFechaNacimiento, string mail, string telefono)
        {
            interfazDAL.ActualizarAdministrador(pNombreUsuario, MayusculaPrimeraLetra(nombre), MayusculaPrimeraLetra(apellido), pFechaNacimiento, mail, telefono);
        }
        public void ActualizarContraseñaAdministrador(string idAdministrador, string contraseña)
        {
            interfazDAL.ActualizarContraseñaAdministrador(idAdministrador, contraseña);
        }

        public void AñadirLibro(string unISBN, string titulo, string autor, string añoPublicacion, int pCantidadEjempalares)
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
        public List<Ejemplar> ObtenerEjemplaresEnBuenEstadoLibro(int id)
        {
            return interfazDAL.ObtenerEjemplaresEnBuenEstadoLibro(id);
        }

        public void AñadirEjemplares(int idLibro, int pCantidad)
        {
            interfazDAL.AñadirEjemplares(idLibro, pCantidad);
        }
        public void EliminarEjemplaresDeUnLibro(int idLibro, int pCantidad)
        {
            interfazDAL.EliminarEjemplaresDeUnLibro(idLibro, pCantidad);
        }
        public void DarDeBajaUnLibro(int pIdLibro)
        {
            interfazDAL.DarDeBajaUnLibro(pIdLibro);
        }
        public void DarDeAltaUnLibro(int pIdLibro)
        {
            interfazDAL.DarDeAltaUnLibro(pIdLibro);
        }
        public void ActualizarEjemplar(string idLibro, string estado)
        {
            interfazDAL.ActualizarEjemplar(idLibro, estado);
        }

        public List<Ejemplar> ObtenerEjemplaresDisponibles(int id)
        {
            return interfazDAL.ObtenerEjemplaresDisponibles(Convert.ToInt32(id));
        }

        public List<Ejemplar> ObtenerEjemplaresTotales(int id)
        {
            return interfazDAL.ObtenerEjemplaresTotales(id);
        }

        public void RegistrarPrestamo(string pNombreUsuario, int idEjemplar,int idLibro)
        {
            interfazDAL.RegistrarPrestamo(pNombreUsuario, idEjemplar,idLibro);
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

        public void ModificarFechasPrestamo(int pIdPrestamo, string pFechaPrestamo, string pFechaLimite)
        {
            interfazDAL.ModificarFechasPrestamo(pIdPrestamo, pFechaPrestamo, pFechaLimite);
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
        public int ObtenerUltimoIdLibro()

        { return ObtenerLibros().Last().Id; }
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

        public void NotificarProximoAVencer(string pNombreUsuario)
        {
            RegistrarLog(interfazNotificarUsuario.NotificarProximoAVencer(ObtenerUsuario(pNombreUsuario)));
        }
        public void NotificarRetraso(string pNombreUsuario)
        {
            RegistrarLog(interfazNotificarUsuario.NotificarRetraso(ObtenerUsuario(pNombreUsuario)));
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
                NotificarProximoAVencer(usuario.NombreUsuario);
            }
        }

        public void NotificarPrestamosRetrasados()
        {
            foreach (var item in ObtenerListadePrestamosRetrasados())
            {
                UsuarioSimple usuario = ObtenerUsuarioDePrestamo(item.Id);
                NotificarRetraso(usuario.NombreUsuario);
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
            else if (pLista == "Unknown")
            {
                return "Desconocido";
            }
            else
            {
                return TransformarISBNsALista(pLista).First();
            }
        }

        public void NotificarUsuarios()
        { if (DateTime.Now.Hour == 9)
            { NotificarPrestamosRetrasados();
                NotificarPrestamosProximosAVencer();
            }
        }

        public void RegistrarLog(string sLog)
        {

            ArchivoDeLog oLog = new ArchivoDeLog();
            oLog.Add(sLog);

        }

        public bool DarDeBajaUsuario(string pNombreUsuario)
        {
            return interfazDAL.DarDeBajaUsuario(pNombreUsuario);
        }

        public bool DarDeBajaAdministrador(string pNombreUsuario)
        {
            return interfazDAL.DarDeBajaAdministrador(pNombreUsuario);
        }

        public void DarDeAltaUsuario(string pNombreUsuario)
        {
            interfazDAL.DarDeAltaUsuario(pNombreUsuario);
        }

        public void DarDeAltaAdministrador(string pNombreUsuario)
        {
            interfazDAL.DarDeAltaAdministrador(pNombreUsuario);
        }
    }
}
