using System;

namespace NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool is30DaysMonth = (month == 4 || month == 6 || month == 9 || month == 11) && day <= 30;

            bool is31DaysMonth = (month == 1 || month == 3 || month == 5 || month == 7
                || month == 8 || month == 10 || month == 12) && day <= 31;

            bool isLeapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            bool isCorrect = is30DaysMonth || is31DaysMonth || (month == 2 && !isLeapYear && day <= 28)
                || (month == 2 && isLeapYear && day <= 29);

            bool isLastDay = (is30DaysMonth && day == 30) || (is31DaysMonth && day == 31) ||
                (month == 2 && isLeapYear && day == 29) || (month == 2 && !isLeapYear && day == 28);

            if (!isCorrect)
            {
                Console.WriteLine("Вы ввели некорректные данные.");
            }
            else
            {
                if (month == 12 && day == 31)
                {
                    Console.WriteLine("Последний день месяца");
                    day = 1;
                    month = 1;
                    year++;
                }
                else if (isLastDay)
                {
                    Console.WriteLine("Последний день месяца");
                    day = 1;
                    month++;
                }
                else
                {
                    day++;
                }

                Console.WriteLine("Завтра день: " + day);
                Console.WriteLine("Завтра месяц: " + month);
                Console.WriteLine("Завтра год: " + year);
            }
        }
    }
}