using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_209_210
{
    public class Arithmetic
    {
        public static string Add(string s1, string s2)
        {
            string s = s1 + s2;
            return s;
        }
        public static int Add(int s1, int s2)
        {
            int s = s1 + s2;
            return s;
        }
        public static int Add()
        {
            return 5;
        }

        public static string RemoveFromString(string s1, string s2)
        {
            string s;
            s = s1;                   
            s = s1.Replace(s2, "");           
            return s;
        }

        public static string RemoveFromString(string s1, int a)
        {
            string s;
            s = s1;
          s = s.Remove(a, 1);
            return s;
        }

        public static string RemoveFromString(string s1)
        {
            string s;
            s = s1;
            s = s.Remove(4, 1);
            return s;
        }
        
    }
}
