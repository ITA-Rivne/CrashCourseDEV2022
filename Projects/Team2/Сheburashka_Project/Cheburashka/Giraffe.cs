using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Giraffe : Animal 
    {
        public Giraffe (string name, int weight) : base(name, weight)
        { }
        public Giraffe (string name) : base(name)
        {
            this.weight = random.Next(1, 7);
        }

    }
}
