using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Threading;

using Cheburaska_Pattern;
using System.Threading;

namespace Wpf_Cheburashka_2
{
    public class Construction
    {
        ConcreteMediator mediator = new ConcreteMediator();
        Cheburashka cheburashka;
        Crocodile crocodile;
        Dog dog;
        Lion lion;
        Giraffe giraffe;
        Girl girl;
        Man man;
        
        public Construction()
        {
            cheburashka = new Cheburashka(mediator, 6);
            crocodile = new Crocodile(mediator, 9);
            mediator.Colleague1 = cheburashka;
            mediator.Colleague2 = crocodile;

            dog = new Dog(mediator, 6);
            mediator.Colleague3 = dog;

            lion = new Lion(mediator, 12);
            mediator.Colleague4 = lion;

            giraffe = new Giraffe(mediator, 10);
            mediator.Colleague5 = giraffe;

            girl = new Girl(mediator, 5);
            mediator.Colleague6 = girl;

            man = new Man(mediator, 7);
            mediator.Colleague7 = man;
        }

        public void Cheb()
        {
            MainWindow mainwindow = (MainWindow)System.Windows.Application.Current.MainWindow;

            cheburashka.Send("Я Чебурашка\nБайдикую");
            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                mainwindow.image_cheb.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/cheb2.jpg"));
            }));
        }

        public void Crocodile()
        {
            MainWindow mainwindow = (MainWindow)System.Windows.Application.Current.MainWindow;

            crocodile.Send("Я Гена\nГраю на гармошці");
            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                mainwindow.image_crocodile.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/gena1.jpg"));
            }));
        }
        public void Cheb2(string str1, string str2)
        {
            MainWindow mainwindow = (MainWindow)System.Windows.Application.Current.MainWindow;
            Refresh(((Label)((Grid)mainwindow.Content).Children[5]));
            cheburashka.Send(str1);
            crocodile.Send(str2);
        }

        private delegate void NoArgDelegate();

        public static void Refresh(DependencyObject obj)
        {
            obj.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, (NoArgDelegate)delegate { });
        }

       
            public void Frend()
        {
            
            MainWindow mainwindow = (MainWindow)System.Windows.Application.Current.MainWindow;

            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                mainwindow.image.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/dog.jpg"));
            }));
            dog.Send("Я Тобік");
            Refresh(((Label)((Grid)mainwindow.Content).Children[7]));
            Refresh(((Image)((Grid)mainwindow.Content).Children[6]));
            
            Thread.Sleep(3000);

            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                mainwindow.image.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/lion.jpg"));
            }));
            lion.Send("Я лев Чандр");

            Refresh(((Label)((Grid)mainwindow.Content).Children[7]));
            Refresh(((Image)((Grid)mainwindow.Content).Children[6]));

            Thread.Sleep(3000);

            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                mainwindow.image.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/giraffe.jpg"));
            }));
            giraffe.Send("Я жирафа Анюта");

            Refresh(((Label)((Grid)mainwindow.Content).Children[7]));
            Refresh(((Image)((Grid)mainwindow.Content).Children[6]));

            Thread.Sleep(3000);

          Application.Current.Dispatcher.BeginInvoke(new Action(() =>
           {
               mainwindow.image.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/girl.png"));
           }));
           girl.Send("Я Галя");

            Refresh(((Label)((Grid)mainwindow.Content).Children[7]));
            Refresh(((Image)((Grid)mainwindow.Content).Children[6]));

            Thread.Sleep(3000);

            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                mainwindow.image.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/man_2.jpg"));
            }));
            man.Send("Я Іван Іванович");

            Refresh(((Label)((Grid)mainwindow.Content).Children[7]));
            Refresh(((Image)((Grid)mainwindow.Content).Children[6]));
            
        }

        
   

 
        //    cheburashka.Send("Хто будує фундамент");
        //    lion.Send("фундамент", 6);
        //    man.Send("фундамент", 6);
        //    cheburashka.Send("Фундамент побудован!");

        //    cheburashka.Send("Хто будує перший поверх");
        //    crocodile.Send("перший поверх", 4);
        //    girl.Send("перший поверх", 6);
        //    cheburashka.Send("Перший поверх побудован!");


        //    cheburashka.Send("Хто будує другий поверх");
        //    dog.Send("другий поверх", 7);
        //    giraffe.Send("другий поверх", 9);
        //    cheburashka.Send("Другий поверх побудован!");

        //    cheburashka.Send("Хто вставляє вікна");
        //    crocodile.Send("Вікна на перший повер", 4);
        //    girl.Send("Вікна на перший повер", 6);
        //    dog.Send("Вікна на  другий поверх", 7);
        //    giraffe.Send("Вікна на  другий поверх", 9);
        //    cheburashka.Send("Вікна на першому та другому поверхах вставив!");

        //    cheburashka.Send("Хто будує дах");
        //    dog.Send("Вікна на  другий поверх", 7);
        //    giraffe.Send("Вікна на  другий поверх", 9);
        //    cheburashka.Send("Дах побудован!");

        //    crocodile.Send("Гена: А зараз Чебурашка скаже вам промову");
        //    cheburashka.Send("Чебурашка: Ми будували-будували, і нарешті збудували. Ураааа!");
    }
}
