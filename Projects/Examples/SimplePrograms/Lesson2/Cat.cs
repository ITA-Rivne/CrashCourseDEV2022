using System;

namespace Lesson2
{
    // Клас Cat наслідується від батьківсього класу Animal - принцип ООП наслідування.
    // Клас нащадок успадковує від батьківського класу усі (protected + public) поля і методи.

    // ключове слово sealed вказує, що від даного класу заборонено наслідуватись
    public sealed class Cat : Animal
    {
        public string voise;

        //конструктор без параметрів
        public Cat()
        {
            SetAge();
            CatsAmount++;
            Animal.IncreaseCountOfAnimals();
            Console.WriteLine("Cats constructor!");
        }

        private static int CatsAmount { get; set; }

        //конструктор з параметрами  можемо викликати будь з яких оголошених конструкторів
        public Cat(int age, int speed, int weight)
        {
            //передаємо параметри у батьківський конструктор через ключове слово base
            base.age = age;
            base.speed = speed;
            base.weight = weight;

            this.voise = "Meow!";
            //виклик статичного методу, що належить класу Animals
            Animal.IncreaseCountOfAnimals();

            Cat.CatsAmount++;
        }

        //переписали (override) метод move в нащадку - збільшили швидкість вдвічі
        //тобто змінили поведінку нащадка - принцип поліморфізму
        public override int Move(int a, int b)
        {
            Console.WriteLine("Call overriden method Move(int a, int b) from the Cats class");
            return base.Move(a, b) * 2;
        }

        new public string Eat()   //приклад методу, який приховує батьківський метод - оголошувати через new
        {
            return "I whant more!";
        }

        public string move(int a)
        {
            Console.WriteLine("Call overriden method move() from the Cats class");
            return "move method";
        }
    }
}
