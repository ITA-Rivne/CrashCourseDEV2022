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
        public int count;
        public string work;

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


        public int GetWork(string work, int count)
        {
            this.work = work;
            int a;
            if (count <= weight)
            {
                a = count;
            }
            else
            {
                a = 0;
            }
            this.count = a;
            Say();
            return a;
        }


        public void Say()
        {
            string s = $"Я { this.name}!";
            if (this.count != 0)
            { s =  s + $"Я будую {this.work} і несу, будматеріал кількістю {this.count} "; }
            else { s = s+ $"Я не можу підняти стільки, максимум можу підняти кількістю {this.weight} "; }
            Console.WriteLine(s);


        }
    }
}
