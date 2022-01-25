using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ZSEL_QuizzApp.Commands;
using ZSEL_QuizzApp.Store;

namespace ZSEL_QuizzApp.ViewModels
{
    public class StartViewModel : ViewModelBase
    {
        private NavigationStore navigationStore;
        public StartViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
        }
        public ICommand CreateAccount
        {
            get
            {
                return new RelayCommand(x =>
                {
                    navigationStore.CurrentViewModel = new RegisterViewModel();
                });
            }
        }
    }
}
