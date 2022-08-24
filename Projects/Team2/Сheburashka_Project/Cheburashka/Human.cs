using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Human : IPerson
    {
        private string name;
        public int count;
        public int strong;
        public string work;
        public int numberYears;
        public static Random random = new Random();


        public Human(string name, int numberYears)

        {
            this.name = name;
            this.numberYears = numberYears;
            Console.WriteLine($"Привіт я {this.name} мені {numberYears} років");
        }

        string IPerson.Name
        {
            get => name;
            set => name = value;
        }

        public int GetWork(string work, int count)
        {
            int strong;
            if (this.numberYears < 9) { strong = 1; }
            else if (this.numberYears < 15) { strong = 5; }
            else if (this.numberYears < 30) { strong = 10; }
            else if (this.numberYears < 50) { strong = 5; }
            else { strong = 0; }
            this.strong = strong;
            this.work = work;
            int a;

            if (count <= strong)
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
            { s = s + $"Я будую {this.work} і несу, будматеріал кількістю {this.count} "; }

            else { s = s + $"Я не можу підняти стільки, найбільше можу підняти кількістю {this.strong} "; }
            Console.WriteLine(s);

        }
    }
}