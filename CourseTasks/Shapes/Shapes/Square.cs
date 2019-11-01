namespace Shapes.Shapes
{
    class Square : IShape
    {
        public double SideLength { get; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
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

            Square s = (Square)obj;

            return SideLength == s.SideLength;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + SideLength.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return base.ToString() + ": Длина стороны = " + SideLength;
        }

        public double GetWidth()
        {
            return SideLength;
        }

        public double GetHeight()
        {
            return SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength;
        }

        public double GetPerimeter()
        {
            return SideLength * 4;
        }
    }
}
