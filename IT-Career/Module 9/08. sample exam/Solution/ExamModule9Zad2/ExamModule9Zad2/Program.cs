using System;

namespace ExamModule9Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(mult(m, n));
        }
        
        public static int mult(int m, int n)
        {
            if (n == 1)
            {
                return m;
            }
            else
            {
                return mult(m, n - 1) + m;
            }
        }
    }
}
