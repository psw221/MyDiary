using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDiary.Classes;
using MyDiary.Views;

namespace MyDiary
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            CurrentView = loginMainView;
        }

        private LoginMainView loginMainView = new LoginMainView();

        private object _CurrentView;

        public object CurrentView
        {
            get { return _CurrentView; }
            set { SetProperty(ref _CurrentView, value); }
        }
    }
}
