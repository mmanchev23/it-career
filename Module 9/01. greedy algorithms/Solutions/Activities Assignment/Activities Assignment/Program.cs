using System;
using System.Linq;

namespace Activities_Assignment
{
    class Program
    {
        public static void CalculateActivities(Activity[] activities)
        {
            activities = activities.OrderBy(activity => activity.Finish).ToArray();
            int i, j;

            i = 0;
            Console.Write($"\nAnswer: {activities[i].Name} ");

            for (j = 1; j < activities.Length; j++)
            {
                if (activities[j].Start >= activities[i].Finish)
                {
                    Console.Write($"{activities[j].Name} ");
                    i = j;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("How many activities are there? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string[] input;
            Activity[] activities = new Activity[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Activity #{i + 1}: ");
                input = Console.ReadLine().Split(" ");
                activities[i] = new Activity(input[0], int.Parse(input[1]), int.Parse(input[2]));
            }

            CalculateActivities(activities);
        }
    }
}

/*
8
a1 1 3
a2 0 4
a3 1 2
a4 4 6
a5 2 9
a6 5 8
a7 3 5
a8 4 5

a3 a7 a6
*/
