namespace Samples.DataStructures {
    public class LinkedList {
        private class Node {
            public int data;
            public Node Next;
            public Node (int data) {
                this.data = data;
            }
        }

        private Node Head;
        private int Size;

        public void AddHead (int data) {
            Node newNode = new Node (data);
            Size++;
            if (Head == null) {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddTail (int data) {
            Node newNode = new Node (data);
            Size++;
            if (Head == null) {
                Head = newNode;
                return;
            }

            var current = Head;

            while (current.Next != null) {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void Clear () {
            Head = null;
        }

        public void Delete (int data) {
            if (Head == null) {
                return;
            }

        }

        public void InsertAfter (int data) {

        }

        public void InsertBefore (int data) {

        }

    }
}