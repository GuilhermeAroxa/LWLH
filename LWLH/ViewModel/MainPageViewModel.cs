using LWLH.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LWLH.ViewModel
{
    class MainPageViewModel
    {
        public MainPageViewModel()
        {
            StartCommand = new Command(() =>
            {
                App.Current.MainPage = new TrainingView();
            });
        }
        public ICommand StartCommand { get; set; }
    }
}
