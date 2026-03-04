using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoublyLinkedListProject.Models
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

        public void InsertNewNodaAfterNoda(Noda newNode)
        {
            newNode.NextNode = NextNode;
            newNode.PreviousNode = this;

            NextNode.PreviousNode = newNode;
            NextNode = newNode;
        }


    }
}
