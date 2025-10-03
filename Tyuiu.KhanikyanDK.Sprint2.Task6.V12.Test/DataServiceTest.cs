using Tyuiu.KhanikyanDK.Sprint2.Task6.V12.Lib;
namespace Tyuiu.KhanikyanDK.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2025;
            int m = 10;
            int n = 2;
            string prev = $"{g}/{m}/{n - 1}";
            string exp = "2025/10/1";
            Assert.AreEqual(exp, prev);
        }
    }
}
