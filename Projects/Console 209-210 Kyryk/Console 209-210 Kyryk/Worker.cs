using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_209_210_Kyryk
{
    static class Worker
    {
        public static string Add(string first = "One", string second = "Two")
        {
            return first + "\t"+ second;
        }
        public static int Add(int first = 1, int second = 2)
        {
            return first + second;
        }
    }
}
