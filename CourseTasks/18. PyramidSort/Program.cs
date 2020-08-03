using System;

namespace PyramidSort
{
    class PyramidSort
    {
        private static void MakeHeap(int[] array, int i, int arrayLength)
        {
            int parent = i;

            while (i < arrayLength / 2)
            {
                int child1 = 2 * i + 1;
                int child2 = 2 * i + 2;

                if (child1 < arrayLength && array[child1] > array[parent])
                {
                    parent = child1;
                }

                if (child2 < arrayLength && array[child2] > array[parent])
                {
                    parent = child2;
                }

                if (parent != i)
                {
                    int temp = array[i];
                    array[i] = array[parent];
                    array[parent] = temp;

                    i = parent;
                }
                else
                {
                    break;
                }
            }
        }

        private static void MakeSortingHeap(int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                MakeHeap(array, i, array.Length);
            }

            for (int i = array.Length - 1; i >= 1; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                MakeHeap(array, 0, i);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 44, 55, 12, 42, 94, 18, 6, 670 };

            MakeSortingHeap(array);

            Console.WriteLine("Пирамидальная сортировка.");
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", array));
        }
    }
}