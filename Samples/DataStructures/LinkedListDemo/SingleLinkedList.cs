using System;
namespace Samples.DataStructures.LinkedListDemo
{
    public class SingleLinkedList
    {
        private class Node
        {
            public int Data;
            public Node Next;
            public Node(int data)
            {
                Data = data;
            }

        }

        private Node Head;
        private Node Tail;
        private int Size;


        public void InsertHead(int data)
        {
            Node newNode = new Node(data);
            Size++;
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
        }

        public void InsertTail(int data)
        {
            Node newNode = new Node(data);
            Size++;
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            Tail.Next = newNode;
            Tail = Tail.Next;
        }

        public int GetHead()
        {
            if (Head != null)
            {
                return Head.Data;
            }
            throw new IndexOutOfRangeException();
        }

        public int GetTail()
        {
            if (Tail != null)
            {
                return Tail.Data;
            }
            throw new IndexOutOfRangeException();
        }



    }
}