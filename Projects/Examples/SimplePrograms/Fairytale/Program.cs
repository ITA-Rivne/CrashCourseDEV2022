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
            //Казка колобок
            Console.WriteLine("Fairytale kolobok");

            //1. Баба і дід печуть колобка
            #region Details
                //a) потрібен клас Persons - породить два об'єкти дід і баба
                        //дід вміє говорити і їсти колобка
                        // = string Speak(); void Eat(Kolobok myKolobok)
                        //баба вміє пекти колобка і їсти колобка
                        // = Kolobok CookKolobok(); void Eat(Kolobok myKolobok)
                //б) потрібен клас Kolobok
                        // колобок вміє співати пісню, утікати = два методи
                        // поля - температура, хитрість, швидкість
                #region Realization
                    var baba = new Person();
                    var did = new Person();
                    var myKolobok = baba.CookKolobok();

                #endregion
            #endregion

            //2. колобок тікає від діда та баби (якщо він хитріший)
            #region Details
            //a) запускаємо два методи bolean\Kolobok Eat(Kolobok myKolobok) від діда і баби, якщо
            //колобок не гарячий і якщо вони розумніші, то з'їдять колобка,
            // якщо ж ні, то колобок втече
            #endregion

            //3. колобок тікає від зайця
            #region Details
            //а) потрібно загальний клас звірі і класи нащадки - заєць і т.д.
            // звірі - вміють говорити і їсти колобка
            // має бути поле хитрість і можна ще швидкість
            //б) об'єкт колобок передаємо параметром для rabbit.Eat(myKolobok)
            #endregion

            //4. колобок тікає від вовка
            #region Details
            //a) об'єкт колобок передаємо параметром для volf.Eat(myKolobok)
            #endregion

            //5. колобок тікає від ведмедя
            #region Details
            //a) об'єкт колобок передаємо параметром для bear.Eat(myKolobok)
            #endregion

            //6. колобок тікає від лисиці (якщо він хитріший - гру виграно\казку завершено)
            #region Details
            //a) об'єкт колобок передаємо параметром для fox.Eat(myKolobok)
            #endregion

            #region Remarks
            /// архітектурні зауваження 
            ///     усі можуть з'їсти колобка - можемо зробити інтерфейс IFeedable
            ///     усі можуть говорити - можемо зробити інтерфейс ITalkable
            #endregion
            Console.WriteLine("От і казочці кінець");
        }
    }
}
