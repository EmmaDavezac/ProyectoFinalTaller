using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dominio.Tests
{
    [TestClass]
    public class EjemplarTests
    {
        [TestMethod]
        public void ObtenerTituloLibro_CaminoExitoso_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("", "a", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerTituloLibro();

            //Assert
            Assert.AreEqual("a", resultado);
        }
        [TestMethod]
        public void ObtenerTituloLibro_CaminoExitoso_Test2()
        {
            //Arange 
            Libro unLibro = new Libro("", "!", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerTituloLibro();

            //Assert
            Assert.AreEqual("!", resultado);
        }
        [TestMethod]
        public void ObtenerTituloLibro_CaminoExitoso_Test3()
        {
            //Arange 
            Libro unLibro = new Libro("", "hola", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerTituloLibro();

            //Assert
            Assert.AreEqual("hola", resultado);
        }
        [TestMethod]
        public void ObtenerTituloLibro_CaminoFallido_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("", "hola", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerTituloLibro();

            //Assert
            Assert.AreNotEqual("", resultado);
        }
        [TestMethod]
        public void ObtenerTituloLibro_CaminoFallido_Test2()
        {
            //Arange 
            Libro unLibro = new Libro("", "2", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerTituloLibro();

            //Assert
            Assert.AreNotEqual(2, resultado);
        }
        [TestMethod]
        public void ObtenerTituloLibro_CaminoFallido_Test3()
        {
            //Arange 
            Libro unLibro = new Libro("", "a", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerTituloLibro();

            //Assert
            Assert.AreNotEqual("!", resultado);
        }
        [TestMethod]
        public void ObtenerISBNLibro_CaminoExitoso_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("1", "", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerISBNLibro();

            //Assert
            Assert.AreEqual("1", resultado);
        }
        [TestMethod]
        public void ObtenerISBNLibro_CaminoExitoso_Test2()
        {
            //Arange 
            Libro unLibro = new Libro("a12", "", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerISBNLibro();
            //Assert
            Assert.AreEqual("a12", resultado);
        }
        [TestMethod]
        public void ObtenerISBNLibro_CaminoExitoso_Test3()
        {
            //Arange 
            Libro unLibro = new Libro("#$", "", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerISBNLibro();
            //Assert
            Assert.AreEqual("#$", resultado);
        }
        [TestMethod]
        public void ObtenerISBNLibro_CaminoFallido_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("1", "", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerISBNLibro();
            //Assert
            Assert.AreNotEqual(1, resultado);
        }
        [TestMethod]
        public void ObtenerISBNLibro_CaminoFallido_Test2()
        {
            //Arange 
            Libro unLibro = new Libro("123", "", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerISBNLibro();
            //Assert
            Assert.AreNotEqual("231", resultado);
        }
        [TestMethod]
        public void ObtenerISBNLibro_CaminoFallido_Test3()
        {
            //Arange 
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar ejemplar = new Ejemplar(unLibro);

            //Act
            string resultado = ejemplar.ObtenerISBNLibro();
            //Assert
            Assert.AreNotEqual("1", resultado);
        }
    }
}
