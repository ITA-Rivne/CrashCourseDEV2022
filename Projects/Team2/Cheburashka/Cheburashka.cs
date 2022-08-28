using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cheburashka
{
    public class Cheburashka : IToy, IPerson
    {
        private string name;
        private int payload;//корисне навантаження (може нести одночасно)
        private int count;//кількість будматеріалу в руках
        public string work; // робота, яку виконує персонаж
        // колір
        public string Color
        {
            get => Color;
            set => Color = value;
        }
        //Зріст
        public float Height
        {
            get => Height;
            set => Height = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public Cheburashka(string name, int payload)
        {
            this.name = name;
            this.payload = payload;
            this.count = 0;
            //this.Color = "Light Brown";
            this.work = "Байдикую";
            Console.WriteLine($"Привіт я {this.name}. Маю вільні руки");
        }
        public Cheburashka()
        {
            this.name = "Чебурашка";
            this.payload = 3;
            this.count = 0;
            //this.Color = "Light Brown";
            this.work = "Байдикую";
            Console.WriteLine($"Привіт я {this.name}.  Маю вільні руки");
        }
        public Cheburashka(string name)
        {
            this.name = name;
            this.payload = 2;
            this.count = 0;
            // this.Color = "Light Brown";
            this.work = "Байдикую";
            Console.WriteLine($"Привіт я {this.name}. Маю вільні руки");
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
