using System;

namespace Task_209
{
    class Operation
    {
        public static int Add(int a, int b = 10)
        {
            return a + b;
        }

        public static float Add(float a, float b = 5.25F)
        {
            return a + b;
        }

        public static string Add(string str1, string str2 = "!")
        {
            return str1 + " " + str2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Operation.Add(a, b));

            float a2, b2;
            a2 = Convert.ToSingle(Console.ReadLine());
            b2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(Operation.Add(a2, b2));

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(Operation.Add(str1, str2));
        }
    }
}
