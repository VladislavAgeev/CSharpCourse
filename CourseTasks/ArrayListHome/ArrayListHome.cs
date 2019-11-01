using System;
using System.Collections.Generic;
using System.IO;

namespace ArrayListHome
{
    class ArrayListHome
    {
        static void Main(string[] args)
        {
            List<string> fileStrings = new List<string>();

            using (StreamReader reader = new StreamReader("File.txt"))
            {
                string text;

                while ((text = reader.ReadLine()) != null)
                {
                    fileStrings.Add(text);
                }
            }

            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            for (int i = 0; i < numbers1.Count; i++)
            {
                if (numbers1[i] % 2 == 0)
                {
                    numbers1.Remove(numbers1[i]);
                }
            }

            List<int> numbers2 = new List<int> { 1, 2, 3, 2, 5, 3, 4, 6, 1, 8 };
            List<int> numbers3 = new List<int>();

            foreach (int i in numbers2)
            {
                if (!numbers3.Contains(i))
                {
                    numbers3.Add(i);
                }
            }
        }
    }
}
