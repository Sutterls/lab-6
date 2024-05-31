using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class TriangleAreaContext // Для замены алгоритма расчета площади треугольника
    {

        private ITriangleAreaStrategy? _strategy;

        public TriangleAreaContext(ITriangleAreaStrategy? strategy)
        {
            _strategy = strategy;
        }

        public double CalculateArea(double a, double b, double c)
        {
            // Проверка ввода данных
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The sides of the triangle must be positive.");
            }
            // Проверка на существование треугольника
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                throw new ArgumentException("The sides of the triangle do not form a triangle.");
            }
            // Выбор стратегии в зависимости от треугольника
            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                ITriangleAreaStrategy strategy = new RightTriangleAreaStrategy();
                return strategy.CalculateArea(a, b, c);
            }
            else
            {
                ITriangleAreaStrategy strategy = new HeronTriangleAreaStrategy();
                return strategy.CalculateArea(a, b, c);
            }
        }
    }
}
