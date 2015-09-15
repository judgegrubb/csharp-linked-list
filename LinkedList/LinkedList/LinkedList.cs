using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private class Node<E>
        {
            private E Data;
            private Node<E> Child;

            public Node()
            {
                Data = default(E);
                Child = null;
            }

            public Node(E d)
            {
                Data = d;
                Child = null;
            }

            public void setChild(Node<E> c)
            {
                Child = c;
            }

            public void setData(E d)
            {
                Data = d;
            }

            public E getData()
            {
                return Data;
            }

            public Node<E> getChild()
            {
                return Child;
            }
        }

        private Node<T> Head;
        private int Count;

        public LinkedList()
        {
            Head = null;
            Count = 0;
        }

        public void AddFirst(T data)
        {
            if (Count == 0)
            {
                Head = new Node<T>(data);
            }
            else
            {
                Node<T> Temp = new Node<T>(data);
                Temp.setChild(Head);
                Head = Temp;
            }

            Count++;
        }

        public T GetFirst()
        {
            return Head.getData();
        }

        public T PopFirst()
        {
            T returnData = Head.getData();
            Head = Head.getChild();
            Count--;
            return returnData;
        }

        public int getCount()
        {
            return Count;
        }

        public bool Contains(T data)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (!current.getData().Equals(data))
                {
                    current = current.getChild();
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void Reverse()
        {
            Node<T> prev = null;
            Node<T> current = Head;
            Node<T> next;

            while (current != null)
            {
                next = current.getChild();
                current.setChild(prev);
                prev = current;
                current = next;
            }
            Head = prev;
        }

        public void ReverseRecursive()
        {
            Head = ReverseRecursiveMethod(Head);
        }

        private Node<T> ReverseRecursiveMethod(Node<T> startingNode)
        {
            if (startingNode == null)
                return null;

            if (startingNode.getChild() == null)
                return startingNode;

            Node<T> rest = startingNode.getChild();

            startingNode.setChild(null);

            Node<T> reverseRest = ReverseRecursiveMethod(rest);

            rest.setChild(startingNode);

            return reverseRest;
        }

        public T[] ToArray()
        {
            T[] tArray = new T[Count];
            Node<T> current = Head;

            for (int i = 0; i < Count; i++)
            {
                tArray[i] = current.getData();
                current = current.getChild();
            }

            return tArray;
        }
    }
}
