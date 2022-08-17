using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Identical array elements { 0, 1, 5, 0, 3, 2, 9, 5, 8 ,9 } ");
            int[] array = new int[10] { 0, 1, 5, 0, 3, 2, 9, 5, 8 ,9 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(array[i] + " ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
