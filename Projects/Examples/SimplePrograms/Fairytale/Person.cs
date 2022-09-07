using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    public class Person : IEatable, ISpeakable
    {

        public int cunning;
        public string name;
        //клас Persons - породить два об'єкти дід і баба
        //дід вміє говорити і їсти колобка
        // = string Speak(); void Eat(Kolobok myKolobok)
        //баба вміє пекти колобка і їсти колобка
        // = Kolobok CookKolobok(); void Eat(Kolobok myKolobok)

        public Person(string name)
        {
            this.name = name;

            //задаємо кмітливість
            this.cunning = new Random().Next(1, 10);

            Console.WriteLine($"Привіт! Я {this.name}");
        }

        public Kolobok CookKolobok() {

            Console.WriteLine("\nСпекла баба колобка");
            return new Kolobok();
        }
        

        public Kolobok Eat(ref Kolobok kolobok)
        {
            if (this.cunning > kolobok.cunning && kolobok.temperature < 35)
            {
                Console.WriteLine("Смачний був колобок");
                kolobok = null;
                throw new Exception("Колобка з'їли :((");
            }
            else
            {
                kolobok.RunAway(this.name);
            }
            return kolobok;
        }

        public string IntroduceYourself(ISpeakable person)
        {
            throw new NotImplementedException();
        }

        public string SayHello()
        {
            throw new NotImplementedException();
        }

        public string SpeakMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
