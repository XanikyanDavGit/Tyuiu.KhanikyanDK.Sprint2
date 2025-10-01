using Tyuiu.KhanikyanDK.Sprint2.Task3.V23.Lib;
namespace Tyuiu.KhanikyanDK.Sprint2.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -5.333;
            Console.Write(wait);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 24;
            Console.Write(wait);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression3()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = 0;
            Console.Write(wait);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression4()
        {
            DataService ds = new DataService();
            double x = -28.7;
            double res = ds.Calculate(x);
            double wait = -315.701;
            Console.Write(wait);
            Assert.AreEqual(wait, res);
        }
    }
}
