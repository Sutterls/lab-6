using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class RightTriangleAreaStrategy : ITriangleAreaStrategy
    {
        public double CalculateArea(double a, double b, double c)
        {
            if (a * a + b * b == c * c)
            {
                return 0.5 * a * b;
            }
            if (a * a + c * c == b * b)
            {
                return 0.5 * a * c;
            }
            if (b * b + c * c == a * a)
            {
                return 0.5 * b * c;
            }

            return 0; // Возвращаем 0, если треугольник не является прямоугольным
        }
    }
}
