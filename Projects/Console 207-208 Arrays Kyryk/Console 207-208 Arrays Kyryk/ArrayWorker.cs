using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_207_208_Arrays_Kyryk
{
    static class ArrayWorker
    {
        const int DefaultSize = 10;
        public static T[] CreateArray<T>(int size = DefaultSize)
        {
            if (size <= 0)
                size = DefaultSize;
            return new T[size];
        }
        public static void Random(int[] arr, int left = 0, int right = 100)
        {
            Random rnd = new Random();
            if (left > right)
                Swap(ref left, ref right);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(left, right);
            }

        }
        public static string ArrayToString<T>(T[] arr)
        {
            return String.Join<T>(", ", arr);
        }
        private static void Swap<T>(ref T first, ref T second)
        {
            T tmp = first;
            first = second;
            second = tmp;
        }
        public static Dictionary<T, int> RepeatingInArray<T>(T[] arr)
        {
            Dictionary<T, int> dict = new Dictionary<T, int>();
            foreach (T e in arr)
            {

                if (dict.ContainsKey(e))
                    ++dict[e];
                else
                    dict[e] = 1;
                //++dict[e];
            }
            return dict;
        }
        public static int? EvenAndMin(int[] arr)
        {
            var onlyEven = Array.FindAll(arr, e => e % 2 == 0);
            if (onlyEven.Length == 0)
                return null;
            return onlyEven.Min();
        }
    }
}
