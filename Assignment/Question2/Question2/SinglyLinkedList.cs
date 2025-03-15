using System;
using System.Text;

namespace Question2
{
	public class SinglyLinkedList<E>
    {
        private class Node<E>
        {   
            private E element;
            private Node<E> next;

            public Node(E e, Node<E> n)
            {
                element = e;
                next = n;
            }

            public E GetElement()
            {
                return element;
            }

            public Node<E> GetNext()
            {
                return next;
            }

            public void SetNext(Node<E> n)
            {
                next = n;
            }
        }

        private Node<E>? head = null;
        private Node<E>? tail = null;
        private int size = 0;

        public SinglyLinkedList() { }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
        public E First()
        {
            if (IsEmpty())
            {
                return default(E);
            }
            return head!.GetElement();

        }
        public E Last()
        {
            if (IsEmpty())
            {
                return default(E);
            }
            return tail!.GetElement();
        }
        public void AddFist(E e)
        {
            Node<E> newNode = new Node<E>(e, head);

            if (size == 0)
            {

                tail = head;
            }
            head = newNode;
            size++;
        }
        public void AddLast(E e)
        {
            Node<E> newNode = new Node<E>(e, null);
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                tail!.SetNext(newNode);
            }
            tail = newNode;

            size++;
  
        }
        public E RemoveFirst()
        {
            if (IsEmpty())
            {
                return default(E);
            }
            E answer = head.GetElement();
            head = head.GetNext();
            size--;
            if (size == 0)
            {
                tail = null;
            }
            return answer;

        }
        public override string ToString()
        {

            if (head == null)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            Node<E>? current = head;

            while (current != null)
            {
                sb.AppendLine(current.GetElement()!.ToString());
                current = current.GetNext();
            }
     
            return sb.ToString();
        }
    }
}

