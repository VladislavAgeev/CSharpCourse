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

            try
            {
                using (StreamReader reader = new StreamReader("File.txt"))
                {
                    string text;

                    while ((text = reader.ReadLine()) != null)
                    {
                        fileStrings.Add(text);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл не найден: " + e);
            }

            foreach (string s in fileStrings)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            List<int> numbers1 = new List<int> { 1, 2, 2, 3, 4, 5, 5, 6, 4, 7, 8, 9, 10, 10, 11, 12, 13, 15 };

            for (int i = 0; i < numbers1.Count; i++)
            {
                if (numbers1[i] % 2 == 0)
                {
                    numbers1.RemoveAt(i--);
                }
            }

            foreach (int n in numbers1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            List<int> numbers2 = new List<int> { 1, 2, 3, 2, 5, 3, 4, 6, 1, 8 };
            List<int> numbers3 = new List<int>(10);

            foreach (int i in numbers2)
            {
                if (!numbers3.Contains(i))
                {
                    numbers3.Add(i);
                }
            }

            foreach (int n in numbers3)
            {
                Console.WriteLine(n);
            }
        }
    }
}
