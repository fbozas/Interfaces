using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStory1
{
    class Product : ICreatable, IDeletable
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Create()
        {
            Console.WriteLine("The product with name: " + Name + " has been created");
        }

        public void Delete()
        {
            Console.WriteLine("The product with name: " + Name + " has been deleted");
        }
    }
}
