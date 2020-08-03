using System;

namespace BubbleSort
{
    class BubbleSort
    {
        static void MakeBubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isPermutations = false;

                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        isPermutations = true;

                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }

                if (!isPermutations)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка пузырьком.");

            int[] array = { 7, 2, 9, 4, 1, 0 };
            MakeBubbleSort(array);

            Console.WriteLine("Отсортированный массив: " + string.Join(",", array));
        }
    }
}
