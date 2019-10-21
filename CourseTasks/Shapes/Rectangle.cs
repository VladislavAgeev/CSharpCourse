using System;

namespace Shapes
{
    class Rectangle : IShape
    {
        private double firstSideLength { get; set; }
        private double secondSideLength { get; set; }

        public Rectangle(double firstSideLength, double secondSideLength)
        {
            this.firstSideLength = firstSideLength;
            this.secondSideLength = secondSideLength;
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
                Rectangle r = (Rectangle)obj;

                return firstSideLength == r.firstSideLength && secondSideLength == r.secondSideLength;
            }
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + firstSideLength.GetHashCode();
            hash = prime * hash + secondSideLength.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return string.Join(",", firstSideLength, secondSideLength);
        }

        public double GetWidth()
        {
            return Math.Max(firstSideLength, secondSideLength);
        }

        public double GetHeight()
        {
            return Math.Min(firstSideLength, secondSideLength);
        }

        public double GetArea()
        {
            return firstSideLength * secondSideLength;
        }

        public double GetPerimeter()
        {
            return firstSideLength + secondSideLength;
        }
    }
}
