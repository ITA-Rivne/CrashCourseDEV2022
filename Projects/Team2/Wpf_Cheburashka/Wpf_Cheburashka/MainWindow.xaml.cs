using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Wpf_Cheburashka
{

    public partial class MainWindow : Window
    {
        Construction construction = new Construction();
        public MainWindow()
        {
            InitializeComponent();

            
            label.Content = "Як Чебурашка і друзі будували будинок";
            ThicknessAnimation ta = new ThicknessAnimation();
            ta.From = new Thickness(800, 0, 0, 0);
            ta.To = new Thickness(250, 0, 0, 0);
            ta.Duration = TimeSpan.FromMilliseconds(6000);
            label.BeginAnimation(Label.MarginProperty, ta);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            construction.Cheb();
           
            construction.Gena();
        }

      
    }
}
