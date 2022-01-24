using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZSEL_QuizzApp.Store;
using ZSEL_QuizzApp.ViewModels;

namespace ZSEL_QuizzApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore navigationStore;

        public App()
        {
            navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            navigationStore.CurrentViewModel = new StartViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
