using System;

namespace Console_207_208_Arrays_Kyryk
{
   
    static class Client 
    {
        // Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран.
        public static void Task_207()
        {
            var arr = ArrayWorker.CreateArray<int>(20);
            ArrayWorker.Random(arr, 0, 20);
            Console.WriteLine($"\t\tArray :\n{ArrayWorker.ArrayToString(arr)}\n\n");
            var result = ArrayWorker.RepeatingInArray(arr);
            foreach (int key in result.Keys)
            {
                if(result[key] > 1)
                Console.WriteLine($"\t\tElement {key, 4} repeated {result[key], 4} times");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client.Task_207();
            
        }
    }
}
