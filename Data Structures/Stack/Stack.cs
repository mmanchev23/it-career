using System;

namespace Stack
{
    public class Stack
    {
        private int[] elements;
        private int top;
        private int max;

        public int[] Elements
        {
            get => this.elements;
            set => this.elements = value;
        }

        public int Top
        {
            get => this.top;
            set => this.top = value;
        }

        public int Max
        {
            get => this.max;
            set => this.max = value;
        }

        public Stack(int size)
        {
            this.Elements = new int[size];
            this.Top = -1;
            this.Max = size;
        }

        public void Push(int item)
        {
            if (this.Top == this.Max - 1)
            {
                Console.WriteLine("Stack Overflow!");
                return;
            }
            else
            {
                this.Elements[++this.Top] = item;
            }
        }

        public int Pop()
        {
            if (this.Top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            else
            {
                Console.WriteLine($"{this.Elements[this.Top]} popped from stack!");
                return this.Elements[this.Top--];
            }
        }

        public int Peek()
        {
            if (this.Top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            else
            {
                Console.WriteLine($"{this.Elements[this.Top]} popped from stack!");
                return this.Elements[this.Top];
            }
        }

        public void PrintStack()
        {
            if (this.Top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            else
            {
                for (int i = 0; i <= this.Top; i++)
                {
                    Console.WriteLine($"{this.Elements[i]} pushed into stack!");
                }
            }
        }
    }
}
