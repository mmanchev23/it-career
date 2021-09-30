using System;
using System.IO;
using System.Collections.Generic;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream_reader = new StreamReader(@"data.txt");
            Stack<Car> results = new Stack<Car>();

            while (!stream_reader.EndOfStream)
            {
                int type_of_vehicle = int.Parse(stream_reader.ReadLine());
                string brand = stream_reader.ReadLine();
                string[] properties = stream_reader.ReadLine().Split();

                if (type_of_vehicle == 1)
                {
                    results.Push(new Car(brand, int.Parse(properties[0]), int.Parse(properties[1]), double.Parse(properties[2])));
                }
                else if (type_of_vehicle == 2)
                {
                    results.Push(new Truck(brand, int.Parse(properties[0]), int.Parse(properties[1]), double.Parse(properties[2]), int.Parse(properties[3])));
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            stream_reader.Close();
        }
    }
}
