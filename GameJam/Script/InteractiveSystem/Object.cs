using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    abstract class Object
    {
        internal string name;

        public Object(string name)
        {
            this.name = name;
        }
    }
}
