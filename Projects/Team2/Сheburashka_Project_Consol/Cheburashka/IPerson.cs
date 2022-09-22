using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    interface IPerson
    {
        string Name { get; set; }
        void Say();
        int GetWork(string work, int count); // Work to be done and quantity

    }
}
