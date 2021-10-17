namespace Graphs
{
    class Node<T>
    {
        private T value;

        public T Value
        {
            get => this.value;
            set => this.value = value;
        }

        public Node(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
