using CalculadoraEntidad;

namespace testUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddCalculadoraRetorna0()
        {
            int a = Calculadora.Add("");
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void AddCalculadoraRetorna1()
        {
            int a = Calculadora.Add("1");
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void AddCalculadoraRetorna3()
        {
            int a = Calculadora.Add("1,2");
            Assert.AreEqual(3, a);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddCalculadoraRetornaException()
        {
            int a = Calculadora.Add("1,2,3");
            Assert.AreEqual(1, a);
        }

        //PARTE 2
        [TestMethod]
        public void AddCalculadora2Retorna1()
        {
            int a = Calculadora2.Add("1");
            Assert.AreEqual(1, a);
        }
        [TestMethod]
        public void AddCalculadora2Retorna17()
        {
            int a = Calculadora2.Add("1,6,9,1");
            Assert.AreEqual(17, a);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void AddCalculadora2RetornaException()
        {
            int a = Calculadora2.Add("1,a,2,3");
            Assert.AreEqual(1, a);
        }

        //Parte 3
        [TestMethod]
        public void AddCalculadora3Retorna6()
        {
            int a = Calculadora3.Add("1/n5");
            Assert.AreEqual(6, a);
        }

        [TestMethod]
        public void AddCalculadora3Retorna2()
        {
            int a = Calculadora3.Add("1/ n1");
            Assert.AreEqual(2, a);
        }

        [TestMethod]
        public void AddCalculadora4Retorna3()
        {
            int a = Calculadora4.Add("//-1");
            Assert.AreEqual(1, a);
        }

    }
}