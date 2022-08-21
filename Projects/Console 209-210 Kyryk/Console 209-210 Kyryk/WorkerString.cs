using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_209_210_Kyryk
{
    class WorkerString
    {
        // RemoveFromString, які приймають текст і видаляють з нього або певний набір символів,
        public static string RemoveString(string  text, string delSymbols = ",.-")
        {
            int ind = text.IndexOfAny(delSymbols.ToCharArray());
            while (ind !=-1)
            {
                text = text.Remove(ind, 1);
                ind = text.IndexOfAny(delSymbols.ToCharArray());
            }
            return text;
        }
        //або символ\символи за порядковим номером в тексті. ---  виконано видалення символів за  вказаними індексами
        public static string RemoveString(string text, params int[] indices)
        {
            Array.Sort(indices);
            for (int i= 0; i < indices.Length; ++i)
            {
                int ind = indices[i];
                if (ind >= 0 && ind < text.Length)
                {
                    text = text.Remove(ind, 1);
                    // --indices[i];
                    Update(indices);
                }
            }
            return text;

            void Update(int [] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i]--;
                }
            }
            
        }
    }
}
