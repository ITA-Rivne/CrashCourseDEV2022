using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Dog : Animal
    {
        public Dog (string name, int weight) : base(name, weight)
        { }
        public Dog (string name) : base(name)
        { }

    }
}
