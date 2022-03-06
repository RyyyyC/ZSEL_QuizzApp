using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZSEL_QuizzApp.Commands;
using ZSEL_QuizzApp.Store;

namespace ZSEL_QuizzApp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private NavigationStore navigationStore;
        public LoginViewModel(NavigationStore navigationStore)

        {
            this.navigationStore = navigationStore;
        }

        public ICommand ExitToMainMenu
        {
            get
            {
                return new RelayCommand(x =>
                {
                    navigationStore.CurrentViewModel = new StartViewModel(navigationStore);
                });
            }
        }
    }
}
