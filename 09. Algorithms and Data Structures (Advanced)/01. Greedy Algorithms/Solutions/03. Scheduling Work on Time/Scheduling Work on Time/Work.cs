using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Work_on_Time
{
    class Work
    {
        private string name;
        private int deadline;
        private int prize;

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int Deadline
        {
            get => this.deadline;
            set => this.deadline = value;
        }

        public int Prize 
        {
            get => this.prize;
            set => this.prize = value;
        }

        public Work(string name, int deadline, int prize)
        {
            this.Name = name;
            this.Deadline = deadline;
            this.Prize = prize;
        }
    }
}
