using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    public class Construction
    {
        List<IPerson> persons = new List<IPerson>();

        House house = new House(2, 4);
       
        public Construction()
        {
            persons.Add(new Cheburashka("Cheb", 3));
            persons.Add(new Crocodile("Гена", 6));

            foreach(IPerson i in persons)
            {
                i.Say();
            }
            Console.WriteLine("Чебурашка -  Гена, самі не зможемо необхідно покликати на допомогу!");

            persons.Add(new Lion("Лев", 20));
            persons.Add(new Girl("Галя ", 15));
            persons.Add(new Dog("Тобік", 8));
            persons.Add(new Giraffe("Анюта", 10));
            persons.Add(new Man("Man", 10));
            persons[0].GetWork("", 10);

            Console.WriteLine("Хто будує фундамент");
            persons[2].GetWork("фундамент", 6);
            persons[6].GetWork("фундамент", 6);
            house.Build(persons[2], "Фундамент побудував");
            house.Build(persons[6], "Фундамент побудував");

            Console.WriteLine("Хто будує перший поверх");
            persons[1].GetWork("перший поверх", 4);
            persons[3].GetWork("перший поверх", 6);
            house.Build(persons[1], "Перший поверх побудував");
            house.Build(persons[3], "Перший поверх побудувала");

            Console.WriteLine("Хто будує другий поверх");
            persons[4].GetWork("другий поверх", 7);
            persons[5].GetWork("другий поверх", 9);
            house.Build(persons[4], "Другий поверх побудував");
            house.Build(persons[5], "Другий поверх побудувала");


            Console.WriteLine("Хто вставляє вікна");
            persons[1].GetWork("Вікна на перший поверх", 4);
            persons[3].GetWork("Вікна на перший поверх", 6);
            persons[4].GetWork("Вікна на  другий поверх", 7);
            persons[5].GetWork("Вікна на  другий поверх", 9);
            house.Build(persons[1], "Вікна на першому поверсі вставив");
            house.Build(persons[3], "Вікна на першому поверсі вставив");
            house.Build(persons[4], "Вікна на другому поверсі вставив");
            house.Build(persons[5], "Вікна на другому поверсі вставив");

            Console.WriteLine("Хто будує дах");
            persons[2].GetWork("дах", 7);
            persons[5].GetWork("дах", 9);
            house.Build(persons[4], "Дах побудував");
            house.Build(persons[5], "Дах побудувала");
            Console.WriteLine("Гена: А зараз Чебурашка скаже вам промову");
            Console.WriteLine("Чебурашка: Мы строили-строили, и наконец построили. Ура!");
        }


       

    }
}
