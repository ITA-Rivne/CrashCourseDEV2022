using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class House : IHouse
    {
        public int Number_floors { get; set; }
        public int Number_windows { get; set; }

        public House(int nf, int nw)
        {
            Number_floors = nf;
            Number_windows = nw;
        }
        public void Build(IPerson person, string str)
        {
            Console.WriteLine(str + " " + person.Name);
        }

    }
}
