using System;
using System.Xml.Serialization;

namespace Lesson2
{
    public class Animal : AOrganisms //клас Animal наслідується від абстрактного класу AOrganisms
    {
    #region Fields
        //різні модифікатори доступу
        private int _form; // доступний лише всередині класу

        public int age;  // доуступний для інших класів

        protected int weight; // доступний з класів нащадків

        public int speed;

        public const string CLASS_NAME = "ТВАРИНИ"; //приклад константи

        public string Name  //властивіть - поле для якого визначені методи Get i Set
        { get; private set; }
        #endregion Fields

        #region Methods


        #region Constructors
        //---------------------------КОНСТРУКТОРИ--------------------------------------------
        //конструктор - це метод, який ініціалізує "будує" об'єкт, можемо викликати необхідну логіку при створенні об'єкта


        //конструктор "по замовчуванню" - без параметрів
        public Animal()
        {
            Animal.IncreaseCountOfAnimals();
            Console.WriteLine("Animals constructor!");
        }

        // як і інші методи ми може мо мати перегружені конструктори
        public Animal(int age, int speed, int weight)
        {
            //в даному випадку відразу задаємо значення для полів об'єкту
            this.age = age;
            this.speed = speed;
            this.weight = weight;

            //виклик статичного методу, що належить класу Animals
            Animal.IncreaseCountOfAnimals();
            Console.WriteLine("Animals constructor with parameters!");

        }
        #endregion Constructors


        public string SetAge(int age)
        {

            this.age = age;

            return age.ToString();
        }

        protected string SetAge()
        {
            this.age = 0;
            return age.ToString();
        }

        public string Eat()
        {
            return "Thank you!";
        }

        public int GetWeight()
        {
            return this.weight;
        }

        //------------------------ МЕТОДИ УСПАДКОВАНІ ВІД БАТЬКІВСЬКОГО КЛАСУ --------------------------

        // метод GetName() успадкований від батьківсього класу Organisms і може бути викликаний
        // у класах нащадках, оскільки він не є абстрактним у батьківському класі
        //
        // але так як GetName() у батьківському класі є virtual - методом, то ми маємо право
        // при потребі його перевизначити



        // абстрактний метод GetState() наслідувано з абстрактного батьківського класу Organisms
        // цей метод GetState() має бути ОБОВ'ЯЗКОВО реалізований у класі нащадку, якщо ми 
        // хочемо мати змогу породжувати об'єкти класу Animal
        //
        // якщо ж він не реалізований, то ми змушені будемо і нащадок позначити як абстрактний
        // але ми не зможемо породжувати об'єкти від абстракного класу

        // реалізовуємо успадкований абстрактний метод
        public override void GetState()
        {
            //друкуємо результати успадковного методу
            Console.WriteLine (this.GetName());

            Console.WriteLine("This animal is live");
        }

        //-------------------------VIRTUAL METHODS-----------------------------------------
        //Кожен клас може сам містити віртуальні методи
        //Віртуальний (virtual) метод - його можна змінювати переписувати (override) у класах нащадках - реалізація принципу ООП поліморфізму
        public virtual int Move(int a, int b = 1)
        {
            return (a + b) * speed;
        }

        #endregion Methods

    #region StaticElements
        //---------------------------СТАТИЧНІ ПОЛЯ І МЕТОДИ--------------------------------------------
        //статичні поля і методи належать класу а не конкретному об'єкту цього класу
        //статичні елементи створюються під час компіляції програми, а не під час створення нового об'єкту класу
        //можемо викликати статичні сутності без створення нових об'єтктів а через ім'я класу. У даному випадку Animals.countOfAnimals


        private static int countOfAnimals; //інкапсулювати лічильник тварин, його неможливо змінити напряму, а ЛИШЕ через виклик методів

        public static string GetCountOfAnimals()
        {
            return countOfAnimals.ToString();

            IncreaseCountOfAnimals();
        }

        public static void IncreaseCountOfAnimals( int i = 1)        {
            countOfAnimals = countOfAnimals + i;
        }

        public static int DecreaseCountOfAnimals() => countOfAnimals--;  // скорочене оголошення методу через оператор =>
        #endregion StaticElements
    }
}