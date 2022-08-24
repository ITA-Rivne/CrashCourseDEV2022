using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app
{
    class Program
    {
        static private bool is_a_triangle(float a, float b, float c)
        {
            return (a + b) > c & b +c > a & c + a > b;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first side\'s length:");
            float.TryParse(Console.ReadLine(), out float a);

            Console.WriteLine("Enter the second side\'s length:");
            float.TryParse(Console.ReadLine(), out float b);

            Console.WriteLine("Enter the third side\'s length:");
            float.TryParse(Console.ReadLine(), out float c);

            if (is_a_triangle(a, b, c))
            {
                Console.WriteLine("Yes, it can be a triangle.");           
            }
            else
                Console.WriteLine("No, it can\'t be a triangle");

            Console.ReadKey();
        }
    }
}
