using System;
using System.IO;
using System.Linq;

namespace State_Matriculation_Exam_Preparation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream_reader = new StreamReader(@"./data.txt");

            while (!stream_reader.EndOfStream)
            {
                int type_of_vehicle = int.Parse(stream_reader.ReadLine());
                string brand = stream_reader.ReadLine();
                int[] properties = stream_reader.ReadLine().Split().Select(int.Parse).ToArray();

                if (type_of_vehicle == 1)
                {
                    Console.WriteLine(new Car(brand, properties[0], properties[1], properties[2]).ToString());
                }
                else if (type_of_vehicle == 2)
                {
                    Console.WriteLine(new Truck(brand, properties[0], properties[1], properties[2], properties[3]).ToString());
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }

            stream_reader.Close();
        }
    }
}
