using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDiary.Classes;
using MyDiary.Views;

namespace MyDiary.ViewModel
{
    public class DiaryMainViewModel : BindableBase
    {
        public DiaryMainViewModel()
        {
            _CurrentDiaryView = diaryMainView;

            DiaryCommand = new MyICommand<string>(DiaryViewChange);
        }

        private DiaryBoardContentView diaryBoardView = new DiaryBoardContentView();
        private DiaryCalendarContentView diaryCalendarView = new DiaryCalendarContentView();
        private DiaryWirteContentView diaryWriteView = new DiaryWirteContentView();
        private DiaryMainContentView diaryMainView = new DiaryMainContentView();

        private object _CurrentDiaryView;

        public object CurrentDiaryView
        {
            get { return _CurrentDiaryView; }
            set { SetProperty(ref _CurrentDiaryView, value); }
        }

        public MyICommand<string> DiaryCommand { get; private set; }

        private void DiaryViewChange(string destination)
        {
            switch (destination)
            {
                case "Home":
                    CurrentDiaryView = diaryMainView;
                    break;
                case "Pencil":
                    CurrentDiaryView = diaryWriteView;
                    break;
                case "Calendar":
                    CurrentDiaryView = diaryCalendarView;
                    break;
                case "Board":
                    CurrentDiaryView = diaryBoardView;
                    break;
                default:
                    //CurrentView;
                    break;
            }
        }
    }
}
