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
        private Node<T> Tail;
        private int Count;

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddLast(T data)
        {
            if (Count == 0)
            {
                Head = new Node<T>(data);
                Tail = Head;
            }
            else
            {
                Node<T> Temp = new Node<T>(data);
                Tail.setChild(Temp);
                Tail = Temp;
            }

            Count++;
        }

        public T GetLast()
        {
            return Tail.getData();
        }

        public void AddFirst(T data)
        {
            if (Count == 0)
            {
                Head = new Node<T>(data);
                Tail = Head;
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

        public T PopLast()
        {
            T returnData = Tail.getData();
            Tail = FindSecondToLast();
            Tail.setChild(null);
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

        private Node<T> FindSecondToLast()
        {
            Node<T> current = Head;
            while (current.getChild() != null && current.getChild() != Tail)
            {
                current = current.getChild();
            }

            return current;
        }
    }
}
