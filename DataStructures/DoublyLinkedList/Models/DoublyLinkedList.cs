using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListProject.Models
{
    public class DoublyLinkedList
    {
        private Node Head { get; set; }
        private Node Tail { get; set; }
        private int Count { get; set; }


        public DoublyLinkedList(Node node)
        {
            Head = node;
            Tail = node;
            Count++;
        }

        public void AddAfter(Node node, Node newNode)
        {
            if (Count == 0)
            {
                Console.WriteLine("You can`t use this method when list is null");
                return;
            }
            if (node.IsNextNodeNull())
            {
                node.InsertNewNodeInTailAfterNode(newNode);
                Tail = newNode;
                Count++;
            }
            else
            {
                node.InsertNewNodeAfterNode(newNode);
                Count++;
            }
        }

        public void AddAfter(Node node, Data data)
        {
            if (Count == 0)
            {
                Console.WriteLine("You can`t use this method when list is null");
                return;
            } 
            Node newNode = new Node(data);
            AddAfter(node, newNode);
        }

        public void AddBefore(Node node, Node newNode)
        {
            if (Count == 0)
            {
                Console.WriteLine("You can`t use this method when list is null");
                return;
            }
            if (node.IsPreviousNodeNull())
            {
                node.InsertNewNodeInHeadBeforeNode(newNode);
                Head = newNode;
                Count++;
            }
            else
            {
                node.InsertNewNodaBeforeNoda(newNode);
                Count++;
            }
        }

        public void AddBefore(Node node, Data data)
        {
            if (Count == 0)
            {
                Console.WriteLine("You can`t use this method when list is null");
                return;
            }
            Node newNode = new Node(data);
            AddBefore(node, newNode);
        }

        public void AddFirst(Node newNode)
        {
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Head.InsertNewNodeInHeadBeforeNode(newNode);
                Head = newNode;
            }
            Count++;
        }

        public void AddFirst(Data data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Head.InsertNewNodeInHeadBeforeNode(newNode);
                Head = newNode;
            }
            Count++;
        }

        public void AddLast(Node newNode)
        {
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.InsertNewNodeInTailAfterNode(newNode);
                Tail = newNode;
            }
            Count++;
        }

        public void AddLast(Data data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.InsertNewNodeInTailAfterNode(newNode);
                Tail = newNode;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            if (Tail.IsPreviousNodeNull())
            {
                Clear();
                return;
            }
            Head = Head.ProvideNextNode();
            Head.RemovePreviousNode();
            Count--;
            
        }

        public void RemoveLast()
        {
            if (Head.IsNextNodeNull())
            {
                Clear();
                return;
            }
            Tail = Tail.ProvidePreviousNode();
            Tail.RemoveNextNode();
            Count--;
        }

        public Node Find(Data value)
        {
            if (Count == 0)
            {
                Console.WriteLine("DoublyLinkedList is null");
            }
            else
            {
                int count = Count;
                Node iterateNode = Head;
                while (count > 0)
                {
                    if (iterateNode.GetData() == value)
                    { 
                        return iterateNode;
                    }
                    iterateNode = iterateNode.ProvideNextNode();
                }
            }
            return null;
        }

        public bool Contains(Data value)
        {
            if (Count == 0)
            {
                Console.WriteLine("You can`t use this method when list is null");
            }
            else
            {
                int count = Count;
                Node iterateNode = Head;
                while (count > 0)
                {
                    if (iterateNode.GetData() == value)
                    {
                        return true;
                    }
                    iterateNode = iterateNode.ProvideNextNode();
                    count--;
                }
            }
                
            return false;
        }

        public void Clear()
        {
            Console.WriteLine("DoublyLinkedList is null");
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void ShowAllNodes()
        {
            if (Count == 0)
            { 
                Console.WriteLine("DoublyLinkedList is null");
                return;
            }

            int count = Count;
            Node iterateNode = Head;
            while (count > 0)
            {
                Console.WriteLine(iterateNode.ShowInfo());
                iterateNode = iterateNode.ProvideNextNode();
                count--;
            }
        }
    }
}
