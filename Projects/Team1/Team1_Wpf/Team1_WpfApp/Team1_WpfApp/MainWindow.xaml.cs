using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Team1_WpfApp.Fairytale;

namespace Team1_WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringBuilder log = new StringBuilder();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
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

            //в) потрібен клас Wolf, що наслідує Animals
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

            List<Piggi> piglets = new List<Piggi>() {
                    new Piggi("Ніф-Ніф", 1),
                    new Piggi("Наф-Наф", 2),
                    new Piggi("Нуф-Нуф", 3)
            };


            // 2. Будуємо будинки - вибір матеріалів випадковий, в залежності від скілів поросят

            foreach (var piggi in piglets)
            {
                log.Append(piggi.ToString());
                piggi.buildHouse();                
                log.Append(piggi.myHouse.ToString());
                log.Append("---------------------------------------------------------------\n");
            }

            // 3. Вовка чекає поки не зголодніє і приходить до першого поросята

            var wolf = new Wolf("Вовк", 10);
            log.Append(wolf.ToString());

            //      - дихає на будинок скільки є сил, якщо розвалив, то їсть та йде до наступного поросяти
            int deadPiggiCount = 0;
            foreach (var piggi in piglets)
           {
                log.Append(wolf.destructionBuilding(piggi.myHouse));

                if (!piggi.myHouse.buildingStatus)
                    if (piggi.catched(wolf.speed))
                    {
                        deadPiggiCount++;
                        log.Append($"Я з'їв {piggi.name} \n");                        
                    }
                    else
                        log.Append($"{piggi.name} втік\n");                
                
            }
            //      - намагається обдурити, якщо так, то їсть та йде до наступного поросяти
            //      - не вийшло розвалити та обдурити - порося вижило, йде до наступного поросяти
            //      - пройшов всіх, або втік в ліс, або когось зжер(

            log.Append("---------------------------------------------------------------\n");

            PunisherPiggi superPiggi = new PunisherPiggi("Cупер порося");
            log.Append(superPiggi.ToString());

            string status = superPiggi.punishTheWolf(wolf, deadPiggiCount);
            log.Append(status);

            TextBlockLog.Text = log.ToString(); 


            #endregion            

        }
    }
}
