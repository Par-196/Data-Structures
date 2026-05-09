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

            doublyLinkedList.AddLast("Ivan");

            doublyLinkedList.AddLast("Vitalik");

            doublyLinkedList.AddFirst("Artur");

            doublyLinkedList.AddAfter(node, "Rostyk");

            doublyLinkedList.ShowAllNodes();

            Console.ReadLine();
        }
    }
}
