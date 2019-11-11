using System;

namespace Shapes.Shapes
{
    class Triangle : IShape
    {
        public double X1 { get; }
        public double Y1 { get; }
        public double X2 { get; }
        public double Y2 { get; }
        public double X3 { get; }
        public double Y3 { get; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (ReferenceEquals(obj, null) || obj.GetType() != GetType())
            {
                return false;
            }

            Triangle t = (Triangle)obj;

            return (X1 == t.X1) && (Y1 == t.Y1) && (X2 == t.X2) && (Y2 == t.Y2) && (X3 == t.X3) && (Y3 == t.Y3);
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + X1.GetHashCode();
            hash = prime * hash + X2.GetHashCode();
            hash = prime * hash + X3.GetHashCode();
            hash = prime * hash + Y1.GetHashCode();
            hash = prime * hash + Y2.GetHashCode();
            hash = prime * hash + Y3.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return base.ToString() + ": x1 = " + X1 + ", " + "y1 = " + Y1 + ", " + "x2 = " + X2 + ", " + "y2 = " + Y2 + ", " + "x3 = " + X3 + ", " + "y3 = " + Y3;
        }

        private static double GetWidthAndHeight(double coordinate1, double coordinate2, double coordinate3)
        {
            double maxValue = Math.Max(coordinate1, Math.Max(coordinate2, coordinate3));
            double minValue = Math.Min(coordinate1, Math.Min(coordinate2, coordinate3));

            return maxValue - minValue;
        }

        private static double GetSideLength(double firstCoordinateX, double firstCoordinateY, double secondCoordinateX, double secondCoordinateY)
        {
            double sideLength = Math.Sqrt(Math.Pow(secondCoordinateX - firstCoordinateX, 2) + Math.Pow(secondCoordinateY - firstCoordinateY, 2));

            return sideLength;
        }

        public double GetWidth()
        {
            return GetWidthAndHeight(X1, X2, X3);
        }

        public double GetHeight()
        {
            return GetWidthAndHeight(Y1, Y2, Y3);
        }

        public double GetArea()
        {
            double epsilon = 1.0e-7;

            if (Math.Abs((X3 - X1) * (Y2 - Y1) - (X2 - X1) * (Y3 - Y1)) <= epsilon)
            {
                return 0;
            }

            double sideLength1 = GetSideLength(X1, Y1, X2, Y2);
            double sideLength2 = GetSideLength(X1, Y1, X3, Y3);
            double sideLength3 = GetSideLength(X2, Y2, X3, Y3);
            double semiPerimeter = (sideLength1 + sideLength2 + sideLength3) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideLength1) * (semiPerimeter - sideLength2) * (semiPerimeter - sideLength3)); ;
        }

        public double GetPerimeter()
        {
            double sideLength1 = GetSideLength(X1, Y1, X2, Y2);
            double sideLength2 = GetSideLength(X1, Y1, X3, Y3);
            double sideLength3 = GetSideLength(X2, Y2, X3, Y3);

            return sideLength1 + sideLength2 + sideLength3;
        }
    }
}
