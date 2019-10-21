using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class RangeMain
    {
        static void Main(string[] args)
        {
            Range firstRange = new Range(2, 5);

            Range secondRange = new Range(6, 10);

            Range rangesIntersection = firstRange.GetRangesIntersection(secondRange);

            if (rangesIntersection == null)
            {
                Console.WriteLine("Интервал пересечения диапазонов не найден.");
            }
            else
            {
                Console.WriteLine("Интервал пересечения диапазонов = " + rangesIntersection.ToString());
            }

            Range[] rangesAssociation = firstRange.GetRangesAssociation(secondRange);

            foreach (Range r in rangesAssociation)
            {
                Console.WriteLine("Интервал объединения диапазонов = " + r.ToString());
            }

            Range[] rangesDifference = firstRange.GetRangesDifference(secondRange);

            if (rangesDifference == null)
            {
                Console.WriteLine("Разность интервалов не найдена.");
            }
            else
            {
                foreach (Range r in rangesDifference)
                {
                    Console.WriteLine("Разность интервалов = " + r.ToString());
                }
            }
        }
    }
}
