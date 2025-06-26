using LibCalcolatrice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Somma(3, 5);
            Assert.AreEqual(8, risultato);
        }


        [TestMethod]
        public void TestDifferenza()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Somma(10, -2);
            Assert.AreEqual(8, risultato);
        }
        [TestMethod]
        public void TestProdotto()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Somma(4, 4);
            Assert.AreEqual(8, risultato);
        }
        [TestMethod]
        public void TestDivisione()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Somma(16, -8);
            Assert.AreEqual(8, risultato);
        }
    }
}

