using SmartHouse_MAU.Commands;
using SmartHouse_MAU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SmartHouse_MAU.ViewModel
{
    internal class HouseViewModel : INotifyPropertyChanged
    {
        private House _house;
        public ICommand ChangeTemper { get; set; }
        public ICommand Run { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public HouseViewModel()
        {
            _house = new House();
           // ChangeTemper = new ChangeTemperatureCommand(this); // create command
            ChangeTemper = new Command(ChangeTemperature); // create command
            Run = new Command(RunHouse);// create command
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
        public string Info
        {
            get => _house.AirConditioner.Info;
            set
            {
                if (_house.AirConditioner.Info != value)
                {
                    _house.AirConditioner.Info = value;
                    OnPropertyChanged(nameof(Info));
                }
            }
        }
        public int OuterTemperature
        {
            get => _house.OuterTemperature;
            set
            {
                if (_house.OuterTemperature != value)
                {
                    _house.OuterTemperature = value;
                    OnPropertyChanged(nameof(OuterTemperature));
                }
            }
        }
        public string TestInfo // &&&&& NEED ????
        {
            get => _house.TestInfo;
            set
            {
                if (_house.TestInfo != value)
                {
                    _house.TestInfo = value;
                    OnPropertyChanged(nameof(TestInfo));
                }
            }
        }
        public AirCondMode AirConditionerMode
        {
            get => _house.AirConditioner.Mode;
            set
            {
                if (_house.AirConditioner.Mode != value)
                {
                    _house.AirConditioner.Mode = value;
                    OnPropertyChanged(nameof(AirConditionerMode));
                }
            }
        }
        Random rnd = new Random();
        public void ChangeTemperature() // will call by  command
        {
            int randTemp = rnd.Next(-40, 40);
            Debug.WriteLine($"\n\n>>>>>>>>>>>>>>>> In method ChangeTemper OuteTemp is {randTemp}");
            OuterTemperature = randTemp;

            // Info = ""; 
            Info += $"___OuteTemp is {randTemp}__\n\r";
            Temperature = randTemp; // -15;

        }
        public void RunHouse()
        {
            OuterTemperature = 20;
            Temperature = OuterTemperature;
            Info = "OPENED ";
            // !!!!!! add some code Lamp
        }
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
