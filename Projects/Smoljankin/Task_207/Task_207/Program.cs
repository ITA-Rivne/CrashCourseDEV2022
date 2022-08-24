using System;

namespace Task_207
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int[] arr = new int[10];
            int[] arr2 = new int[arr.Length];
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        if(Array.IndexOf(arr2, arr[i]) < 0)
                        {
                            arr2[k] = arr[i];
                            k++;
                            break;
                        }

                    }
                }
            }
            Array.Resize(ref arr2, k);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
