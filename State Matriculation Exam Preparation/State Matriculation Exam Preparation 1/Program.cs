using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace State_Matriculation_Exam_Preparation_1
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
                double[] properties = stream_reader.ReadLine().Split().Select(double.Parse).ToArray();

                if (type_of_vehicle == 1)
                {
                    results.Push(new Car(brand, (int)(properties[0]), (int)(properties[1]), properties[2]));
                }
                else if (type_of_vehicle == 2)
                {
                    results.Push(new Truck(brand, (int)(properties[0]), (int)(properties[1]), properties[2], (int)(properties[3])));
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
