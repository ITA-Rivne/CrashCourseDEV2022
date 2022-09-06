using MauiApp1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1.Command
{
    internal class IncreasePriceCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        PhoneViewModel viewModel;
        public IncreasePriceCommand(PhoneViewModel vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return viewModel.Price < 70000;// !!!! can run command if it true
        }

        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
                viewModel.IncreasePrice();
        }
        protected void OnCanExecutedChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
