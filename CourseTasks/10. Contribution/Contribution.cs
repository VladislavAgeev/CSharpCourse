using System;

namespace Contribution
{
    class Contribution
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            double startDeposit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ставку % годовых: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите срок вклада: ");
            int period = Convert.ToInt32(Console.ReadLine());

            double epsilon = 1.0e-5;

            if (rate < 0)
            {
                Console.WriteLine("Ставка % годовых не может быть отрицательной");
            }
            else if (rate <= epsilon)
            {
                Console.WriteLine("По истечении срока вклада сумма составит: {0}", startDeposit);
            }
            else
            {
                const int months = 12;
                const int oneHundredthOfRate = 100;

                double tempRate = rate / oneHundredthOfRate / months;
                double tempDeposit = startDeposit;

                for (int i = 1; i <= period; i++)
                {
                    tempDeposit += tempDeposit * tempRate;
                }

                double profit = tempDeposit - startDeposit;

                Console.WriteLine("По истечении срока вклада сумма составит: {0}", Math.Round(tempDeposit, 2));
                Console.WriteLine("Прибыль составила: {0}", Math.Round(profit, 2));
            }
        }
    }
}
