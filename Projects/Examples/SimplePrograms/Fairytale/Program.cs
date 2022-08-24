using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //встановлюємо кодування для виводу кирилиці в консоль
            Console.WriteLine("Казка КОЛОБОК \n");
            try
            {
                #region 1. Баба і дід печуть колобка

                //a) потрібен клас Persons - породить два об'єкти дід і баба
                //дід вміє говорити і їсти колобка
                // = string Speak(); void Eat(Kolobok myKolobok)
                //баба вміє пекти колобка і їсти колобка
                // = Kolobok CookKolobok(); void Eat(Kolobok myKolobok)
                //б) потрібен клас Kolobok
                // колобок вміє співати пісню, утікати = два методи
                // поля - температура, хитрість, швидкість
                #region Realization
                var did = new Person("Дід");
                var baba = new Person("Баба");

                var kolobok = baba.CookKolobok();

                #endregion
                #endregion

                #region 2. Колобок тікає від діда та баби (якщо він хитріший, або якщо не встиг охолонути)

                //a) запускаємо два методи bolean\Kolobok Eat(Kolobok myKolobok) від діда і баби, якщо
                //колобок не гарячий і якщо вони розумніші, то з'їдять колобка,
                // якщо ж ні, то колобок втече

                did.Eat(ref kolobok);
                baba.Eat(ref kolobok);

                #endregion

                #region 3. колобок тікає від зайця
                //а) потрібно загальний клас звірі і класи нащадки - заєць і т.д.
                // звірі - вміють говорити і їсти колобка
                // має бути поле хитрість і можна ще швидкість
                //б) об'єкт колобок передаємо параметром для rabbit.Eat(myKolobok)

                var rabbit = new Rabbit("Зайчик");
                rabbit.Eat(ref kolobok);

                #endregion

                #region 4. Колобок тікає від вовка
                //a) об'єкт колобок передаємо параметром для volf.Eat(myKolobok)

                var volf = new Volf("Вовк");
                volf.Eat(ref kolobok);

                #endregion

                #region 5. колобок тікає від ведмедя
                //a) об'єкт колобок передаємо параметром для bear.Eat(myKolobok)

                var bear = new Bear("Ведмідь");
                bear.Eat(ref kolobok);

                #endregion

                #region 6. колобок тікає від лисиці (якщо він хитріший - гру виграно\казку завершено)
                //a) об'єкт колобок передаємо параметром для fox.Eat(myKolobok)
                var fox = new Fox("Лисиця", 2);
                fox.Eat(ref kolobok);
                #endregion

                #region Remarks
                /// архітектурні зауваження 
                ///     усі можуть з'їсти колобка - можемо зробити інтерфейс IFeedable
                ///     усі можуть говорити - можемо зробити інтерфейс ITalkable
                #endregion

                if (kolobok != null) Console.WriteLine("Колобок живий!!!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Кінець казки!");

            Console.ReadLine();
        }
    }

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
    }
