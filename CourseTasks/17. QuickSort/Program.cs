using System;

namespace QuickSort
{
    class QuickSort
    {
        private static void MakeQuickSort(int[] array, int left, int right)
        {
            if (array.Length == 0)
            {
                return;
            }

            int supportingElement = array[(right + left) / 2];

            int i = left;
            int j = right;

            while (i <= j)
            {
                while (array[i] < supportingElement)
                {
                    ++i;
                }

                while (array[j] > supportingElement)
                {
                    --j;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    ++i;
                    --j;
                }
            }

            if (i < right)
            {
                MakeQuickSort(array, i, right);
            }

            if (j > left)
            {
                MakeQuickSort(array, left, j);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 2, 5, 8, 12, 4, 18, 9, 7, 20, 16 };
            MakeQuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Быстрая сортировка.");
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", array));
        }
    }
}
