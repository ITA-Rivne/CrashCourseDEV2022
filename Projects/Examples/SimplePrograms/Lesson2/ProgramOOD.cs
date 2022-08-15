using System;
using System.Threading.Tasks;


namespace Lesson2
{
    class ProgramOOD
    {
        #region Methods
        //перезавантажені overload методи - методи з різною сигнатурою
        public static string calculate(int a, int b = 2323)
        {
            return (a + b).ToString();
        }

        public static string calculate(string a, string b = "2323")
        {
            return a + b.ToString();
        }
        #endregion Methods

        public static async Task Main(string[] args)
        {

            Console.WriteLine($"Animals.GetCountOfAnimals() = {Animal.GetCountOfAnimals()}");

            //виклик перезавантажених overload методів
            calculate(3);
            calculate(3, 7);
            calculate("text", "text2");

            //створення об'єкту типу Animals
            Animal animal1 = new Animal(12, 7, 30);
            animal1.Move(2, 4);
            animal1.GetState();

            //створення об'єкту типу Cats двома різними конструкторами, відповідно отримаємо
            //різну ініціалізацію і різні значення для age створених об'єктів
            Cat cat1 = new Cat(2, 4, 5);
            cat1.Move(1, 2);

            Animal someAnimal = new Animal();

            Console.WriteLine($"cat1.age {cat1.age}");

            Cat cat2 = new Cat();

            Cat cat3 = cat2;

            cat2.SetAge(12);

            Console.WriteLine($"cat2.age {cat2.age}, {cat2.GetName()}");
            Console.WriteLine($"cat3.age {cat3.age}, {cat3.GetName()}"); //приклад роботи типу даних за посиланням

            //викликаємо СТАТИЧНИЙ метод класу Animals, який вичитує дані з ПРИВАТНОГО поля countOfAnimals
            //іншим чином ми не можемо отримати значення цього поля - це ІНКАПСУЛЯЦІЯ + робота зі стат полями і методами
            Console.WriteLine($"Animals.GetCountOfAnimals() = {Animal.GetCountOfAnimals()}");

            Animal animalFromCat = cat2;
            Console.WriteLine($"animalFromCat {cat2.Eat()}");
            Console.WriteLine($"animalFromCat {animalFromCat.Eat()}");
        }
    }


    //-------------------------------------------Структури----------------------------------
    //Структури - це ще один вид типів даних. Приклади структур - типи даних int, double...
    //Структури схожі на класи, але існує ряд відмінностей
    //      1) змінні типу struct містять не посилання на об'єкт, а сам об'єкт,
    //      тобто є типом даних за значенням(value), а не за посиланням(refferance)
    //      2) оскільки в змінних зберігаються значення, а не посилання на них,
    //      то доступ до даних є швидшим ніж у класівж
    //      3) при присвоєнні одної змінної іншій відбувається копіювання структури і значення всіх полів
    //      4) структури не підтримують наслідування
    
    public struct StructureExample
    {

        StructureExample(string name) 
        {
            this.className = name;
        }

        public string className;
        private int AdditionOfInt(int a, int b) => a + b;
        private int SubtractionOfInt(int a, int b) => a - b;
        private int MultiplicationOfInt(int a, int b) => a * b;
        private int DivisionOfInt(int a, int b) => a / b;
    }
}


