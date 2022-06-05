using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    class Item : Object
    {
        internal string description;

        public Item(string name, string description) : base(name)
        {
            this.description = description;
        }
    }
}