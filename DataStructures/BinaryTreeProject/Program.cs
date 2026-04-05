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

            BinaryTree<int> binaryTree = new BinaryTree<int>();
            

            // ЛІВА СТОРОНА
            binaryTree.Insert(30);
            binaryTree.Insert(20);
            binaryTree.Insert(40);
            binaryTree.Insert(10);
            binaryTree.Insert(25);
            binaryTree.Insert(35);
            binaryTree.Insert(45);

            // ПРАВА СТОРОНА
            binaryTree.Insert(70);
            binaryTree.Insert(60);
            binaryTree.Insert(80);
            binaryTree.Insert(55);
            binaryTree.Insert(65);
            binaryTree.Insert(75);
            binaryTree.Insert(85);


            binaryTree.ShowBinaryTree();
        }
    }
}
