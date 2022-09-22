using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburaska_Pattern
{
    interface IPerson
    {
        string Name { get; set; }
        int GetWork(string work, int count); // Work to be done and quantity
    }
}
