using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    public class Person {

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

            Console.WriteLine($"Hello! I'm {this.name}");
        }

        public Kolobok CookKolobok() {

            Console.WriteLine("\nGrandma baked Kolobok!");
            return new Kolobok();
        }
        

        public void Eat(ref Kolobok kolobok)
        {
            if (this.cunning > kolobok.cunning && kolobok.temperature < 35)
            {
                Console.WriteLine("It was tasty!");
                kolobok = null;
                throw new Exception("Kolobok is dead :((");
            }
            else
            {
                kolobok.RunAway(this.name);
            }
        }        
    }
}
