using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый коэффициент квадратного уравнения: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второй коэффициент квадратного уравнения: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите третий коэффициент квадратного уравнения: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1.0e-5;

            if (Math.Abs(a) > epsilon) // квадратное уравнение
            {
                double discriminant = Math.Pow(b, 2) - 4 * a * c;

                if (discriminant < -epsilon) // Нет корней
                {
                    Console.WriteLine("Дискриминант < 0");
                    Console.WriteLine("Корней нет");
                }
                else if (Math.Abs(discriminant) <= epsilon) // Один корень уравнения
                {
                    double x = -b / (2 * a);

                    Console.WriteLine("Дискриминант = 0");
                    Console.WriteLine("Один корень уравнения x = " + x);
                }
                else // Два корня уравнения
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine("Дискриминант > 0");
                    Console.WriteLine("Первый корень уравнения x1 = " + x1);
                    Console.WriteLine("Второй корень уравнения x2 = " + x2);
                }
            }
            else if (Math.Abs(b) > epsilon) // линейное уравнение
            {
                double x = -c / b;
                Console.WriteLine("Один корень уравнения x = " + x);
            }
            else
            {
                if (Math.Abs(c) <= epsilon)
                {
                    Console.WriteLine("Верное тождество 0 = 0");
                }
                else
                {
                    Console.WriteLine("Неверное тождество 0 = " + c);
                }
            }
        }
    }
}
