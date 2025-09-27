using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhanikyanDK.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //   ==  !=  <    >    <=   >=        можно чередовать,
            //   |   &   ||   &&   !    ^ 
            //   (True, False, True, False, True, False),  a = 325, b = 325, c = 242, d = 324

            bool[] res = new bool[6];
            // == | 
            res[0] = (a == b) | (b == a); //true 
            // != &
            res[1] = (a != b) & (a == b); //false
            // < ||
            res[2] = (a < c) || (a == b); //true
            // > &&
            res[3] = (a > d) && (d > b); //false
            // <= !
            res[4] = !(a <= d); //true
            // >= ^
            res[5] = (a >= b) ^ (c < b);//false

            return res;
        }
    }
}