using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Dog : Animal
    {
        public Dog (string name, int strong) : base(name, strong)
        { }
        public Dog (string name) : base(name)
        { this.strong = random.Next(1, 2); }

    }
}
