using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiApp2.ViewModel;

namespace MauiApp2.Commands
{
    internal class ChangeTemperatureCommand : ICommand
    {
        private HouseViewModel _houseViewModel;

        public event EventHandler CanExecuteChanged;

        public ChangeTemperatureCommand(HouseViewModel houseViewModel
            )
        {
            _houseViewModel = houseViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //return _houseViewModel.Temperature > -50 ;
        }
        Random rnd = new Random();
        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                _houseViewModel.ChangeT();
                // _houseViewModel.Temperature = 100;// rnd.Next(-50, 50);
            }
        }
    }
}
