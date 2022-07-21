using System;
using System.Xml.Serialization;

namespace Lesson4
{
    [Serializable]
    //Позначаємо для Xml серіалізації, що клас Animal може включати об'єкти класу Cat
    [XmlInclude(typeof(Cat))]
    
    public class Animal
    {

        [XmlElement()] //позначаємо кожне поле, яке має бути серіалізоване
        public int age;  // доуступний для інших класів

        [XmlElement()]
        protected int weight; // доступний з класів нащадків
        [XmlElement()]
        public int speed;
        
        protected string SetAge() {
            this.age = 0;
            return age.ToString();
        }

        //---------------------------КОНСТРУКТОРИ--------------------------------------------
        //конструктор - це метод, який ініціалізує "будує" об'єкт, можемо викликати необхідну логіку при створенні об'єкта


        //конструктор "по замовчуванню" - без параметрів
        public Animal() { }         

        // як і інші методи ми може мо мати перегружені конструктори
        public Animal(int age, int speed, int weight)
        {
            //в даному випадку відразу задаємо значення для полів об'єкту
            this.age = age;
            this.speed = speed;
            this.weight = weight;
        }

        public int GetWeight()
        {
            return this.weight;
        }

        //---------------------------------------------------------------------------------

        //Віртуальний (virtual) метод - його можна змінювати переписувати (override) у класах нащадках - реалізація принципу ООП поліморфізму
        public virtual int Move(int a, int b = 1)
        {
            return (a + b) * speed;
        }

    }

}
