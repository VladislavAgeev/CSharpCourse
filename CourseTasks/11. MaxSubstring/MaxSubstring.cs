using System;

namespace MaxSubstring
{
    class MaxSubstring
    {
        public static int GetMaxSubstringLength(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            text = text.ToLower();

            int charactersCount = 1;
            int maxSubstringLength = charactersCount;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    charactersCount++;
                }
                else
                {
                    charactersCount = 1;
                }

                if (maxSubstringLength < charactersCount)
                {
                    maxSubstringLength = charactersCount;
                }
            }

            return maxSubstringLength;
        }

        static void Main(string[] args)
        {
            string text = "";
            Console.WriteLine("Максимальное количество символов, идущих подряд = " + GetMaxSubstringLength(text));
        }
    }
}
