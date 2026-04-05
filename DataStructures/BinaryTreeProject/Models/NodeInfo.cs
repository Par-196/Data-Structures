using BinaryTreeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject.Models
{
    public class NodeInfo<T>
    {
        public Root<T> Node;
        public string Text;
        public int StartPos;
        public int Size => Text.Length;
        public int EndPos { get => StartPos + Size; set => StartPos = value - Size; }
        public NodeInfo<T> Parent, Left, Right;
    }
}
