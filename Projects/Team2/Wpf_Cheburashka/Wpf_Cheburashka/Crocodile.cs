using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Cheburashka
{
    class Crocodile : Animal
    {
        public Crocodile(string name, int strong) : base(name, strong)
        { }
        public Crocodile(string name) : base(name)
        {
            this.strong = random.Next(1, 10);
        }
    }
}
