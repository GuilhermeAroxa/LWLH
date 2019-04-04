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

            });
        }
        public ICommand StartCommand { get; set; }
    }
}
