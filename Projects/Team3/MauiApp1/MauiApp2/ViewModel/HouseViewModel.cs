using MauiApp2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp2.ViewModel
{
    internal class HouseViewModel : INotifyPropertyChanged
    {
        private House _house;
        public ICommand ChangeTemper;
        public event PropertyChangedEventHandler PropertyChanged;
        public HouseViewModel()
        {
            _house = new House();
            // ChangeTemper = new ChangeTemperatureCommand(this); // create command
            ChangeTemper = new Command(ChangeT); // create command
        }
        public int Temperature
        {
            get => _house.Temperature;
            set
            {
                if (_house.Temperature != value)
                {
                    _house.Temperature = value;
                    OnPropertyChanged(nameof(Temperature));
                }
            }
        }
        Random rnd = new Random();
        public void ChangeT() // will call though  command
        {
            int randTemp = rnd.Next(-40, 40);
            Debug.WriteLine($"\n\n>>>>>>>>>>>>>>>> In method ChangeT OuteTemp is {randTemp}");

            Temperature = randTemp; // -15;

        }
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
