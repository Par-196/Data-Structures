using DictionaryProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomDictionary<int, string> customDictionary = new CustomDictionary<int, string>();

            customDictionary.Add(1, "Alice");
            customDictionary.Add(2, "Bob");
            customDictionary.Add(3, "Charlie");
            customDictionary.Add(4, "Yura");
            customDictionary.Add(5, "David");
            customDictionary.Add(6, "Eva");
            customDictionary.Add(7, "Frank");
            customDictionary.Add(8, "Grace");
            customDictionary.Add(9, "Hannah");
            customDictionary.Add(10, "Ivan");

            customDictionary.PrintDictionary();
        }
    }
}
