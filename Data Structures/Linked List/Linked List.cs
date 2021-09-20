using System;

namespace Linked_List
{
    public class Linked_List
    {
        private Node head;

        public Node Head
        {
            get => this.head;
            set => this.head = value;
        }

        public Linked_List() { }

        public void PrintLinkedList()
        {
            Node node = this.Head;

            while (node != null)
            {
                Console.Write($"{node.Data} ");
                node = node.Next;
            }
        }

        public Node GetLastNode(Linked_List linked_list)
        {
            Node node = linked_list.Head;

            while (node.Next != null)
            {
                node = node.Next;
            }

            return node;
        }

        public void InsertDataFront(Linked_List linked_list, int data)
        {
            Node node = new Node(data);
            node.Next = linked_list.Head;
            linked_list.Head = node;
        }

        public void InsertDataBack(Linked_List linked_list, int data)
        {
            Node node = new Node(data);

            if (linked_list.Head == null)
            {
                linked_list.Head = node;
                return;
            }

            Node last_node = GetLastNode(linked_list);
            last_node.Next = node;
        }

        public void InsertDataAfterNode(Node node, int data)
        {
            if (node == null)
            {
                Console.WriteLine("Previous node can not be null!");
                return;
            }

            Node new_node = new Node(data);
            new_node.Next = node.Next;
            node.Next = new_node;
        }

        public void DeleteNodeByKey(Linked_List linked_list, int key)
        {
            Node head = linked_list.Head;
            Node previous_node = null;

            if (head != null && head.Data == key)
            {
                linked_list.Head = head.Next;
                return;
            }

            while (head != null && head.Data != key)
            {
                previous_node = head;
                head = head.Next;
            }

            if (head == null)
            {
                return;
            }
            previous_node.Next = head.Next;
        }

        public void Reverse(Linked_List linked_list)
        {
            Node previous_node = null;
            Node current_node = linked_list.Head;
            Node node = null;

            while (current_node != null)
            {
                node = current_node.Next;
                current_node.Next = previous_node;
                previous_node = current_node;
                current_node = node;
            }

            linked_list.Head = previous_node;
        }
    }
}
