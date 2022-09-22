using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Media.Animation;

namespace Wpf_Cheburashka_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer player = new MediaPlayer();
        Construction construction = new Construction();
        public MainWindow()
        {
            InitializeComponent();

            var path = AppDomain.CurrentDomain.BaseDirectory + "/cheburashka.mp3";
            player.Open(new Uri(path));
            player.Play();

            label.Content = "Як Чебурашка і друзі будували будинок";
            ThicknessAnimation ta = new ThicknessAnimation();
            ta.From = new Thickness(800, 0, 0, 0);
            ta.To = new Thickness(250, 0, 0, 0);
            ta.Duration = TimeSpan.FromMilliseconds(4000);
            label.BeginAnimation(Label.MarginProperty, ta);

            construction.Cheb();
            construction.Crocodile();
            

        }
        private delegate void NoArgDelegate();

        public static void Refresh(DependencyObject obj)
        {
            obj.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, (NoArgDelegate)delegate { });
        }
        async private void button_Click(object sender, RoutedEventArgs e)
        {
 
            Refresh(label);
            Thread.Sleep(1000);
            construction.Cheb2("Гена давай збудуємо будинок", "Чудова думка");

            Refresh(label);

            Thread.Sleep(1000);
            construction.Cheb2("Гена, самі не зможемо необхідно покликати на допомогу!", "Давай покличем бажаючих!");

            Refresh(label);

            Thread.Sleep(1000);

            construction.Frend();      



        }

    }
}
