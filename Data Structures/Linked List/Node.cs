namespace Linked_List
{
    public class Node
    {
        private int data;
        private Node next;

        public int Data
        {
            get => this.data;
            set => this.data = value;
        }

        public Node Next
        {
            get => this.next;
            set => this.next = value;
        }

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
