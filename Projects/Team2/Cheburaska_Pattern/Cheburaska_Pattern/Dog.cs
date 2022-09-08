using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburaska_Pattern
{
    class Dog :  Colleague, IPerson
    {
        int strong; // Сила, генерується випадковим чином, так як персонаж втомлюється і набирається сил
        int count; // кількість будматеріалу, яку може підняти персонаж
        string work; // робота, яку виконує персонаж
        string name;

        public string Name
        {
            get => name;
            set => name = value;
        }


        bool f = true;
        public Dog(IMediator mediator, int count) : base(mediator)
        {
            Random random = new Random(DateTime.Now.Millisecond);

            this.strong = random.Next(1, 2);

            name = "Тобік";
            this.count = count;
        }

        public void Send(string message, int count = 0)
        {
            this.count = count;
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            if (f)
            {
                f = false;
                Console.WriteLine("Привіт " + message);
            }
            else
            {
                if (count != 0)
                    GetWork(message, count);
                else
                    Console.WriteLine(message);
            }
        }

        public int GetWork(string work, int count)
        {
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
