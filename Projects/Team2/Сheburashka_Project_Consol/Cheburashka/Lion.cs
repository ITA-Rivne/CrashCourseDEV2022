using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Lion : Animal 
    {
        public Lion(string name, int strong) : base(name, strong)
        { }
        public Lion(string name) : base(name)
        {
            this.strong = random.Next(1, 12);
        }


    }
}
