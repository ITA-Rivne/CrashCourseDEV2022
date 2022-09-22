using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Wpf_Cheburashka_2;

namespace Cheburaska_Pattern
{
    class Man : Colleague, IPerson
    {
        int strong; // Сила, генерується випадковим чином, так як персонаж втомлюється і набирається сил
        int count; // кількість будматеріалу, яку може підняти персонаж
        string work; // робота, яку виконує персонаж
        string name;

        public string Name
        {
            get => name;
            set => name = value;
        }


        bool f = true;
        public Man(IMediator mediator, int strong) : base(mediator)
        {
            this.strong = strong;
            name = "Іван Іванович";
        }

        public void Send(string message, int count= 0)
        {
            this.count = count;
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            MainWindow mainwindow = (MainWindow)System.Windows.Application.Current.MainWindow;
            if (f)
            {
                f = false;
                String str = "Привіт! " + message;
                ((Label)((Grid)mainwindow.Content).Children[7]).Content = str;
            }
            else
            {
                if (count != 0)
                    GetWork(message, count);
                else
                    ((Label)((Grid)mainwindow.Content).Children[7]).Content = message;
            }
        }

        public int GetWork(string work, int count)
        {
            this.work = work;
            int a;
            if (count <= strong)
            {
                a = count;
            }
            else
            {
                a = 0;
            }
            this.count = a;
            Say();
            return a;
        }

        public void Say()
        {
            MainWindow mainwindow = (MainWindow)System.Windows.Application.Current.MainWindow;
            string s = $"";
            if (this.count != 0)
            { s = s + $"Я будую {this.work} і несу, будматеріал кількістю {this.count} "; }
            else { s = s + $"Я не можу підняти стільки, найбільше можу підняти кількістю {this.strong} "; }

           ((Label)((Grid)mainwindow.Content).Children[7]).Content = s;

            mainwindow.image.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/man_2.jpg"));

            ((Image)((Grid)mainwindow.Content).Children[13]).Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/window.png"));
            ((Image)((Grid)mainwindow.Content).Children[14]).Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/images/window.png"));
        }
    }
}
