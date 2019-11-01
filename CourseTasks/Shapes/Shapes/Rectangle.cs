using System;

namespace Shapes.Shapes
{
    class Rectangle : IShape
    {
        public double FirstSideLength { get; }
        public double SecondSideLength { get; }

        public Rectangle(double firstSideLength, double secondSideLength)
        {
            FirstSideLength = firstSideLength;
            SecondSideLength = secondSideLength;
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

            Rectangle r = (Rectangle)obj;

            return FirstSideLength == r.FirstSideLength && SecondSideLength == r.SecondSideLength;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + FirstSideLength.GetHashCode();
            hash = prime * hash + SecondSideLength.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return base.ToString() + ": Длины сторон = " + FirstSideLength + ", " + SecondSideLength;
        }

        public double GetWidth()
        {
            return Math.Max(FirstSideLength, SecondSideLength);
        }

        public double GetHeight()
        {
            return Math.Min(FirstSideLength, SecondSideLength);
        }

        public double GetArea()
        {
            return FirstSideLength * SecondSideLength;
        }

        public double GetPerimeter()
        {
            return (FirstSideLength + SecondSideLength) * 2;
        }
    }
}
