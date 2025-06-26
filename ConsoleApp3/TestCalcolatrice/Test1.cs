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
    }
}
