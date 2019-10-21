using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Range
    {
        public double from { get; set; }

        public double to { get; set; }

        public Range(double from, double to)
        {
            this.from = from;
            this.to = to;
        }

        public override string ToString()
        {
            return string.Join(",", from, to);
        }

        public double GetLength()
        {
            return to - from;
        }

        public bool IsInside(double x)
        {
            return x >= from && x <= to;
        }

        public Range GetRangesIntersection(Range range)//пересечение
        {
            if (from < range.from && range.from < to && to < range.to)
            {
                return new Range(range.from, to);
            }
            else if (from > range.from && to > range.to && range.to > from)
            {
                return new Range(from, range.to);
            }
            else if (from < range.from && to > range.to)
            {
                return new Range(range.from, range.to);
            }
            else if (from > range.from && to < range.to)
            {
                return new Range(from, to);
            }

            return null;
        }

        public Range[] GetRangesAssociation(Range range)//объединение
        {
            if (from < range.from && range.from < to && to < range.to)
            {
                Range[] range1 = { new Range(from, range.to) };

                return range1;
            }
            else if (from > range.from && to > range.to && range.to > from)
            {
                Range[] range2 = { new Range(range.from, to) };

                return range2;
            }
            else if (from < range.from && to > range.to)
            {
                Range[] range3 = { new Range(from, to) };

                return range3;
            }
            else if (from > range.from && to < range.to)
            {
                Range[] range4 = { new Range(range.from, range.to) };

                return range4;
            }

            Range[] ranges = { new Range(from, to), new Range(range.from, range.to) };

            return ranges;
        }

        public Range[] GetRangesDifference(Range range)//разность
        {
            if (from < range.from && range.from < to && to < range.to)
            {
                Range[] range1 = { new Range(from, range.from) };

                return range1;
            }
            else if (from > range.from && to > range.to && range.to > from)
            {
                Range[] range2 = { new Range(range.to, to) };

                return range2;
            }
            else if (from < range.from && to > range.to)
            {
                Range[] range3 = { new Range(from, range.from), new Range(range.to, to) };

                return range3;
            }
            else if (from > range.from && to < range.to)
            {
                return null;
            }

            Range[] range4 = { new Range(from, to) };

            return range4;
        }
    }
}
