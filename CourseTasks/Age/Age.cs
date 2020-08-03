using System;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int lastDigitNumber = age % 10;

            if (age < 1)
            {
                Console.WriteLine("Вы слишком малы!");
            }
            else if (age > 112)
            {
                Console.WriteLine("Вы слишком стары!");
            }
            else if (age / 10 % 10 == 1)
            {
                Console.WriteLine("Вам " + age + " лет");
            }
            else if (lastDigitNumber == 1)
            {
                Console.WriteLine("Вам " + age + " год");
            }
            else if (lastDigitNumber >= 2 && lastDigitNumber <= 4)
            {
                Console.WriteLine("Вам " + age + " года");
            }
            else
            {
                Console.WriteLine("Вам " + age + " лет");
            }
        }
    }
}
