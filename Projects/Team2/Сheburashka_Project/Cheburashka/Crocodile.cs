using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Crocodile : Animal
    {
        public Crocodile (string name, int weight) : base(name, weight)
        { }
        public Crocodile (string name) : base(name)
        {
            this.weight = random.Next(1, 10);
        }
    }
}
