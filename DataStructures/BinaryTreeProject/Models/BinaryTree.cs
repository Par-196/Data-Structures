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
        private int Count { get; set; }

        public BinaryTree() 
        {
            Root = null;
        }

        public void Insert(T value)
        {
            if(Root == null)
            {
                Root = new Root<T>(value);
                Count++;
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
                        Count++;
                        return;
                    }
                    current = current.GetRightRoot();
                }
                else
                {
                    if (current.GetLeftRoot() == null)
                    {
                        current.SetLeftRoot(newValue);
                        Count++;
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

        public int GetCount()
        {
            return Count;
        }


        public void ShowBinaryTree()
        {
            PrintTree(Root);
        }

        private void PrintTree(Root<T> root, string textFormat = "0", int spacing = 1, int topMargin = 2, int leftMargin = 5)
        {
            if (root == null) return;

            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInfo<T>>();
            var next = root;

            for (int level = 0; next != null; level++)
            {
                var item = new NodeInfo<T>
                {
                    Node = next,
                    Text = next.GetValue().ToString()
                };

                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + spacing;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = leftMargin;
                    last.Add(item);
                }

                if (level > 0)
                {
                    item.Parent = last[level - 1];

                    if (next == item.Parent.Node.GetLeftRoot())
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos - 1);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos + 1);
                    }
                }

                next = next.GetLeftRoot() ?? next.GetRightRoot();

                for (; next == null; item = item.Parent)
                {
                    int top = rootTop + 2 * level;

                    Print(item.Text, top, item.StartPos);

                    if (item.Left != null)
                    {
                        Print("/", top + 1, item.Left.EndPos);
                        Print("_", top, item.Left.EndPos + 1, item.StartPos);
                    }

                    if (item.Right != null)
                    {
                        Print("_", top, item.EndPos, item.Right.StartPos - 1);
                        Print("\\", top + 1, item.Right.StartPos - 1);
                    }

                    if (--level < 0) break;

                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos + 1;
                        next = item.Parent.Node.GetRightRoot();
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos - 1;
                        else
                            item.Parent.StartPos += (item.StartPos - 1 - item.Parent.EndPos) / 2;
                    }
                }
            }

            Console.SetCursorPosition(0, rootTop + 2 * last.Count);
        }

        private void Print(string s, int top, int left, int right = -1)
        {
            Console.SetCursorPosition(left, top);

            if (right < 0)
                right = left + s.Length;

            while (Console.CursorLeft < right)
                Console.Write(s);
        }

        public override string ToString()
        {
            return $"\n\n{Root.ToString()}\n\n";
        }
    }
}
