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

            NavCommand = new MyICommand<string>(OnNav);
        }

        private LoginMainView loginMainView = new LoginMainView();
        private DiaryMainView diaryMainView = new DiaryMainView();

        private object _CurrentView;

        public object CurrentView
        {
            get { return _CurrentView; }
            set { SetProperty(ref _CurrentView, value); }
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "Login":
                    CurrentView = diaryMainView;
                    break;
                case "customers":
                default:
                    //CurrentView;
                    break;
            }
        }
    }
}
