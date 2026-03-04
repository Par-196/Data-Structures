using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListProject.Models
{
    public class DoublyLinkedList
    {
        private Noda Head { get; set; }
        private Noda Tail { get; set; }
        private int Count { get; set; }


        public DoublyLinkedList()
        { 
            
        }

        public void AddAfter(Noda node, Noda newNode)
        {
            node.InsertNewNodaAfterNoda(newNode);
        }

        public void AddAfter(Noda node, Data data)
        {
            Noda newNoda = new Noda(data);
            AddAfter(node, newNoda);
        }

    }
}
