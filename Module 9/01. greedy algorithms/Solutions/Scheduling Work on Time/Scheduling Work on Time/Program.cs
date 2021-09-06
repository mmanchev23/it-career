using System;
using System.Linq;

namespace Scheduling_Work_on_Time
{
    class Program
    {
        public static void CalculateWork(Work[] works)
        {
            works = works.OrderByDescending(work => work.Prize).ThenBy(work => work.Deadline).ToArray();
            int prize = 0;
            int i, j;
            i = 0;

            Console.Write($"\n{works[0].Name} ");

            for (j = 1; j < works.Length; j++)
            {
                if(works[j].Deadline > works[i].Deadline)
                {
                    prize += works[j].Prize;
                    Console.Write($"{works[j].Name} ");
                    i = j;
                }
            }
            Console.WriteLine($"\n{prize + works[0].Prize}");
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] work;
            Work[] works = new Work[n];

            for (int i = 0; i < n; i++)
            {
                work = Console.ReadLine().Split();
                works[i] = new Work(work[0], int.Parse(work[1]), int.Parse(work[2]));
            }

            CalculateWork(works);
        }
    }
}

/*
5
j1 2 60
j2 1 100
j3 3 20
j4 2 40
j5 1 20

j2 j1 j3
180
*/
