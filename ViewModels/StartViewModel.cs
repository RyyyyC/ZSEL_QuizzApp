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
        public StartViewModel()
        {
            
        }
        public ICommand PlayCommand
        {
            get
            {
                return new RelayCommand(x =>
                {
                    navigationStore.CurrentViewModel = new StartViewModel(); 
                });
            }
        }
    }
}
