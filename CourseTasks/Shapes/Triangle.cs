using System;

namespace Shapes
{
    class Triangle : IShape
    {
        private double x1 { get; set; }
        private double y1 { get; set; }
        private double x2 { get; set; }
        private double y2 { get; set; }
        private double x3 { get; set; }
        private double y3 { get; set; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (ReferenceEquals(obj, null) || obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Triangle t = (Triangle)obj;

                return (x1 == t.x1) && (y1 == t.y1) && (x2 == t.x2) && (y2 == t.y2) && (x3 == t.x3) && (y3 == t.y3);
            }
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + x1.GetHashCode();
            hash = prime * hash + x2.GetHashCode();
            hash = prime * hash + x3.GetHashCode();
            hash = prime * hash + y1.GetHashCode();
            hash = prime * hash + y2.GetHashCode();
            hash = prime * hash + y3.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return string.Join(",", x1, y1, x2, y2, x3, y3);
        }

        public double GetWidth()
        {
            double maxValue = Math.Max(x1, Math.Max(x2, x3));
            double minValue = Math.Min(x1, Math.Min(x2, x3));

            return maxValue - minValue;
        }

        public double GetHeight()
        {
            double maxValue = Math.Max(y1, Math.Max(y2, y3));
            double minValue = Math.Min(y1, Math.Min(y2, y3));

            return maxValue - minValue;
        }

        public double GetArea()
        {
            double epsilon = 1.0e-7;

            if (Math.Abs((x3 - x1) * (y2 - y1) - (x2 - x1) * (y3 - y1)) <= epsilon)
            {
                return 0;
            }

            double sideLength1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double sideLength2 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double sideLength3 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double semiPerimeter = (sideLength1 + sideLength2 + sideLength3) / 2;

            double triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideLength1) * (semiPerimeter - sideLength2) * (semiPerimeter - sideLength3));

            return triangleArea;
        }

        public double GetPerimeter()
        {
            double sideLength1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double sideLength2 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double sideLength3 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            double trianglePerimeter = sideLength1 + sideLength2 + sideLength3;

            return trianglePerimeter;
        }
    }
}
