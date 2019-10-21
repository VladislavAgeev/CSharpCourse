using System;

namespace Shapes
{
    class Circle : IShape
    {
        private double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
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
                Circle c = (Circle)obj;

                return radius == c.radius;
            }
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + radius.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + "Радиус = " + radius.ToString();
        }

        public double GetWidth()
        {
            return radius * 2;
        }

        public double GetHeight()
        {
            return radius * 2;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetPerimeter()
        {
            return radius * 2 * Math.PI;
        }
    }
}
