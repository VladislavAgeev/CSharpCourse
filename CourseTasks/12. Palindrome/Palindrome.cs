using System;

namespace Palindrome
{
    class Palindrome
    {
        private static bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return true;
            }

            text = text.ToLower();

            for (int i = 0, j = text.Length - 1; i <= j; i++, j--)
            {
                while (!char.IsLetter(text[i]))
                {
                    i++;

                    if (i > j)
                    {
                        return true;
                    }
                }

                while (!char.IsLetter(text[j]))
                {
                    j--;
                }

                if (text[i] != text[j])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите строку для проверки: ");
            string text = Console.ReadLine();

            if (IsPalindrome(text))
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
        }
    }
}
