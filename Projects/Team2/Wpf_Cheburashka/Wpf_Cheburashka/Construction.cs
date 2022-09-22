using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;

namespace Wpf_Cheburashka
{
    public class Construction
    {
        List<IPerson> persons = new List<IPerson>();

        House house = new House(2, 4);
        Cheburashka cheburashka = new Cheburashka();
        Crocodile gena = new Crocodile("Гена", 6);


        public Construction()
        {
          

            persons.Add(new Cheburashka("Cheb", 3));

            Thread.Sleep(3000);

            persons.Add(new Crocodile("Гена", 6));


            
        }

        public void Cheb()
        {
            MainWindow mainwindow = ((MainWindow)System.Windows.Application.Current.MainWindow);

            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                mainwindow.image_cheb.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/cheb2.jpg"));
                String str = cheburashka.Say();
                mainwindow.label_cheb.Content = str;

            }));

            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                mainwindow.label1.Content = cheburashka.Sing();
                ThicknessAnimation ta = new ThicknessAnimation();
                ta.From = new Thickness(500, 100, 0, 0);
                ta.To = new Thickness(5, 100, 0, 0);
                ta.Duration = TimeSpan.FromMilliseconds(3000);
                mainwindow.label1.BeginAnimation(Label.MarginProperty, ta);


            }));
        }

        public void Gena()
        {
            MainWindow mainwindow = ((MainWindow)System.Windows.Application.Current.MainWindow);

            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                mainwindow.image_crocodile.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/gena1.jpg"));
                String str = gena.Say();
                mainwindow.label_gena.Content = str;

            }));

        }
        }
}
