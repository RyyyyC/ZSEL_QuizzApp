using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSEL_QuizzApp.Store;

namespace ZSEL_QuizzApp.ViewModels
{
    public class QuestionViewModel : ViewModelBase
    {
        private string questionCounter;
        public string QuestionCounter
        {
            get { return questionCounter; }
            set
            {
                questionCounter = value;
                OnPropertyChanged(nameof(QuestionCounter));
            }
        }
        private string currentRound;
        public string CurrentRound
        {
            get { return currentRound; }
            set
            {
                currentRound = value;
                OnPropertyChanged(nameof(CurrentRound));
            }
        }

        private NavigationStore navigationStore;
        public QuestionViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            QuestionCounter = $"1 / 10";
            CurrentRound = $"ROUND 1";
        }
    }
}
