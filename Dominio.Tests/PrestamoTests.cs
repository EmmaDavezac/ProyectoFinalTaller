using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dominio.Tests
{
    [TestClass]
    public class PrestamoTests
    {
        /*[TestMethod] //No se puede testear por el nivel de proteccion
        public void CalcularFechaLimite_CaminoExitoso_Test1()  
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "",new DateTime(2000, 2, 2), "","","");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, unEjemplar, unLibro);
            
            //Act
            DateTime resultado = unPrestamo.CalcularFechaLimite();

            //Assert
            Assert.AreEqual("a", resultado);
        }*/
        [TestMethod]
        public void Retrasado_CaminoExitoso_Test1()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, unEjemplar, unLibro);
            unPrestamo.FechaLimite = "2008, 2, 2";

            //Act
            bool resultado = unPrestamo.Retrasado();

            //Assert
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void ProximoAVencerse_CaminoExitoso_Test1()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, unEjemplar, unLibro);
            unPrestamo.FechaLimite = "2022, 3, 4";

            //Act
            bool resultado = unPrestamo.ProximoAVencerse();

            //Assert
            Assert.AreEqual(true, resultado);
        }
        /*[TestMethod] //No se puede testear por el nivel de protección
        public void CalcularScoring_CaminoExitoso_Test1() 
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "") { Scoring = 20 };
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro)
            { Estado = EstadoEjemplar.Malo };
            Prestamo unPrestamo = new Prestamo(unUsuario, unEjemplar, unLibro);

            //Act
            int resultado = unPrestamo.CalcularScoring(unUsuario);

            //Assert
            Assert.AreEqual(true, resultado);
        }*/
        [TestMethod]
        public void RegistrarDevolucion_CaminoExitoso_Test1()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);

            Prestamo unPrestamo = new Prestamo(unUsuario, unEjemplar, unLibro);
            EstadoEjemplar unEstado = EstadoEjemplar.Malo;

            //Act
            unPrestamo.RegistrarDevolucion(unEstado);

            //Assert
            Assert.AreEqual(true, unEjemplar.Baja);
        }
    }
}
