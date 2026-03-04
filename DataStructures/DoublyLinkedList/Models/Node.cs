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

        public void InsertNewNodaAfterNoda(Node newNode)
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

    }
}
