using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public interface ITriangleAreaStrategy // Интерфейс, определяющий метод расчета площади треугольника
    {
        double CalculateArea(double a, double b, double c);
    }
}
