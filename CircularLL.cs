using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }
        public Node(int Data)
        {
            this.Data = Data;
            this.Next = null;
        }
    }
    public class CircularLinkedList
    {
        public Node Head;
        public Node Tail;
        public int Count;

        public CircularLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddNode(int Data)
        {
            Node NewNode = new Node(Data);
            if (Head == null)
            {
                Head=NewNode;
                Tail = NewNode;
                Tail.Next = Head;           
            }
            else
            {
                Tail.Next = NewNode;
                Tail = NewNode;
                Tail.Next = Head;
            }
            Count++;
        }
        public void DeleteNode(int Data)
        {
            if (Head == null)
            {
                return;
            }
           if (Head.Data == Data)
                {
                if (Head.Next == Head)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Tail.Next = Head.Next;
                     Head=Head.Next;
                }
                Count--;
                return;
            }
            Node Current = Head.Next;
            while (Current != Head)
            {
                if (Current.Data == Data)
                {
                    Node Prev = Head;
                    while (Prev.Next != Current)
                    {
                        Prev = Prev.Next;
                    }
                    Prev.Next = Current.Next;
                    if (Current == Tail)
                    {
                        Tail = Prev;
                    }
                    Count--;
                    return;
                }
                Current = Current.Next;
            }
        }

        public void Display()
        {
            if (Head == null)
            {
                return;
            }
            else 
            {
                Node Current = Head;
                do
                {
                    Console.WriteLine(Current.Data);
                    Current = Current.Next;
                } while (Current != Head);
            }
            
        }
    }
    internal class CircularLL
    {
        public static void Main(string[] args)
        {
            CircularLinkedList CLL = new CircularLinkedList();
            CLL.AddNode(1);
            CLL.AddNode(2);
            CLL.AddNode(3);
            CLL.AddNode(4);
            CLL.AddNode(5);
            CLL.AddNode(6);
            CLL.AddNode(7);
            CLL.AddNode(8);

            CLL.Display();

            Console.WriteLine("**********");
            CLL.DeleteNode(5);
            CLL.DeleteNode(6);
            Console.WriteLine("**********");
            CLL.Display();
        }
    }
}
