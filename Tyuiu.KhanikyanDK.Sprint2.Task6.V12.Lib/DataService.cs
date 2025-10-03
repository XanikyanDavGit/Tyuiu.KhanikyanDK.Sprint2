using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhanikyanDK.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res;
            switch (n)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                    n -= 1;
                    break;
                case 1:
                    m -= 1;
                    break;
                default:
                    res = "n должен быть от 1 до 31";
                    break;
            }
            string den = "";
            string mes = "";


            if (n < 10)
            {
                den = "0" + n;
            }
            if (m < 10)
            {
                mes = "0" + m;
            }


            if (n == 1)
            {
                den = "31";
            }
            res = $"{den}.{mes}.{g}";


            return res;
        }
    }
}
