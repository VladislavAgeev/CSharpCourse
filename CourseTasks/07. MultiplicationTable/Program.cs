using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.Write("До какого числа вывести таблицу умножения: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("  x/y |");

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i.ToString().PadLeft(5));
            }

            Console.WriteLine();
            Console.Write("--");

            for (int i = 0; i <= number; i++)
            {
                Console.Write("-----");
            }

            Console.WriteLine();

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i.ToString().PadLeft(5) + " |");

                for (int j = 1; j <= number; j++)
                {
                    Console.Write((i * j).ToString().PadLeft(5));
                }

                Console.WriteLine();
            }
        }
    }
}
