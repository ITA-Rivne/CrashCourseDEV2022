using System;

namespace CCourse_2022_Kyryk
{
    class Program
    {
        static void Main(string[] args)
        {
            string gymn = @"            ""Ukraine is not yet dead, nor it's glory and freedom,
            Luck will still smile on us brother-Ukrainians.""
            \M. Verbytsky\";
         
            writeMessage("\"To be\n\tor not\n\t\t to be\"\n\t\t\\Shakespeare\\", 30);
            Console.WriteLine();

            writeMessage(gymn);
            
            Console.ReadKey();
            
            void writeMessage(string  message, int len = 80)
            {
                Console.WriteLine(message);
                Console.WriteLine(new string('_', len));
            }

        }
    }
}
