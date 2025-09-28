using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhanikyanDK.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {   
            if (x == 3 && (y == 3 || y == 4 || y == 7 || y == 11)) return true;
            else if (x == 4 && (y == 3 || y == 4 || (y >= 7 && y <= 13))) return true;
            else if (x == 5 && (y == 14 || (y >= 3 && y <= 7))) return true;
            else if (x == 6 && (y == 14 || (y >= 5 && y <= 7))) return true;
            else if (x == 7 && (y >= 5 && y <= 7)) return true;
            else if (x == 8 && (y >= 5 && y <= 12)) return true;
            else if (x == 9 && (y >= 3 && y <= 12)) return true;
            else if (x == 10 && (y >= 7 && y <= 12)) return true;
            else if (x == 11 && (y == 11 || (y >= 7 && y <= 8))) return true;
            else if (x == 12 && (y == 11 || (y >= 3 && y <= 8))) return true;
            else if (x == 13 && (y >= 6 && y <= 8)) return true;
            else return false;
        }
    }
}
