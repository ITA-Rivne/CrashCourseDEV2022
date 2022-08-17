using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have an array { 0, 0, 3, 2, 7, 5, 4, 4, 8, 2 } ");
            int[] array = new int[10] { 0, 0, 3, 2, 7, 5, 4, 4, 8, 2 };

            int min = 99999999;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min && array[i] % 2 != 0)
                    min = array[i];

            }

            if (min % 2 != 0) { 
            Console.WriteLine(min);
            Console.ReadLine(); }
            else
                {Console.WriteLine("The array does not contain odd numbers");}
        }
    
    }
}
