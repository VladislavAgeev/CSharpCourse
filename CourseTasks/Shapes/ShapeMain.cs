using System;
using Shapes.Shapes;

namespace Shapes
{
    class ShapeMain
    {
        public static IShape GetMaxAreaShape(IShape[] shapes)
        {
            Array.Sort(shapes, new AreaComparer());

            return shapes[shapes.Length - 1];
        }

        public static IShape GetSecondPerimeterShape(IShape[] shapes)
        {
            Array.Sort(shapes, new PerimeterComparer());

            return shapes[shapes.Length - 2];
        }

        static void Main(string[] args)
        {
            IShape[] shapes = { new Square(4), new Triangle(4, 8, 12, 2, 6, 14), new Rectangle(8, 4), new Circle(4),
                new Square(2) , new Circle(5) };

            Console.WriteLine(GetMaxAreaShape(shapes));

            Console.WriteLine("Площадь фигуры = " + GetMaxAreaShape(shapes).GetArea());
            Console.WriteLine("Длина фигуры = " + GetMaxAreaShape(shapes).GetWidth());
            Console.WriteLine("Высота фигуры = " + GetMaxAreaShape(shapes).GetHeight());
            Console.WriteLine("Периметр фигуры = " + GetMaxAreaShape(shapes).GetPerimeter());

            Console.WriteLine(GetSecondPerimeterShape(shapes));

            Console.WriteLine("Периметр фигуры = " + GetSecondPerimeterShape(shapes).GetPerimeter());
            Console.WriteLine("Площадь фигуры = " + GetSecondPerimeterShape(shapes).GetArea());
            Console.WriteLine("Длина фигуры = " + GetSecondPerimeterShape(shapes).GetWidth());
            Console.WriteLine("Высота фигуры = " + GetSecondPerimeterShape(shapes).GetHeight());
        }
    }
}
