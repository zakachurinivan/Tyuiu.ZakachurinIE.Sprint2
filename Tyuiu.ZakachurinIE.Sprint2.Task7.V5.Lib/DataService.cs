using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZakachurinIE.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= Math.Pow(x, 2)) && (y <= Math.Pow((Math.E), 2)) && (x >= 0) && (x <= 1))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
