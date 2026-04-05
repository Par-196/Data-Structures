using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DoublyLinkedListProject.Models
{
    public class Node<T>
    {
        private T Data { get; set; }
        private Node<T> NextNode { get; set; }
        private Node<T> PreviousNode { get; set; }


        public Node(T data)
        {
            Data = data;
            NextNode = null;
            PreviousNode = null;
        }

        public Node<T> ProvideNextNode()
        {
            return NextNode;
        }

        public Node<T> ProvidePreviousNode()
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

        public void InsertNewNodeAfterNode(Node<T> newNode)
        {
            NextNode.PreviousNode = newNode;

            newNode.NextNode = NextNode;
            newNode.PreviousNode = this;

            NextNode = newNode;
        }

        public void InsertNewNodeInTailAfterNode(Node<T> newNode)
        {
            newNode.PreviousNode = this;
            NextNode = newNode;
        }

        public void InsertNewNodaBeforeNoda(Node<T> newNode)
        {
            PreviousNode.NextNode = newNode;

            newNode.PreviousNode = PreviousNode;
            newNode.NextNode = this;

            PreviousNode = newNode;
        }

        public void InsertNewNodeInHeadBeforeNode(Node<T> newNode)
        {
            newNode.NextNode = this;
            PreviousNode = newNode;
            
        }

        public void RemovePreviousNode()
        {
            PreviousNode = null;
        }

        public void RemoveNextNode()
        {
            NextNode = null;
        }
        
        public T GetData()
        {
            return Data;
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
            string next = NextNode != null ? NextNode.Data.ToString() : "null";

            return "┌──────────────────────────────\n" +
                    $"│ Prev : null\n" +
                    $"│ This : {Data.ToString()}\n" +
                    $"│ Next : {next}\n" +
                    "└──────────────────────────────";
        }

        public string ShowNode()
        {
            string prev = PreviousNode != null ? PreviousNode.Data.ToString() : "null";
            string next = NextNode != null ? NextNode.Data.ToString() : "null";

            return "┌──────────────────────────────\n" +
                    $"│ Prev : {prev}\n" +
                    $"│ This : {Data.ToString()}\n" +
                    $"│ Next : {next}\n" +
                    "└──────────────────────────────";
        }

        public string ShowWithoutNextNode()
        {
            string prev = PreviousNode != null ? PreviousNode.Data.ToString() : "null";

            return "┌──────────────────────────────\n" +
                    $"│ Prev : {prev}\n" +
                    $"│ This : {Data.ToString()}\n" +
                    $"│ Next : null\n" +
                    "└──────────────────────────────";
        }

        public override string ToString()
        {
            return $"ThisNode - {Data.ToString()}";
        }

    }
}
