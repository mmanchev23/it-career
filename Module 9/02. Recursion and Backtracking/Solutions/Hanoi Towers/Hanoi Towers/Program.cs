using System;

namespace Hanoi_Towers
{
    class Program
    {
        public static void solveTowers(int total_disks, char start, char end, char temp)
        {
            if (total_disks > 0)
            {
                solveTowers(total_disks - 1, start, temp, end);
                Console.WriteLine("Move disk from " + start + ' ' + end);
                solveTowers(total_disks - 1, temp, end, start);

            }
        }

        static void Main(string[] args)
        {
            char start = 'A';
            char end = 'C';
            char temp = 'B';
            int total_disks = 3;

            solveTowers(total_disks, start, end, temp);
        }
    }
}
