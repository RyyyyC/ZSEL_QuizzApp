using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ZSEL_QuizzApp.Commands;
using ZSEL_QuizzApp.Store;

namespace ZSEL_QuizzApp.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        #region Fields
        private NavigationStore navigationStore;

        private string username;
        private string password;
        #endregion

        #region Properties

        #region TextValues
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged(nameof (Username));
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof (Password));
            }
        }
        #endregion

        #region Commands
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
        private ICommand register;
        public ICommand Register
        {
            get
            {
                register = new RelayCommand(PasswordClick);
                return register;
            }
        }
        #endregion

        #endregion

        #region Constructors
        public RegisterViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
        }
        #endregion

        #region Methods
        private void PasswordClick(object p)
        {
            var passwordBox = p as PasswordBox;
            Password = passwordBox.Password;
        }
        #endregion
    }
}
