using System;

namespace EuclideanAlgorithm
{
    class EuclideanAlgorithm
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Наибольший общий делитель не определен");
            }
            else
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }

                Console.WriteLine("Наибольший общий делитель данных чисел = " + a);
            }
        }
    }
}
