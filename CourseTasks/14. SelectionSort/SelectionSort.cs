using System;

namespace SelectionSort
{
    class SelectionSort
    {
        private static void MakeSelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка выбором.");

            int[] array = { 3, 9, 1, 4, 0, 5 };

            MakeSelectionSort(array);

            Console.WriteLine("Отсортированный массив: " + string.Join(",", array));
        }
    }
}
