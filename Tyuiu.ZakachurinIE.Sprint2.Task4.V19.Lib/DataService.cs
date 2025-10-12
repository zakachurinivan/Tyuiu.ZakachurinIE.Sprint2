﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZakachurinIE.Sprint2.Task4.V19.Lib
{
    public class DataService : ISprint2Task4V19
    {
        public double Calculate(double x, double y)
        {
            double z = ((x / 2) < (y - 6)) ? (Math.Pow(6 + (4 / Math.Pow(y, 2)), 2)) : ((Math.Pow(x, 2) - Math.Cos(Math.Pow(y, 2)) + 10) / (Math.Pow(y, 2) - Math.Sin(Math.Pow(y, 2)) + 12));
            return Math.Round(z, 3);
        }
    }
}
