using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Tasks

            //201. Average of two numerics
            Console.WriteLine("-------201. Average of 2 numerics-------");
            Console.WriteLine("Input two numerics");
            float a1 = Convert.ToSingle (Console.ReadLine());
            float a2 = Convert.ToSingle (Console.ReadLine());
            float aver = (a1 + a2) / 2;
            Console.WriteLine("Average of " + a1 + " and "+ a2 + " is ="+ aver);
            Console.ReadKey();

            //202. Text from Shakespeare
            Console.WriteLine("-------202. Text from Shakespeare-------");
            Console.WriteLine("To be or not to be \n\\ Shakespeare \\");
            Console.ReadKey();

            //203. Check for parity
            Console.WriteLine("-------203. Check for Parity-------");
            Console.WriteLine("Input numeric:");
            int a3 = Convert.ToInt32(Console.ReadLine());
            if (a3 % 2 == 0) Console.WriteLine("Pair");
            else Console.WriteLine("Odd");
            Console.ReadKey();

            //204. Quantity of digits and its sum of numeric from 0 to 99
            Console.WriteLine("-------204. Quantity of digits and its sum of numeric from 0 to 99-------");
            Console.WriteLine("Input numeric:");
            int a4 = Convert.ToInt32(Console.ReadLine());
            if (a4 < 100)
            {
                Console.WriteLine(a4.ToString().Length );
                Console.WriteLine(a4.ToString().Sum((c => c - '0')));
            }
            else Console.WriteLine("So big numeric!");
            Console.ReadKey();

            //205. Revert numeric
            Console.WriteLine("-------205. Revert numeric-------");
            Console.WriteLine("Input numeric:");
            string a5 = Console.ReadLine();    
            long n5 = Convert.ToInt32(a5);
            for (int i = 0; i < a5.Length; i++)
            {
                long rs5 = n5 % 10;
                if (rs5 != 0)
                    Console.Write(rs5);
                n5 /= 10;
            }
            Console.WriteLine();
            Console.ReadKey();

            //206. Sum of digits of numeric
            Console.WriteLine("-------206. Sum of digits of numeric-------");
            Console.WriteLine("Input numeric:");
            string a6 = Console.ReadLine();
            long n6 = Convert.ToInt32(a6);
            long s6 = 0;
            for (int i = 0; i < a6.Length; i++)
            {
                long rs6 = n6 % 10;
                if (rs6 != 0)
                n6 /= 10;
                s6 = s6+ rs6;
            }
            Console.WriteLine(s6);
            Console.ReadKey();

            //207. Dublicatein array more then 1 time
            Console.WriteLine("------207. Search dublicate more 1 time-----");
            Random r7 = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r7.Next(1, 10);
                Console.Write(array[i] + ", ");
            }
            Console.ReadKey();
            Console.WriteLine("\nSearching dublicate more 1 time...");
            int count = default(int);
            for (int i = 0; i < array.Length-2; i++)
            {
                for (int j=i+1; j < array.Length-1; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        count++;
                        if (count > 1)
                        {
                            Console.WriteLine("--" + array[j]);
                        }
                    }
                }
                count = default(int);
            }
            Console.ReadKey();

            //Soon to be continued

        }
    }
}
