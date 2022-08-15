using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task number:");
            int taskN = Int32.Parse(Console.ReadLine());
            if (taskN == 201)
            {
                Console.WriteLine("Enter first number");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Result=" + (a + b) / 2.0);
            }
            else if (taskN == 203)
            {
                Console.WriteLine("Enter number");
                int a = Int32.Parse(Console.ReadLine());
                if (a % 2 == 0) Console.WriteLine("parne");
                else Console.WriteLine("ne parne");
            }
            else if (taskN == 204)
            {

                Console.WriteLine("Enter number");
                int a = Int32.Parse(Console.ReadLine());
                int count = 0;
                int sum = 0;
                while (a > 0)
                {
                    count++;
                    sum += a % 10;
                    a = a / 10;
                }
                Console.WriteLine("Count of numbers: " + count + " Sum of numbers: " + sum);
            }
            else if (taskN == 205)
            {

                Console.WriteLine("Enter number");
                int a = Int32.Parse(Console.ReadLine());
                int num = 0;
                while (a > 0)
                {
                    num = a % 10;
                    a = a / 10;
                    Console.Write(num + " ");
                }


            }
            else if (taskN == 206)
            {

                Console.WriteLine("Enter number");
                int a = Int32.Parse(Console.ReadLine());
                int sum = 0;
                while (a > 0)
                {
                    sum += a % 10;
                    a = a / 10;
                }
                Console.WriteLine(" Sum of numbers: " + sum);

            }
            else if (taskN == 207)
            {
                Console.WriteLine("Same element: ");
                int[] a = new int[6] { 2, 2, 4, 5, 6, 6 };

                Console.WriteLine();
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            Console.WriteLine(a[i] + " ");
                        }
                    }
                }
            }
            else if (taskN == 208)
            {
                Console.WriteLine(" Min value: ");
                int[] a = new int[9] { 2, 2, 4, 6, 4, 8, 6, 5, 10};
                int min = 100000;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < min && a[i] % 2 != 0)
                        min = a[i];

                }

                if (min % 2 != 0)
                    Console.WriteLine(min);
                else
                    Console.WriteLine("not found");

            }
        }
    }
}
