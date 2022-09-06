using MauiApp1.Command;
using MauiApp1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    public class PhoneViewModel : INotifyPropertyChanged
    {
        Phone phone;
        public ICommand Increase { get; }
        public PhoneViewModel(Phone phone = null)
        {

            this.phone ??= new Phone("IPhone 13 Pro", "Apple", 65000);
            Increase = new IncreasePriceCommand(this);  
        }

        public string Title
        {
            get { return phone.Title; }
            set
            {
                if (phone.Title != value)
                {
                    phone.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        public string Company
        {
            get { return phone.Company; }
            set
            {
                if (phone.Company != value)
                {
                    phone.Company = value;
                    OnPropertyChanged("Company");
                }
            }
        }
        public int Price
        {
            get { return phone.Price; }
            set
            {
                if (phone.Price != value)
                {
                    phone.Price = value;
                    OnPropertyChanged("Price");
                   // OnPropertyChanged();
                }
            }
        }
        public void IncreasePrice()
        {
              //phone.Price += 100;
              Price += 100;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName="")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
