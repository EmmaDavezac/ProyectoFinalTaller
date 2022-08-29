using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Dominio.Tests
{
    [TestClass]
    public class LibroTests
    {
        [TestMethod] //No se como testearlos
        public void EjemplaresDisponibles_CaminoExitoso_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            List<Ejemplar> original = new List<Ejemplar>();
            original.Add(ejemplar1);
            original.Add(ejemplar2);
            unLibro.Ejemplares.Add(ejemplar1);
            unLibro.Ejemplares.Add(ejemplar2);

            //Act
            List<Ejemplar> resultado = new List<Ejemplar>();
            resultado = unLibro.EjemplaresDisponibles();

            //Assert
            CollectionAssert.AreEqual(original, resultado);
        }
        [TestMethod]
        public void EjemplaresDisponibles_CaminoExitoso_Test2()
        {
            //Arange 
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            ejemplar1.Estado = EstadoEjemplar.Malo;
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            List<Ejemplar> original = new List<Ejemplar>();
            original.Add(ejemplar1);
            original.Add(ejemplar2);
            unLibro.Ejemplares.Add(ejemplar1);
            unLibro.Ejemplares.Add(ejemplar2);

            //Act
            List<Ejemplar> resultado = new List<Ejemplar>();
            resultado = unLibro.EjemplaresDisponibles();

            //Assert
            CollectionAssert.AreEqual(original, resultado);
        }
        [TestMethod]
        public void EjemplaresEnBuenEstado_CaminoExitoso_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            ejemplar1.Estado = EstadoEjemplar.Malo;
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            List<Ejemplar> original = new List<Ejemplar>() { /*ejemplar1,*/ ejemplar2 };
            unLibro.Ejemplares.Add(ejemplar1);
            unLibro.Ejemplares.Add(ejemplar2);
           
            //Act
            List<Ejemplar> resultado = unLibro.EjemplaresEnBuenEstado();

            //Assert
            CollectionAssert.AreEqual(original, resultado);
        }
        [TestMethod]
        public void EjemplaresTotales_CaminoExitoso_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            ejemplar2.Baja = true;
            List<Ejemplar> original = new List<Ejemplar>() { ejemplar1 };
            unLibro.Ejemplares.Add(ejemplar1);
            unLibro.Ejemplares.Add(ejemplar2);

            //Act
            List<Ejemplar> resultado = unLibro.EjemplaresTotales();

            //Assert
            CollectionAssert.AreEqual(original, resultado);
        }
        [TestMethod]
        public void EliminarEjemplares_CaminoExitoso_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            ejemplar1.Estado = EstadoEjemplar.Malo;
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            List<Ejemplar> original = new List<Ejemplar>() { ejemplar1, ejemplar2 };
            unLibro.Ejemplares.Add(ejemplar1);
            unLibro.Ejemplares.Add(ejemplar2);

            //Act
            unLibro.EliminarEjemplares(1);

            //Assert
            Assert.AreEqual(original.Count, unLibro.Ejemplares.Count);
        }
        [TestMethod]
        public void DarDeBaja_CaminoExitoso_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro) { Estado = EstadoEjemplar.Malo };           

            //Act
            unLibro.DarDeBaja();

            //Assert
            Assert.AreEqual(true, unLibro.Baja);
        }
        [TestMethod]
        public void DarDeBaja_CaminoExitoso_Test2()
        {
            //Arange 
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro) { Estado = EstadoEjemplar.Bueno };

            //Act
            unLibro.DarDeBaja();

            //Assert
            Assert.AreEqual(true, unLibro.Baja);
        }
        [TestMethod] //Por algún motivo no se da de baja.
        public void DarDeBaja_CaminoFallido_Test1()
        {
            //Arange 
            //UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            unLibro.DarDeBaja();

            //Act
            unLibro.DarDeBaja();

            //Assert
            Assert.AreEqual(false, unLibro.Baja);
        }
        [TestMethod]
        public void DarDeAlta_CaminoExitoso_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("123", "a", "b", "2000") { Baja = true };
            Ejemplar unEjemplar = new Ejemplar(unLibro);

            //Act
            unLibro.DarDeAlta();

            //Assert
            Assert.AreEqual(false, unLibro.Baja);
        }
        /*[TestMethod] 
        public void DarDeAlta_CaminoFallido_Test1()
        {
            //Arange 
            Libro unLibro = new Libro("123", "a", "b", "2000") { Baja = true };
            Ejemplar unEjemplar = new Ejemplar(unLibro) { Estado = EstadoEjemplar.Malo };
            unLibro.Ejemplares.Add(unEjemplar);

            //Act
            unLibro.DarDeAlta();

            //Assert
            Assert.AreEqual(false, unLibro.Baja);
        }*/
    }
}
