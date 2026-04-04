using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject.Models
{
    public class BinaryTree
    {
        private Root Root { get; set; }

        public BinaryTree(Root root) 
        {
            Root = root;
        }

        public void Insert(Root newRoot)
        {
            Root current = Root;
            bool rootWasInserted = false;
            while (!rootWasInserted)
            { 
                if (newRoot.GetKey() > current.GetKey())
                {
                    if (current.GetRight() == null)
                    {
                        current.AddRigthRoot(newRoot);
                        Console.WriteLine("Inserted right");
                        rootWasInserted = true;
                        return;
                    }
                    current = current.GetRight();
                }
                else if (newRoot.GetKey() < current.GetKey())
                {

                    if (current.GetLeft() == null)
                    {
                        current.AddLeftRoot(newRoot);
                        Console.WriteLine("Inserted left");
                        rootWasInserted = true;
                        return;
                    }
                    current = current.GetLeft();
                }
                else if (newRoot.GetKey() == Root.GetKey())
                {
                    Console.WriteLine("Duplicate key, try another");
                }
            }
        }

        public Root Search(Root lookingForRoot)
        {
            Root current = Root;
            bool rootWasInserted = false;
            while (!rootWasInserted)
            {
                if (current == null)
                    break;
                if (lookingForRoot.GetKey() == current.GetKey())
                {
                    return current;
                }
                current = lookingForRoot.GetKey() < current.GetKey() 
                    ? current.GetLeft() 
                    : current.GetRight();
            }
            Console.WriteLine("Root not found");
            return null; 
        }

        public Root Search(int lookingForRoot)
        {
            Root current = Root;
            bool rootWasInserted = false;
            while (!rootWasInserted)
            {
                if (current == null)
                    break;
                if (lookingForRoot == current.GetKey())
                {
                    return current;
                }
                current = lookingForRoot < current.GetKey()
                    ? current.GetLeft()
                    : current.GetRight();
            }
            Console.WriteLine("Root not found");
            return null;
        }


        public void DestroyTree()
        {
            Root current = Root;
            Root rightSideBinaryTree = RightSideBinaryTree(current);
            current = LeftSideBinaryTree(current);
            while (current != rightSideBinaryTree.GetRight())
            {

            }

        }

        public void ShowBinaryTree()
        {
            Root current = Root;
            Root rightSideBinaryTree = RightSideBinaryTree(current);
            current = LeftSideBinaryTree(current);
            while (current != rightSideBinaryTree.GetRight())
            { 
                
            }

        }

        public Root LeftSideBinaryTree(Root current)
        {
            if (current.GetLeft() == null)
                return current;
            current = current.GetLeft();
            LeftSideBinaryTree(current);
            return null;
        }

        public Root RightSideBinaryTree(Root current)
        {
            if (current.GetRight() == null)
                return current;
            current = current.GetRight();
            RightSideBinaryTree(current);
            return null;
        }

        public override string ToString()
        {
            return $"\n\n{Root.ToString()}\n\n";
        }
    }
}
