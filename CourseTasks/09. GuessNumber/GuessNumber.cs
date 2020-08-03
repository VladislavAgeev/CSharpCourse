using System;

namespace GuessNumber
{
    class GuessNumber
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int hiddenNumber = x.Next(1, 101);

            Console.Write("Отгадайте число от 1 до 100: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int attemptsCount = 1;

            for (; ; )
            {
                if (userNumber > hiddenNumber)
                {
                    Console.Write("Загаданное число меньше введенного! Повторите ввод: ");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    attemptsCount++;
                }
                else if (userNumber < hiddenNumber)
                {
                    Console.Write("Загаданное число больше введенного! Повторите ввод: ");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    attemptsCount++;
                }
                else
                {
                    Console.WriteLine("Вы отгадали число!");
                    Console.WriteLine("Попыток использовано = " + attemptsCount);
                    break;
                }
            }
        }
    }
}
