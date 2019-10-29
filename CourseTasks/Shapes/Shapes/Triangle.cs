using System;

namespace Shapes
{
    class Triangle : IShape
    {
        private double X1 { get; }
        private double Y1 { get; }
        private double X2 { get; }
        private double Y2 { get; }
        private double X3 { get; }
        private double Y3 { get; }

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

        public double GetSideLength(double a, double b, double c)
        {
            double maxValue = Math.Max(a, Math.Max(b, c));
            double minValue = Math.Min(a, Math.Min(b, c));

            return maxValue - minValue;
        }

        public double GetWidth()
        {
            return GetSideLength(X1, X2, X3);
        }

        public double GetHeight()
        {
            return GetSideLength(Y1, Y2, Y3);
        }

        public double GetArea()
        {
            double epsilon = 1.0e-7;

            if (Math.Abs((X3 - X1) * (Y2 - Y1) - (X2 - X1) * (Y3 - Y1)) <= epsilon)
            {
                return 0;
            }

            double sideLength1 = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            double sideLength2 = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));
            double sideLength3 = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
            double semiPerimeter = (sideLength1 + sideLength2 + sideLength3) / 2;

            double triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideLength1) * (semiPerimeter - sideLength2) * (semiPerimeter - sideLength3));

            return triangleArea;
        }

        public double GetPerimeter()
        {
            double sideLength1 = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            double sideLength2 = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));
            double sideLength3 = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));

            double trianglePerimeter = sideLength1 + sideLength2 + sideLength3;

            return trianglePerimeter;
        }
    }
}
