using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BinaryTreeProject.Models
{
    public class Root
    {
        private int Key { get; set; }
        private Data Data { get; set; }
        private Root Left { get; set; }
        private Root Right { get; set; }

        public Root(int key, Data data)
        {
            Key = key;
            Data = data;
            Left = null;
            Right = null;
            
        }

        public int GetKey()
        { 
            return Key;
        }

        public Root GetRight()
        {
            return Right;
        }

        public Root GetLeft() 
        {
            return Left;
        }

        public void AddLeftRoot(Root root)
        {
            Left = root;
        }

        public void AddRigthRoot(Root root)
        {
            Right = root;
        }

        public override string ToString()
        {
            return "┌──────────────────────────────\n" +
                    $"│ Key : {Key}\n" +
                    $"│ Data : {Data.ToString()}\n" +
                    "└──────────────────────────────";
        }
    }
}
