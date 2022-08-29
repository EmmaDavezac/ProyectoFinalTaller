using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dominio.Tests
{
    [TestClass]
    public class UsuarioAdministradorTests
    {
        [TestMethod]
        public void VerificarContraseña_CaminoExitoso_Test1()
        {
            //Arange 
            UsuarioAdministrador unAdmin = new UsuarioAdministrador("", "", new DateTime(2000, 2, 2), "", "abc123","","");
            string pass = "abc123";
            //Act
            bool resultado = unAdmin.VerificarContraseña(pass);

            //Assert
            Assert.AreEqual(true, resultado);
        }
    }
}
