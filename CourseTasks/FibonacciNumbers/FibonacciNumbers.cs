using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Какой член ряда Фибоначчи Вы хотите увидеть?: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 48)
            {
                Console.WriteLine("Программа считает только до 48 члена ряда Фибоначчи");
            }
            else if (number < 0)
            {
                Console.WriteLine("В ряде Фибоначчи нет такого элемента.");
            }
            else
            {
                int first = 0;
                int second = 1;
                int i = 1;

                while (i <= number)
                {
                    int sum = first + second;
                    first = second;
                    second = sum;
                    i++;
                }

                Console.WriteLine("Число Фибоначчи = " + first);
            }
        }
    }
}
