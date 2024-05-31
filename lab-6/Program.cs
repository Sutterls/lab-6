namespace lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(double a, double b, double c)> triangles = new List<(double a, double b, double c)>() // создаем список со сторонами треугольников
            {
                (3, 4, 5),  // Прямоугольный треугольник
                (2, 3, 4),  // Треугольник, не являющийся прямоугольным
                (0, 0, 0),  // Ошибка
                (5, 7, 15)  // Несуществующий треугольник
            };

            foreach (var triangle in triangles)
            {
                try
                {
                    double area = new TriangleAreaContext(null).CalculateArea(triangle.a, triangle.b, triangle.c);
                    Console.WriteLine($"The area of the triangle with sides {triangle.a}, {triangle.b} and {triangle.c} is {area}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
