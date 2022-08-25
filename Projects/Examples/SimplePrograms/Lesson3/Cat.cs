using System;

namespace Lesson3
{
    public class Cat : Animal  // клас Cat наслідується від батьківсього класу Animal - принцип ООП наслідування.
                                 // Клас нащадок успадковує від батьківського класу усі (protected + public) поля і методи.
    {
        public string voise;

        //конструктор без параметрів
        public Cat()
        {
            SetAge();
        }

        public static int Amount;

        //конструктор з параметрами  можемо викликати будь з яких оголошених конструкторів
        public Cat(int age, int speed, int weight)
        {
            //передаємо параметри у батьківський конструктор через ключове слово base
            base.age = age;
            base.speed = speed;
            base.weight = weight;

            this.voise = "Meow!";
        }

        //переписали (override) метод move в нащадку 
        //тобто змінили поведінку нащадка - принцип поліморфізму
        //public override int move(int a, int b)
        //{
        //    Console.WriteLine("Call overriden method move() from the Cats class");
        //    return base.move(a, b) * 2;
        //}

        public string move(int a)
        {
            Console.WriteLine("Call overriden method move() from the Cats class");
            return "move method";
        }
    }
}
