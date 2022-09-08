using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburaska_Pattern
{
    class Cheburashka : Colleague, IPerson
    {
        bool f = true;
        public Cheburashka(IMediator mediator, int payload)
            : base(mediator)
        {
            this.name = "Чебурашка";
            this.payload = payload;
            this.count = 0;
            this.work = "Байдикую";
            //Console.WriteLine($"Привіт я {this.name}. Маю вільні руки");
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            if(f)
            {
                f = false;
                Console.WriteLine("Привіт! " + message);
            }
            else
            {
                Console.WriteLine(message);
            }
           
        }

        //---------------------

        private string name;
        private int payload;//корисне навантаження (може нести одночасно)
        private int count;//кількість будматеріалу в руках
        public string work; // робота, яку виконує персонаж
        
        public string Name
        {
            get => name;
            set => name = value;
        }
       

        public void DoneWork()
        {
            this.count = 0;
            this.work = "Байдикую";
            this.Say();
        }
        public int GetWork(string work, int count)
        {
            int a;
            if (string.Compare(this.work, "Байдикую") == 0)
            {
                this.work = work;
                Console.WriteLine($"Готовий будувати {this.work}... ");
            }

            if (string.Compare(this.work, work) != 0)
            {
                Console.WriteLine($"Я будую {this.work}, а не {work} ");
                return 0;
            }
            if (this.count + count <= this.payload)
            {
                a = count;
                Console.WriteLine($"\nЗабрав все, що дали: {a} будматеріалів.\n");
            }
            else
            {
                a = this.payload - this.count;
                Console.WriteLine($"Я будую {this.work}, несу {this.count}, беру ще {a}, більш не витримаю\n");
            }
            this.count += a;
            Console.WriteLine($"Всього несу {this.count}, мій максимум - {this.payload}\n");
            /*Чим більше несе, тим темніший колір
            if (this.count == 0) this.Color = "Light Brown";
            else if (this.count < this.payload / 2) this.Color = "Brown";
            else if (this.count >= this.payload / 2 && this.count != this.payload) this.Color = "Dark Brown";
            else this.Color = "Red";*/
            //Say();
            return a;
        }

        public void Say()
        {
            string s;
            if (string.Compare(this.work, "Байдикую") == 0)
            {
                s = $" Я {this.name} Я співаю:";
                Console.WriteLine(s);
                this.Sing();
            }
            else
            {
                s = $" {this.name}: Я будую {this.work}";
                Console.WriteLine(s);
            }
        }
        public void Sing()
        {
            Console.WriteLine("\rЯ був колись химерним\r\n   І навіть безіменним,\r\n   І зовсім не цікавим\r\n   Нікому із дітей.\r\n   Тепер я Чебурашка\r\n   І будь-яка дворняжка\r\n   Мене зустрівши,\r\n   Лапу подає.\r\n\r\n   Було везіння мало,\r\n   І навіть так бувало:\r\n   Ніхто на іменини\r\n   До мене не ходив.\r\n   Та з Геною тепер вже\r\n   Щасливий  я безмежно,\r\n   Бо він найкращий\r\n   В світі крокодил.\r\n");
        }
    }
}

