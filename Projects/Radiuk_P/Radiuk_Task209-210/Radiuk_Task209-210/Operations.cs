using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task209_210
{
    public static class Operations
    {
        // Написати overload методи Add які в залежності від параметрів
        // або додають цифрові значення, ...
        public static float Add(float numberFirst = 0, float numberSecond = 0)
        {
            return numberFirst + numberSecond;
        }

        // ... або об'єднують введені тексти.
        // Передбачити аргументи за замовчуванням і використання статичних полів\методів
        public static string Add(string stringFirst = "", string stringSecond = "")
        {
            return String.Join(" ", stringFirst, stringSecond);
        }

        // Написати overload методи RemoveFromString,
        // які приймають текст і видаляють з нього або певний набір символів, ...
        public static string RemoveFromString(string str, List<char> charsToRemove)
        {
            charsToRemove.ForEach(c => str = str.Replace(c.ToString(), String.Empty));
            return str;
        }

        // ... або символ\символи за порядковим номером в тексті.
        public static string RemoveFromString(string str, List<int> indicesToRemove)
        {
            int step = 0;
            int stringLength = str.Length;
            indicesToRemove.Sort();

            // The code below is for the future review.
            indicesToRemove.Where(pos => pos < stringLength)
                .ToList()
                .ForEach(pos => { str = str.Remove(pos - step, 1); step++; });

            return str;
        }
    }
}
