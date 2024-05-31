using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class HeronTriangleAreaStrategy : ITriangleAreaStrategy
    {
        public double CalculateArea(double a, double b, double c) // Расчет площади по формуле Герона
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

    }
}
