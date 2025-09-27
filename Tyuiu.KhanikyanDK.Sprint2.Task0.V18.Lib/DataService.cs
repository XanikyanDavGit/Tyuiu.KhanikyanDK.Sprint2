using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhanikyanDK.Sprint2.Task0.V18.Lib 
{
    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = x == y;
            result[1] = x != y;
            result[2] = x - 5000 < y;
            result[3] = x > y;
            result[4] = x - 5000 <= y;
            result[5] = x - 5000 >= y;

            return result;
        }
    }
}