using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

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
            NextNode.PreviousNode = newNode;

            newNode.NextNode = NextNode;
            newNode.PreviousNode = this;

            NextNode = newNode;
        }

        public void InsertNewNodeInTailAfterNode(Node newNode)
        {
            newNode.PreviousNode = this;
            NextNode = newNode;
        }

        public void InsertNewNodaBeforeNoda(Node newNode)
        {
            PreviousNode.NextNode = newNode;

            newNode.PreviousNode = PreviousNode;
            newNode.NextNode = this;

            PreviousNode = newNode;
        }

        public void InsertNewNodeInHeadBeforeNode(Node newNode)
        {
            newNode.NextNode = this;
            PreviousNode = newNode;
            
        }

        public void RemovePreviousNode()
        {
            Date = null;
            PreviousNode = null;
        }

        public void RemoveNextNode()
        {
            Date = null;
            NextNode = null;
        }
        
        public Data GetData()
        {
            return Date;
        }

        public string ShowInfo()
        {
            if (!IsPreviousNodeNull())
            {
                if (!IsNextNodeNull())
                {
                    return ShowNode();
                }
                else
                {
                    return ShowWithoutNextNode();
                }
            }
            else
            {
                return ShowWithoutPreviousNode();
            }
        }

        public string ShowWithoutPreviousNode()
        {
            string next = NextNode != null ? NextNode.Date.ShowDataInfo() : "null";

            return "┌──────────────────────────────\n" +
                    $"│ Prev : null\n" +
                    $"│ This : {Date.ShowDataInfo()}\n" +
                    $"│ Next : {next}\n" +
                    "└──────────────────────────────";
        }

        public string ShowNode()
        {
            string prev = PreviousNode != null ? PreviousNode.Date.ShowDataInfo() : "null";
            string next = NextNode != null ? NextNode.Date.ShowDataInfo() : "null";

            return "┌──────────────────────────────\n" +
                    $"│ Prev : {prev}\n" +
                    $"│ This : {Date.ShowDataInfo()}\n" +
                    $"│ Next : {next}\n" +
                    "└──────────────────────────────";
        }

        public string ShowWithoutNextNode()
        {
            string prev = PreviousNode != null ? PreviousNode.Date.ShowDataInfo() : "null";

            return "┌──────────────────────────────\n" +
                    $"│ Prev : {prev}\n" +
                    $"│ This : {Date.ShowDataInfo()}\n" +
                    $"│ Next : null\n" +
                    "└──────────────────────────────";
        }

        public override string ToString()
        {
            return $"ThisNode - {Date.ShowDataInfo()}";
        }

    }
}
