using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ZSEL_QuizzApp.Commands;

namespace ZSEL_QuizzApp.ViewModels
{
    public class StartViewModel : ViewModelBase
    {
        public StartViewModel()
        {
            
        }
        public ICommand PlayCommand
        {
            get
            {
                return new RelayCommand(x =>
                {
                    MessageBox.Show("1");
                });
            }
        }
    }
}
