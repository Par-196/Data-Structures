using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BinaryTreeProject.Models
{
    public class Root<T>
    {
        private T Data { get; set; }
        private Root<T> Left { get; set; }
        public Root<T> Right { get; set; }

        public Root(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public T GetValue()
        { 
            return Data;
        }

        public Root<T> GetRightRoot()
        {
            return Right;
        }

        public Root<T> GetLeftRoot() 
        {
            return Left;
        }

        public void SetLeftRoot(Root<T> root)
        {
            Left = root;
        }

        public void SetRigthRoot(Root<T> root)
        {
            Right = root;
        }

        public override string ToString()
        {
            return "┌───────────────\n" +
                    $"│ Data : {Data.ToString()}\n" +
                    "└───────────────";
        }
    }
}
