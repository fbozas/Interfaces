using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStory1
{
    class Customer : ICreatable, IDeletable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Create()
        {
            Console.WriteLine("The customer with name: " + Name + " has been created");
        }

        public void Delete()
        {
            Console.WriteLine("The customer with name: " + Name + " has been deleted");
        }
    }
}
