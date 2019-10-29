using System;

namespace Range
{
    class RangeMain
    {
        static void Main(string[] args)
        {
            Range firstRange = new Range(3, 5);

            Range secondRange = new Range(5, 8);

            Range rangesIntersection = firstRange.GetIntersection(secondRange);

            if (rangesIntersection == null)
            {
                Console.WriteLine("Пересечение диапазонов не найдено.");
            }
            else
            {
                Console.WriteLine("Пересечение диапазонов = " + "[" + rangesIntersection + "]");
            }

            Range[] rangesUnion = firstRange.GetUnion(secondRange);

            Console.Write("Объединение диапазонов = ");
            Console.Write("[");

            for (int i = 0; i < rangesUnion.Length; i++)
            {
                if (i == 1)
                {
                    Console.Write(", ");
                }

                Console.Write(rangesUnion[i]);
            }

            Console.Write("]");
            Console.WriteLine();

            Range[] rangesDifference = firstRange.GetDifference(secondRange);

            Console.Write("Разность интервалов = ");
            Console.Write("[");

            for (int i = 0; i < rangesDifference.Length; i++)
            {
                if (i == 1)
                {
                    Console.Write(", ");
                }

                Console.Write(rangesDifference[i]);
            }

            Console.Write("]");
            Console.WriteLine();
        }
    }
}
