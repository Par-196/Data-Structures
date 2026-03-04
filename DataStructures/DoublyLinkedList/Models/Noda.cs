using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoublyLinkedList.Models
{
    public class Noda
    {
        private Data Date { get; set; }
        private Noda NextNode { get; set; }
        private Noda PreviousNode { get; set; }
        

        public Noda(Data data) 
        {
            Date = data;
            NextNode = null;
            PreviousNode = null;
        }

        public void ConnectNewNodaToNext(Noda newNode)
        {
            newNode.NextNode = NextNode;

            NextNode = newNode;

            NextNode.PreviousNode = newNode;
        }

        public void ConnectNewNodaToPrevious(Noda node)
        {
            PreviousNode = node;
        }

    }
}
