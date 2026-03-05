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


        public DoublyLinkedList()
        {
            
        }

        public void AddAfter(Node node, Node newNode)
        {
            if (node.ProvideNextNode() == null)
                Tail = newNode;
            node.InsertNewNodeAfterNode(newNode);
            Count++;
        }

        public void AddAfter(Node node, Data data)
        {
            Node newNode = new Node(data);
            if (node.ProvideNextNode() == null)
                Tail = newNode;
            AddAfter(node, newNode);
            Count++;
        }

        public void AddBefore(Node node, Node newNode)
        {
            if (node.ProvidePreviousNode() == null)
                Head = newNode;
            node.InsertNewNodaBeforeNoda(newNode);
            Count++;
        }

        public void AddBefore(Node node, Data data)
        {
            Node newNode = new Node(data);
            if (node.ProvidePreviousNode() == null)
                Head = newNode;
            AddBefore(node, newNode);
            Count++;
        }

        public void AddFirst(Node newNode)
        {
            Head.InsertNewNodeBeforeOldOne(newNode);
            Head = newNode;
            Count++;
        }

        public void AddFirst(Data data)
        {
            Node newNode = new Node(data);
            Head.InsertNewNodeBeforeOldOne(newNode);
            Head = newNode;
            Count++;
        }

        public void AddLast(Node newNode)
        {
            Tail.InsertNewNodeAfterOldOne(newNode);
            Tail = newNode;
            Count++;
        }

        public void AddLast(Data data)
        {
            Node newNode = new Node(data);
            Head.InsertNewNodeAfterOldOne(newNode);
            Head = newNode;
            Count++;
        }

        public void RemoveFirst()
        {
            Head = Head.ProvideNextNode();
            Head.RemoveHead();
            Count--;
        }

        public void RemoveLast()
        {
            Tail = Tail.ProvidePreviousNode();
            Tail.RemoveTail();
            Count--;
        }

    }
}
