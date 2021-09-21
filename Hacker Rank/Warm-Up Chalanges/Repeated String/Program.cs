using System;

namespace Repeated_String
{
    class Program
    {
        public static long repeatedString(string s, long n)
        {
            long repeated = n / s.Length;
            long left = n - (s.Length * repeated);
            int extra = 0;
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    ++count;
                }
            }

            for (int i = 0; i < left; i++)
            {
                if (s[i] == 'a')
                {
                    ++extra;
                }
            }

            return (repeated * count) + extra;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = long.Parse(Console.ReadLine());

            repeatedString(s, n);
        }
    }
}
