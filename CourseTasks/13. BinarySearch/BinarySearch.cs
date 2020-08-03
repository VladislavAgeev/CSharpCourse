using System;

namespace BinarySearch
{
    class BinarySearch
    {
        private static int RecursionBinarySearch(int[] array, int searchedValue, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = (left + right) / 2;
            int middleValue = array[middle];

            if (middleValue == searchedValue)
            {
                return middle;
            }

            if (middleValue > searchedValue)
            {
                return RecursionBinarySearch(array, searchedValue, left, middle - 1);
            }

            return RecursionBinarySearch(array, searchedValue, middle + 1, right);
        }

        private static int BinarySearchWithoutRecursion(int[] array, int searchedValue)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (searchedValue == array[middle])
                {
                    return middle;
                }

                if (searchedValue < array[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            Console.Write("Введите искомое значение: ");
            int searchedValue = Convert.ToInt32(Console.ReadLine());

            int searchResult1 = RecursionBinarySearch(array, searchedValue, 0, array.Length - 1);

            if (searchResult1 < 0)
            {
                Console.WriteLine("Элемент со значением {0} не найден", searchedValue);
            }
            else
            {
                Console.WriteLine("Элемент найден. Индекс элемента со значением {0} равен {1}", searchedValue, searchResult1);
            }

            int searchResult2 = BinarySearchWithoutRecursion(array, searchedValue);

            if (searchResult2 < 0)
            {
                Console.WriteLine("Элемент со значением {0} не найден", searchedValue);
            }
            else
            {
                Console.WriteLine("Элемент найден. Индекс элемента со значением {0} равен {1}", searchedValue, searchResult1);
            }
        }
    }
}
