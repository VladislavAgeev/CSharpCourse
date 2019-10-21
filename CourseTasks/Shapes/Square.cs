namespace Shapes
{
    class Square : IShape
    {
        private double sideLength { get; set; }

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
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
                Square s = (Square)obj;

                return sideLength == s.sideLength;
            }
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + sideLength.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + "Длина стороны = " + sideLength.ToString();
        }

        public double GetWidth()
        {
            return sideLength;
        }

        public double GetHeight()
        {
            return sideLength;
        }

        public double GetArea()
        {
            return sideLength * sideLength;
        }

        public double GetPerimeter()
        {
            return sideLength * 4;
        }
    }
}
