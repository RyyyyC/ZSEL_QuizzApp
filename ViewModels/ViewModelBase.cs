using System.ComponentModel;

namespace ZSEL_QuizzApp.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string popertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(popertyName));
        }
    }
}
