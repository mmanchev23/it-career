using System;

namespace Activities_Assignment
{
    public class Activity
    {
        private string name;
        private int start;
        private int finish;

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public int Start
        {
            get => this.start;
            set => this.start = value;
        }
        public int Finish
        {
            get => this.finish;
            set => this.finish = value;
        }

        public Activity(string name, int start, int finish)
        {
            this.Name = name;
            this.Start = start;
            this.Finish = finish;
        }
    }
}
