using Tyuiu.KhanikyanDK.Sprint2.Task7.V2.Lib;
namespace Tyuiu.KhanikyanDK.Sprint2.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = -0.2;
            bool code = ds.CheckDotInShadedArea(x, y);
            bool exp = true;
            Assert.AreEqual(exp, code);
        }
    }
}
