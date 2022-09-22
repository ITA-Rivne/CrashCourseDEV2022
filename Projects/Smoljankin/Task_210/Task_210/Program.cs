using System;

namespace Task_210
{
    class Operation_String
    {
        public static string RemoveFromString(string str1, string str2 = "hello")
        {
            return str1.Replace(str2, "");
        }

        public static string RemoveFromString(string str1, int index = 0)
        {
            return str1.Remove(index, 1);
        }

        public static string RemoveFromString(string str1, int[] arr)
        {
            Array.Sort(arr);
           
            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                str1 = str1.Remove(arr[i] - count, 1);
                Console.WriteLine(str1);
                count++;
            }

            return str1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(Operation_String.RemoveFromString(str1, str2));

            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Operation_String.RemoveFromString(str1, index));

            int[] arr = { 2, 5, 1, 7 };

            Console.WriteLine(Operation_String.RemoveFromString(str1, arr));
        }
    }
}
