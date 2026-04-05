using DoublyLinkedListProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var node = new Node<string>("Yura");
            
            var doublyLinkedList = new DoublyLinkedList<string>(node);

            var node1 = new Node<string>("Vova");

            doublyLinkedList.AddLast(node1);

            var node2 = new Node<string>("Ivan");

            doublyLinkedList.AddLast("Ivan");

            var node3 = new Node<string>("Vitalik");

            doublyLinkedList.AddLast("Vitalik");

            doublyLinkedList.ShowAllNodes();

            Console.ReadLine();
        }
    }
}
