using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStory1
{
    interface ICrudable
    {
        void Create();
        void Update();
        void Read();
        void Delete();
    }
}
