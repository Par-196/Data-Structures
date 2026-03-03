using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.Models
{
    public class Noda
    {
        private Data Date { get; set; }
        private Noda PreviousNode { get; set; }
        private Noda NextNode { get; set; }

        public Noda(Data data) 
        {
            Date = data;
            PreviousNode = null;
            NextNode = null;
        }
    }
}
