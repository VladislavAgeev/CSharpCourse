using System;

namespace InsertionSort
{
    class InsertionSort
    {
        private static void MakeInsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j;
                int temp = array[i];

                for (j = i - 1; j >= 0; j--)
                {
                    if (j < 0 || temp >= array[j])
                    {
                        break;
                    }

                    array[j + 1] = array[j];
                }

                array[j + 1] = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка вставками.");

            int[] array = { 3, 9, 1, 4, 0, 5 };
            //int[] array = { };
            MakeInsertionSort(array);

            Console.WriteLine("Отсортированный массив: " + string.Join(",", array));
        }
    }
}
