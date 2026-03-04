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
            node.InsertNewNodaAfterNoda(newNode);
        }

        public void AddAfter(Node node, Data data)
        {
            Node newNoda = new Node(data);
            AddAfter(node, newNoda);
        }

        public void AddBefore(Node node, Node newNode)
        {
            node.InsertNewNodaBeforeNoda(newNode);
        }

        public void AddBefore(Node node, Data data)
        {
            Node newNoda = new Node(data);
            AddBefore(node, newNoda);
        }

    }
}
