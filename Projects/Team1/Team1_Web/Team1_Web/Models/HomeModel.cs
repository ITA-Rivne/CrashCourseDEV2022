using System.Collections.ObjectModel;
using System.Net.NetworkInformation;
using System.Text;
using Team1_Web.Fairytale;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Team1_Web.Models
{
    public class HomeModel
    {
        private string displayText;
        private string actionLog;
        private string piggyName;

        private Piggi? selectedPiggi { get; set; }
        public List<Piggi> PigletsList { get; set; }

        public Wolf HeroWolf { get; set; }

        public string DisplayText { get; set; }

        public string ActionLog { get; set; }

        public string PiggyName { get; set; }

        public Piggi? SelectedPiggi { get; set; }

        public HomeModel()
        {
            // Казка "Троє поросят"

            #region 1. Поросята та вовк

            //a) потрібен абстрактний клас Animals
            // поля - ім'я
            //методи -?

            //б) потрібен клас Piggy, що наслідує Animals
            // поросята вміють веселитись та прокачували скіли, будувати будинок - два методи
            // поля - розум, працьовитість, швидкість
            // Породжуємо трьох поросят: Ніф-Ніф, Наф-Наф і Нуф-Нуф

            //в) потрібен клас HeroWolf, що наслідує Animals
            // вовк вміє полювати та істи - два методи (коли дуже голодний, то йде шукати поросят)
            // поля - хитрість, сила подиху, голод

            // Породжуємо вовка
            // вміє знижувати міцніть будинків та ламати їх силою подиху - метод 
            // вміє обдурювати поросят - метод
            #endregion

            #region 2. Будинок

            //a) потрібен клас Building
            // поля - назва, міцність, статус
            // має фундамент, стіни, криша, методи -?

            //породжуємо три об'єкти будинків, що будують поросята
            //в залежності від характеристик поросят генеруються різні будинки, де його міцність = сумі міцності матеріалів
            #endregion

            #region 3. Матеріали для будинку

            //a) потрібен клас Material, породжує об'єкти Солома, Дерево, Камень 
            // поля - назва, міцність
            // метод - випадкова генерація характеристики міцності в заданих межах

            #endregion

            #region 4. Сценарій
            // 1. Поросята відпочивають, їм генеруються скіли.
            // створити по одному
            PigletsList = new List<Piggi>()
            {
                new Piggi(1, "Ніф-Ніф", 1),
                new Piggi(2, "Наф-Наф", 2),
                new Piggi(3, "Нуф-Нуф", 3)
            };

            // 2. Будуємо будинки - вибір матеріалів випадковий, в залежності від скілів поросят

            PigletsList.ForEach(piggi => piggi.buildHouse());            

            // 3. Вовка чекає поки не зголодніє і приходить до першого поросята
            HeroWolf = new Wolf("Вовк", 10);


            #endregion
        }

        public JsonResponseViewModel WolfAtackPiggy(int piggyId)
        {
            //      - дихає на будинок скільки є сил, якщо розвалив, то їсть 

            var piggi = PigletsList.Where(d => d.Id.Equals(piggyId)).FirstOrDefault();
            JsonResponseViewModel model = new JsonResponseViewModel();
            if (piggi != null)
            {
                model.ResponseCode = 0;

                piggi.myHouse.DamageBuilding(HeroWolf.strenght);
                //якщо будинок не вцілів
                if (!piggi.myHouse.buildingStatus)
                {
                    if (piggi.catched(HeroWolf.speed))
                    {
                        HeroWolf.deadPiggiCount++;
                    };
                }
                model.ResponseMessage = JsonConvert.SerializeObject(piggi);
            }
            else
            {
                model.ResponseCode = 1;
                model.ResponseMessage = "Piggy not found";
            }                

            return model;

            //StringBuilder log = new StringBuilder();


            //int deadPiggiCount = 0;
            //foreach (var piggi in PigletsList)
            //{
            //    log.Append(HeroWolf.destructionBuilding(piggi.myHouse));

            //    if (!piggi.myHouse.buildingStatus)
            //        if (piggi.catched(HeroWolf.speed))
            //        {
            //            deadPiggiCount++;
            //            log.Append($"Я з'їв {piggi.Name} \n");
            //        }
            //        else
            //            log.Append($"{piggi.Name} втік\n");

            //}
            ////      - намагається обдурити, якщо так, то їсть та йде до наступного поросяти
            ////      - не вийшло розвалити та обдурити - порося вижило, йде до наступного поросяти
            ////      - пройшов всіх, або втік в ліс, або когось зжер(

            //log.Append("---------------------------------------------------------------\n");

            //PunisherPiggi superPiggi = new PunisherPiggi("Cупер порося");
            //log.Append(superPiggi.GetMesssage());

            //string status = superPiggi.punishTheWolf(HeroWolf, deadPiggiCount);
            //log.Append(status);            

            //return log.ToString();



        }


    }
}
