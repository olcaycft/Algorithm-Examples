using System;

namespace Reverse_deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstReverse(Console.ReadLine()));
        }

        public static string FirstReverse(string str)
        {
            char[] reverse = new char[str.Length];
            for (int i = 0,j=(str.Length-1); i <= j; i++,j--)
            {
                reverse[i] = str[j];
                reverse[j] = str[i];
            }
            return new string(reverse);
        }
    }
}
