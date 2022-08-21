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
        string Say();
        void GetWork(string work, int count); // Work to be done and quantity

    }
}
