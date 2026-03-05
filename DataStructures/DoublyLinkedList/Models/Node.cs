using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoublyLinkedListProject.Models
{
    public class Node
    {
        private Data Date { get; set; }
        private Node NextNode { get; set; }
        private Node PreviousNode { get; set; }
        

        public Node(Data data) 
        {
            Date = data;
            NextNode = null;
            PreviousNode = null;
        }

        public Node ProvideNextNode()
        {
            return NextNode;
        }

        public Node ProvidePreviousNode()
        {
            return PreviousNode;
        }

        public bool IsNextNodeNull()
        {
            return NextNode == null ? true : false;
        }

        public bool IsPreviousNodeNull()
        {
            return PreviousNode == null ? true : false;
        }

        public void InsertNewNodeAfterNode(Node newNode)
        {
            newNode.NextNode = NextNode;
            newNode.PreviousNode = this;

            NextNode.PreviousNode = newNode;
            NextNode = newNode;
        }

        public void InsertNewNodaBeforeNoda(Node newNode)
        {
            newNode.PreviousNode = PreviousNode;
            newNode.NextNode = this;

            PreviousNode.NextNode = newNode;
            PreviousNode = newNode;
        }

        public void InsertNewNodeBeforeOldOne(Node newNode)
        {
            PreviousNode = newNode;
            newNode.NextNode = this;
        }

        public void InsertNewNodeAfterOldOne(Node newNode)
        {
            NextNode = newNode;
            newNode.PreviousNode = this;
        }

        public void RemoveHead()
        {
            PreviousNode = null;
        }

        public void RemoveTail()
        {
            NextNode = null;
        }
    }
}
