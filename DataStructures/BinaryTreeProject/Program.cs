using BinaryTreeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data("Walter", "White");
            Root root1 = new Root(50, data);
            
            BinaryTree binaryTree = new BinaryTree(root1);

            Data data2 = new Data("Jesse", "Pinkman");
            Root root2 = new Root(51, data2);

            binaryTree.Insert(root2);

            Data data3 = new Data("Jesse", "Pinkman");
            Root root3 = new Root(46, data2);

            binaryTree.Insert(root3);

            Console.WriteLine($"{binaryTree.Search(46)}");
        }
    }
}
