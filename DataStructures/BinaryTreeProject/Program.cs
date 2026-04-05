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

            // ЛІВА СТОРОНА
            binaryTree.Insert(new Root(30, new Data("Skyler", "White")));
            binaryTree.Insert(new Root(20, new Data("Hank", "Schrader")));
            binaryTree.Insert(new Root(40, new Data("Marie", "Schrader")));
            binaryTree.Insert(new Root(10, new Data("Gustavo", "Fring")));
            binaryTree.Insert(new Root(25, new Data("Saul", "Goodman")));
            binaryTree.Insert(new Root(35, new Data("Mike", "Ehrmantraut")));
            binaryTree.Insert(new Root(45, new Data("Tuco", "Salamanca")));

            // ПРАВА СТОРОНА
            binaryTree.Insert(new Root(70, new Data("Jesse", "Pinkman")));
            binaryTree.Insert(new Root(60, new Data("Jane", "Margolis")));
            binaryTree.Insert(new Root(80, new Data("Lydia", "Rodarte-Quayle")));
            binaryTree.Insert(new Root(55, new Data("Andrea", "Cantillo")));
            binaryTree.Insert(new Root(65, new Data("Todd", "Alquist")));
            binaryTree.Insert(new Root(75, new Data("Gale", "Boetticher")));
            binaryTree.Insert(new Root(85, new Data("Eladio", "Vuente")));

            binaryTree.DestroyTree();

            binaryTree.ShowBinaryTree();
        }
    }
}
