using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject.Models
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        private Root<T> Root { get; set; }

        public BinaryTree() 
        {
            Root = null;
        }

        public void Insert(T value)
        {
            if(Root == null)
            {
                Root = new Root<T>(value);
                return;
            }

            Root<T> current = Root;
            var newValue = new Root<T>(value);

            while (true)
            {
                if (value.CompareTo(current.GetValue()) >= 0)
                {
                    if (current.GetRightRoot() == null) 
                    {
                        current.SetRigthRoot(newValue);
                        return;
                    }
                    current = current.GetRightRoot();
                }
                else
                {
                    if (current.GetLeftRoot() == null)
                    {
                        current.SetLeftRoot(newValue);
                        return;
                    }
                    current = current.GetLeftRoot();
                }
            }
        }

        public Root<T> Search(T value)
        {
            Root<T> current = Root;

            while (current != null)
            {
                if (value.CompareTo(current.GetValue()) == 0)
                {
                    return current;
                }
                current = value.CompareTo(current.GetValue()) < 0
                    ? current.GetLeftRoot() 
                    : current.GetRightRoot();
            }
            Console.WriteLine("Root not found");
            return null; 
        }

        public void DestroyTree()
        {
            Root = null;
        }



        
        public void ShowBinaryTree()
        {
            Root<T> current = Root;
            ShowIteration(current);
        }

        private void ShowIteration(Root<T> current)
        {
            if (current == null)
                return;
            ShowIteration(current.GetLeftRoot());
            Console.WriteLine(current.ToString());
            ShowIteration(current.GetRightRoot());
        }

        public override string ToString()
        {
            return $"\n\n{Root.ToString()}\n\n";
        }
    }
}
