using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTecnico
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ejercicio1_12sobre18_es2sobre3()
        {
            //Arrange
            var expected = "2/3";
            //Act
            var actual = Ejercicio1.SimplificarFraccion("12/18");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ejercicio1_12sobre1_es12()
        {
            var expected = "12";
            var actual = Ejercicio1.SimplificarFraccion("12/1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ejercicio1_5sobre5_es1()
        {
            var expected = "1";
            var actual = Ejercicio1.SimplificarFraccion("5/5");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ejercicio2_EAllanPoe_fails()
        {
            //Arrange
            var expected = false;
            //Act
            var actual = Ejercicio2.ValidName("E. Allan Poe");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ejercicio2_EdgarAPoe_fails()
        {
            //Arrange
            var expected = false;
            //Act
            var actual = Ejercicio2.ValidName("Edgar A Poe");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ejercicio2_EdgarAPoe_passes()
        {
            //Arrange
            var expected = true;
            //Act
            var actual = Ejercicio2.ValidName("Edgar A. Poe");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ejercicio2_Edgar_APoe_fails()
        {
            //Arrange
            var expected = false;
            //Act
            var actual = Ejercicio2.ValidName("Edgar. A. Poe");
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
