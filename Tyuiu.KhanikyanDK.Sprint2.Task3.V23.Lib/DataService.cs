using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhanikyanDK.Sprint2.Task3.V23.Lib
{
    public class DataService : ISprint2Task3V23
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x == 0)
            {
                y = (x * x + Math.Cos(x * x) - 17) / (x * x - Math.Sin(x * x) + 3);
            }
            else if (x > 1)
            {
                y = x * Math.Pow((x + 1)/(x - 1), x);
            }
            else if (x > -27 && x < 2)
            {
                y = Math.Pow(3 + 1 / (x * x), x);
            }
            else 
            {
                y = x + 10 * x - (1 / (x * x));
            }
            return Math.Round(y, 3);
        }
    }
}
