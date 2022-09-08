using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburaska_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var mediator = new ConcreteMediator();
            var cheburashka = new Cheburashka(mediator, 6);
            var crocodile = new Crocodile(mediator, 9);

            mediator.Colleague1 = cheburashka; 
            mediator.Colleague2 = crocodile;

            cheburashka.Send("Я Чебурашка");
            cheburashka.Send("Байдикую");

            crocodile.Send("Я Гена");
            crocodile.Send("Граю на гармошці");

            cheburashka.Send("Гена давай збудуємо будинок");
            crocodile.Send("Чудова думка");

            cheburashka.Send("Гена, самі не зможемо необхідно покликати на допомогу!");
            crocodile.Send("Давай покличем бажаючих!");

            var dog = new Dog(mediator, 6);
            mediator.Colleague3 = dog;

            dog.Send("Я Тобік");

            var lion = new Lion(mediator, 12);
            mediator.Colleague4 = lion;
            lion.Send("Я лев Чандр");

            var giraffe = new Giraffe(mediator, 10);
            mediator.Colleague5 = giraffe;
            giraffe.Send("Я жирафа Анюта");

            var girl = new Girl(mediator, 5);
            mediator.Colleague6 = girl;
            girl.Send("Я Галя");

            var man = new Man(mediator, 7);
            mediator.Colleague7 = man;
            man.Send("Я Іван Іванович");

            cheburashka.Send("Хто будує фундамент");
            lion.Send("фундамент", 6);
            man.Send("фундамент", 6);
            cheburashka.Send("Фундамент побудован!");

            cheburashka.Send("Хто будує перший поверх");
            crocodile.Send("перший поверх", 4);
            girl.Send("перший поверх", 6);
            cheburashka.Send("Перший поверх побудован!");


            cheburashka.Send("Хто будує другий поверх");
            dog.Send("другий поверх", 7);
            giraffe.Send("другий поверх", 9);
            cheburashka.Send("Другий поверх побудован!");

            cheburashka.Send("Хто вставляє вікна");
            crocodile.Send("Вікна на перший повер", 4);
            girl.Send("Вікна на перший повер", 6);
            dog.Send("Вікна на  другий поверх", 7);
            giraffe.Send("Вікна на  другий поверх", 9);
            cheburashka.Send("Вікна на першому та другому поверхах вставив!");

            cheburashka.Send("Хто будує дах");
            dog.Send("Вікна на  другий поверх", 7);
            giraffe.Send("Вікна на  другий поверх", 9);
            cheburashka.Send("Дах побудован!");

            crocodile.Send("Гена: А зараз Чебурашка скаже вам промову");
            cheburashka.Send("Чебурашка: Ми будували-будували, і нарешті збудували. Ураааа!");
        }
    }
}
