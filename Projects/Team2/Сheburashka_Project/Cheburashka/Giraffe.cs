using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Giraffe : Animal 
    {
        public Giraffe (string name, int strong) : base(name, strong)
        { }
        public Giraffe (string name) : base(name)
        {
            this.strong = random.Next(1, 7);
        }

    }
}
