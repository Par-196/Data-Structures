using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListProject.Models
{
    public class Data
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }

        public Data(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
