using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Animal : IPerson
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetWork(string work, int count)
        {
            if (count <= weight)
            {
                string a = Say() + $"Я виконую роботу {work} і несу цеглу кількістю {count}";
                Console.WriteLine(a);
            }
            else
                Console.WriteLine(Say() + $"Я не можу підняти цеглин кількістю {count}, максимум можу підняти кількість цеглин {weight} ");

        }

        public string Say()
        {
            string s = $"Привіт! Я {this._name}!";

            return s;

        }
    }
}
