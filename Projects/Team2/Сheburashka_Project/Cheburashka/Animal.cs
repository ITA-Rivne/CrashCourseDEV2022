using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    public class Animal : IPerson
    {
        private string name;
        public int weight;
        public static Random random = new Random();

        public Animal (string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public Animal (string name)
        {
            this.name = name;
            this.weight = random.Next(1, 10);
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
       

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
            string s = $"Привіт! Я {this.name}!";

            return s;

        }
    }
}
