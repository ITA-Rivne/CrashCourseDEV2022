using System;
using System.Xml.Serialization;

namespace Lesson4
{
    [Serializable]
    public class Cat : Animal  // клас Cat наслідується від батьківсього класу Animal - принцип ООП наслідування.
                                 // Клас нащадок успадковує від батьківського класу усі (protected + public) поля і методи.
    {
        [XmlElement()]
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
        public override int Move(int a, int b)
        {
            Console.WriteLine("Call overriden method move() from the Cats class");
            return base.Move(a, b) * 2;
        }

        //перегружений метод, який може 
        public string Move(int a)
        {
            Console.WriteLine("Call overriden method move() from the Cats class");
            return "move method";
        }

        public void CatMethod() 
        {
            Console.WriteLine("This is the CatMethod()");
        }
    }
}
