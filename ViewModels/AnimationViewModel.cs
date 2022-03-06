using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using ZSEL_QuizzApp.Store;

namespace ZSEL_QuizzApp.ViewModels
{
    public class AnimationViewModel : ViewModelBase
    {
        #region Fields
        private NavigationStore navigationStore;
        private string counter;
        private DispatcherTimer timer;
        private TimeSpan time;
        private string timeString;
        #endregion
        #region Properties
        public string Counter
        {
            get { return counter; }
            set
            {
                counter = value;
                OnPropertyChanged(nameof(Counter));
            }
        }
        #endregion
        #region Constructors
        public AnimationViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            Counter = 3.ToString();
            time = TimeSpan.FromSeconds(2);

            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                timeString = time.ToString("ss");
                Counter = timeString[1].ToString();
                if (time == TimeSpan.Zero) timer?.Stop();
                time = time.Add(TimeSpan.FromSeconds(-1));
                if (timeString == "00")
                    navigationStore.CurrentViewModel = new QuestionViewModel(navigationStore);
            }, Application.Current.Dispatcher);
            timer.Start();

        }
        #endregion
    }
}
