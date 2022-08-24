using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson4
{
    class Program
    {
        #region Functions

        public static void methodExceptionExample()
        {
            try
            {
                Console.WriteLine("Method that contains try catch");

                //виклик методу в середниі якого існують свої try catch конструкції
                throw new Exception("methodExceptionExample new Exception....");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        #region SerializationExamples

        //серіалізація у XML
        public static async void XmlSerializationExample(List<Animal> animalsCollection)
        {
            Console.WriteLine($"---------------XMLSerializationExample----------------");


            //створюємо об'єкт XmlSerializer що приймає типи List<Animal> і List<Cat> 
            //оскільки List, який ми будемо серіалізувати містить об'єкти обох класів

            var arraySecondParametr = new[] { typeof(List<Cat>) };
            XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>), arraySecondParametr);
            Stream fileStream = new FileStream("animalsCollection.xml", FileMode.Create);
            try
            {
                serializer.Serialize(fileStream, animalsCollection);
                fileStream.Close();
                Console.WriteLine("Serialization completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("You can check serealized XML file.  Press ENTER to continue...");
            Console.ReadLine();
        }

        //серіалізація у JSON
        public static async Task JSONSerializationExample(List<Animal> animalsCollection)
        {
            Console.WriteLine($"---------------JSONSerializationExample----------------");

            // збереження данных
            using (var fileStream = new FileStream("animalsCollection.json", FileMode.OpenOrCreate))
            {
                //серіалізація в Json
                string jsonString = JsonConvert.SerializeObject(animalsCollection);
                Console.WriteLine(jsonString);

                // конвертуємо в байти і записуємо в файл
                byte[] array = System.Text.Encoding.Default.GetBytes(jsonString);

                fileStream.Write(array, 0, array.Length);
                Console.WriteLine("Data has been saved to file");
            }

            Console.WriteLine("You can check serealized JSON file.  Press ENTER to continue...");
            Console.ReadLine();

            // зчитування данных
            using (System.IO.StreamReader sr = File.OpenText("animalsCollection.json"))
            {
                var restoredCollection = JsonConvert.DeserializeObject<List<Animal>>(sr.ReadLine());
                Console.WriteLine("Restored Collection");

                foreach (var animal in restoredCollection)
                    Console.WriteLine($"Name: {animal.age}  Speed: {animal.speed} Weight: {animal.GetWeight()}");
            }
        }
        #endregion SerializationExamples

        #endregion Functions

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //встановлюємо кодування для виводу кирилиці в консоль

            #region//--------------- Приклади реалізації інтерфейсів---------------------------

            //Колекція створена через реалізацію IEnumerable + IEnumerator
            var myCollection = new MyCollection();
            foreach (var i in myCollection)
            {
                Console.WriteLine(i);
            }

            //Колекція створена через yield
            var сollectionYield = new MyYieldCollection();
            foreach (var i in сollectionYield)
            {
                Console.WriteLine(i);
            }

            #endregion

            //----------------- Приведення і підстановка класів --------------
            Cat cat1 = new Cat(2, 4, 5);
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();
            
            cat3.Dispose();
            cat3 = null;

            Animal animal1 = new Animal();
            Animal someAnimal = new Animal();


            Animal someAnimal3 = new Cat(); //ми можемо підставити нащадка на місце батьківського типу
                                            //бо ми очікуємо, що поведіка нащадку така ж як і
                                            //батьківського класу (але + додаткова логіка нащадка)
            
            //Cat someCat2 = new Animal();   //навпаки підставити не вийде,
                                              //бо батьківський клас не має усієї додаткової логіки,
                                              //яка реалізована в нащадку
        
            cat2.CatMethod();
            //someAnimal3.CatMethod();     //хоча someAnimal3 породжений як об'єкт типу Cat, проте ми не можемо
                                            //викликати метод класу Cat CatMethod(),
                                            //оскільки змінна, в яку ми поміщаємо посилання на наш
                                            //об'єкт визначена як батьківський клас Animal (а у ньму немає CatMethod())

            
            var animalsCollection = new List<Animal>();

            //об'єкти з класів наслідників можуть поводитись як об'єкти батьківських класів
            //не можна порушувати принцип SOLID L= Lliskov substitution principle - принцип підстановки
            animalsCollection.Add(cat1);
            animalsCollection.Add(cat2);
            animalsCollection.Add(animal1);
            animalsCollection.Add(new Cat(8, 6, 3));

            var catsCollection = new List<Cat>();


            //--------------- РОБОТА З ФАЙЛАМИ -----------------------

            //Робота з дисками
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Назва: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Розмір диску: {drive.TotalSize}");
                    Console.WriteLine($"Вільний простір: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Мітка диска: {drive.VolumeLabel}");
                }
                Console.WriteLine();
            }

            //Робота з калалогами
            string path = @"C:\SomeDir";
            string subpath = @"program\avalon";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Directory.CreateDirectory($"{path}/{subpath}");



            //Робота з файлами

            //клас FileInfo
            //CopyTo(path)
            //Create()
            //Delete()

            //клас File
            //Copy(): копіює файл в нове місце
            //Create(): створює файл
            //Delete(): видаляє файл
            //Move: переміщує файл в нове місце



            //обробка виключень при роботі з файлами
            try
            {
                using (System.IO.StreamReader sr = File.OpenText("data.txt"))
                {
                    //читаємо з файлу
                    Console.WriteLine($"The first line of this file is {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"The file was not found: '{e}'");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"The directory was not found: '{e}'");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The file could not be opened: '{e}'");
            }


            XmlSerializationExample(animalsCollection);

            catsCollection.Add(new Cat(1, 2, 3));
            catsCollection.Add(new Cat(2, 3, 4));

            JSONSerializationExample(animalsCollection);
            Console.ReadLine();

        }
    }

    //приклад класу, що реалізує IEnumerable через ключове слово yield
    class MyYieldCollection : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return "yield Hello world!";
            yield return "yield Hello world!1";
            yield return "yield Hello world!2";
            yield return "yield Hello world!3";
        }
    }
}