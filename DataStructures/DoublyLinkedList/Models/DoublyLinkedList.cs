using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.Models
{
    public class DoublyLinkedList<T>
    {
        private Noda Head { get; set; }
        private Noda Tail { get; set; }
        private int Count { get; set; }


        public DoublyLinkedList()
        { 
            
        }

        public void AddAfter(Noda node, Noda newNode)
        {
            node.ConnectNewNodaToNext(newNode);
            newNode.ConnectNewNodaToPrevious(node);
        }

        

    }
}
