using System;

namespace Range
{
    class RangeMain
    {
        static void Main(string[] args)
        {
            Range range1 = new Range(3, 5);
            Range range2 = new Range(5, 8);

            Range rangesIntersection = range1.GetIntersection(range2);

            if (rangesIntersection == null)
            {
                Console.WriteLine("Пересечение диапазонов не найдено.");
            }
            else
            {
                Console.WriteLine("Пересечение диапазонов = [" + rangesIntersection + "]");
            }

            Range[] rangesUnion = range1.GetUnion(range2);

            Console.Write("Объединение диапазонов = [");

            for (int i = 0; i < rangesUnion.Length; i++)
            {
                if (i == 1)
                {
                    Console.Write(", ");
                }

                Console.Write(rangesUnion[i]);
            }

            Console.WriteLine("]");

            Range[] rangesDifference = range1.GetDifference(range2);

            Console.Write("Разность интервалов = [");

            for (int i = 0; i < rangesDifference.Length; i++)
            {
                if (i == 1)
                {
                    Console.Write(", ");
                }

                Console.Write(rangesDifference[i]);
            }

            Console.WriteLine("]");
        }
    }
}
