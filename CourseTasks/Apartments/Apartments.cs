using System;

namespace Apartments
{
    class Apartments
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество подъездов: ");
            int entrancesCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество этажей: ");
            int floorsCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер квартиры: ");
            int flatNumber = Convert.ToInt32(Console.ReadLine());

            int apartmentsCountOnFloor = 4;

            if (flatNumber > (floorsCount * entrancesCount * apartmentsCountOnFloor) || flatNumber < 1)
            {
                Console.WriteLine("Такой квартиры в этом доме нет!");
            }
            else
            {
                int flatsCountInEntrance = floorsCount * apartmentsCountOnFloor;
                int entranceNumber = (flatNumber - 1) / flatsCountInEntrance + 1;
                int floorNumber = (flatNumber - (entranceNumber - 1) * flatsCountInEntrance - 1) / apartmentsCountOnFloor + 1;

                if (flatNumber % apartmentsCountOnFloor == 0)
                {
                    Console.WriteLine("Ближняя справа");
                }
                else if (flatNumber % apartmentsCountOnFloor == 1)
                {
                    Console.WriteLine("Ближняя слева");
                }
                else if (flatNumber % apartmentsCountOnFloor == 2)
                {
                    Console.WriteLine("Дальняя слева");
                }
                else
                {
                    Console.WriteLine("Дальняя справа");
                }

                Console.WriteLine("Квартира в " + entranceNumber + " подъезде, на " + floorNumber + " этаже");
            }
        }
    }
}
