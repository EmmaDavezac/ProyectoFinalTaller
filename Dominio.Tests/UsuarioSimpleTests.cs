using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dominio.Tests
{
    [TestClass]
    public class UsuarioSimpleTests
    {
        [TestMethod]
        public void ValidarBaja_CaminoExitoso_Test1()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");

            //Act
            bool resultado = unUsuario.ValidarBaja();

            //Assert
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void ValidarBaja_CaminoFallido_Test1()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, unEjemplar, unLibro);

            //Act
            bool resultado = unUsuario.ValidarBaja();

            //Assert
            Assert.AreEqual(true, resultado);
        }
    }
}