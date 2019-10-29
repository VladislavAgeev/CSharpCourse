using System;

namespace Shapes.Shapes
{
    class Circle : IShape
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
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

            Circle c = (Circle)obj;

            return Radius == c.Radius;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + Radius.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return base.ToString() + ": Радиус = " + Radius;
        }

        public double GetWidth()
        {
            return Radius * 2;
        }

        public double GetHeight()
        {
            return Radius * 2;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return Radius * 2 * Math.PI;
        }
    }
}
