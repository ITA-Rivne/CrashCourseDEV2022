using System;

namespace Task_208
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 100;

            Random rnd = new Random(DateTime.Now.Millisecond);
            int[] arr = new int[10];
           
            int min = N;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(N);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 1)
                {
                    min = arr[i];
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    if(arr[i] < min)
                    min = arr[i];
                   
                }
            }

            Console.WriteLine("Min = " + min);
        }
    }
}
