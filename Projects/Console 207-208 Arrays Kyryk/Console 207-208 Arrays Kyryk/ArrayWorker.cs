using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_207_208_Arrays_Kyryk
{
    static class ArrayWorker
    {
        public static void Random(int [] arr, int left = 0, int right = 100)
        {
             Random rnd = new Random();
            if (left > right)
                Swap(ref left, ref right);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(left, right);
            }
            
        }

        private static void Swap(ref int left, ref int right)
        {
            throw new NotImplementedException();
        }
    }
}
