using System;
using Shapes.Shapes;

namespace Shapes
{
    class ShapeMain
    {
        public static IShape GetMaxAreaShape(IShape[] shape)
        {
            Array.Sort(shape, new AreaComparer());

            return shape[shape.Length - 1];
        }

        public static IShape GetSecondPerimeterShape(IShape[] shape)
        {
            Array.Sort(shape, new PerimeterComparer());

            return shape[shape.Length - 2];
        }

        static void Main(string[] args)
        {
            IShape[] shape = { new Square(4), new Triangle(4, 8, 12, 2, 6, 14), new Rectangle(8, 4), new Circle(4),
                new Square(2) , new Circle(5) };

            Console.WriteLine(GetMaxAreaShape(shape));

            Console.WriteLine("Площадь фигуры = " + GetMaxAreaShape(shape).GetArea());
            Console.WriteLine("Длина фигуры = " + GetMaxAreaShape(shape).GetWidth());
            Console.WriteLine("Высота фигуры = " + GetMaxAreaShape(shape).GetHeight());
            Console.WriteLine("Периметр фигуры = " + GetMaxAreaShape(shape).GetPerimeter());

            Console.WriteLine(GetSecondPerimeterShape(shape));

            Console.WriteLine("Периметр фигуры = " + GetSecondPerimeterShape(shape).GetPerimeter());
            Console.WriteLine("Площадь фигуры = " + GetSecondPerimeterShape(shape).GetArea());
            Console.WriteLine("Длина фигуры = " + GetSecondPerimeterShape(shape).GetWidth());
            Console.WriteLine("Высота фигуры = " + GetSecondPerimeterShape(shape).GetHeight());
        }
    }
}
