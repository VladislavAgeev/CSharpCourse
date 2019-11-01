namespace Range
{
    public class Range
    {
        public double From { get; set; }
        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public override string ToString()
        {
            return "{" + From + "; " + To + "}";
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double x)
        {
            return x >= From && x <= To;
        }

        public Range GetIntersection(Range range)//пересечение
        {
            if (From <= range.From && range.From < To && To <= range.To)
            {
                return new Range(range.From, To);
            }

            if (From > range.From && To >= range.To && range.To > From)
            {
                return new Range(From, range.To);
            }

            if (From < range.From && To > range.To)
            {
                return new Range(range.From, range.To);
            }

            if (From > range.From && To < range.To)
            {
                return new Range(From, To);
            }

            return null;
        }

        public Range[] GetUnion(Range range)//объединение
        {
            if (From <= range.From && range.From < To && To <= range.To)
            {
                return new Range[] { new Range(From, range.To) };
            }

            if (From > range.From && To >= range.To && range.To > From)
            {
                return new Range[] { new Range(range.From, To) };
            }

            if (From < range.From && To > range.To)
            {
                return new Range[] { new Range(From, To) };
            }

            if (From > range.From && To < range.To)
            {
                return new Range[] { new Range(range.From, range.To) };
            }

            if (From == range.To)
            {
                return new Range[] { new Range(range.From, To) };
            }

            if (To == range.From)
            {
                return new Range[] { new Range(From, range.To) };
            }

            return new Range[] { new Range(From, To), new Range(range.From, range.To) };
        }

        public Range[] GetDifference(Range range)//разность
        {
            if (From < range.From && range.From < To && To <= range.To)
            {
                return new Range[] { new Range(From, range.From) };
            }

            if (From > range.From && To >= range.To && range.To > From)
            {
                return new Range[] { new Range(range.To, To) };
            }

            if (From < range.From && To > range.To)
            {
                return new Range[] { new Range(From, range.From), new Range(range.To, To) };
            }

            if (From > range.From && To < range.To)
            {
                return new Range[] { };
            }

            if (From == range.From && To == range.To)
            {
                return new Range[] { };
            }

            return new Range[] { new Range(From, To) };
        }
    }
}
