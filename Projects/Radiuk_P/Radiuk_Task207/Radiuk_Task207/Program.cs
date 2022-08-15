using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task207
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arrayInput = { 5, 7, -5, 0, -5, 3, 0, -7, 0 };

			var myDictionary = new Dictionary<int, int>();

			foreach (var res in arrayInput)
			{
				if (myDictionary.ContainsKey(res))
				{
					myDictionary[res]++;
				}
				else
				{
					myDictionary[res] = 1;
				}
			}

			foreach (var valueTemp in myDictionary)
			{
				if (valueTemp.Value > 1)
				{
					Console.WriteLine("Duplicate {0} occured {1} times.", valueTemp.Key, valueTemp.Value);
				}
			}
			Console.ReadLine();
		}
    }
}
