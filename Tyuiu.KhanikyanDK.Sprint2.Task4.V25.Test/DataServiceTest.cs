using Tyuiu.KhanikyanDK.Sprint2.Task4.V25.Lib;
namespace Tyuiu.KhanikyanDK.Sprint2.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double z = Math.Round(ds.Calculate(x, y), 3);
            double wait = 3;
            Assert.AreEqual(wait, z);
        }
    }
}
