using System;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1.0e-7;

            if (Math.Abs((x3 - x1) * (y2 - y1) - (x2 - x1) * (y3 - y1)) <= epsilon)
            {
                Console.WriteLine("Точки лежат на одной прямой");
            }
            else
            {
                double sideLength1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double sideLength2 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
                double sideLength3 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                double semiPerimeter = (sideLength1 + sideLength2 + sideLength3) / 2;
                double triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideLength1) * (semiPerimeter - sideLength2) * (semiPerimeter - sideLength3));

                Console.WriteLine("Площадь треугольника = " + triangleArea);
            }
        }
    }
}
