using System;

namespace Shapes
{
    class ShapeMain
    {
        public static IShape GetShapeMaxArea(IShape[] shape)
        {
            Array.Sort(shape, new CompareArea());

            return shape[0];
        }

        public static IShape GetShapeMaxPerimeter(IShape[] shape)
        {
            Array.Sort(shape, new ComparePerimeter());

            return shape[1];
        }

        static void Main(string[] args)
        {
            IShape[] shape = { new Square(4), new Triangle(4, 8, 12, 2, 6, 14), new Rectangle(8, 4), new Circle(4),
                new Square(2) , new Circle(5) };

            Console.WriteLine(GetShapeMaxArea(shape).ToString());

            Console.WriteLine("Площадь фигуры = " + GetShapeMaxArea(shape).GetArea());
            Console.WriteLine("Длина фигуры = " + GetShapeMaxArea(shape).GetWidth());
            Console.WriteLine("Высота фигуры = " + GetShapeMaxArea(shape).GetHeight());
            Console.WriteLine("Периметр фигуры = " + GetShapeMaxArea(shape).GetPerimeter());
        }
    }
}
