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
            Data data = new Data("Walter", "White");
            Node node = new Node(data);
            
            var doublyLinkedList = new DoublyLinkedList(node);
            
            Data data1 = new Data("Jesse", "Pinkman");
            Node node1 = new Node(data1);

            doublyLinkedList.AddLast(data1);

            Data data2 = new Data("Saul", "Goodman");
            Node node2 = new Node(data2);

            doublyLinkedList.AddLast(data2);

            Data data3 = new Data("Gus", "Fring");
            Node node3 = new Node(data3);

            doublyLinkedList.AddLast(data3);

            doublyLinkedList.ShowAllNodes();

            Console.ReadLine();
        }
    }
}
