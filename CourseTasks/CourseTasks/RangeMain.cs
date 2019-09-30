using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTasks
{
    class RangeMain
    {
        static void Main(string[] args)
        {
            Range range = new Range(5, 18);

            Console.WriteLine("Длина диапазона = " + range.GetLength());

            double number = 7.5;

            if (range.IsInside(number))
            {
                Console.WriteLine("Число принадлежит диапазону");
            }
            else
            {
                Console.WriteLine("Число не принадлежит диапазону");
            }
        }
    }
}
