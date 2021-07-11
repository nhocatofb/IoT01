using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Core;

namespace WpfApp2.MVVM.ViewModel
{
    class HomeViewModel
    {
        public MainViewModel mainViewModel;
        public RelayCommand TiviCommand { get; set; }
        public RelayCommand TuychinhCommand { get; set; }
        public RelayCommand LightCommand { get; set; }
        public RelayCommand FanCommand { get; set; }
        public RelayCommand AirCommand { get; set; }

        public HomeViewModel(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;

            TiviCommand = new RelayCommand(o => {
                mainViewModel.CurrentView = mainViewModel.TiviVM;
            });

            FanCommand = new RelayCommand(o => {
                mainViewModel.CurrentView = mainViewModel.FanVM;
            });

            LightCommand = new RelayCommand(o => {
                mainViewModel.CurrentView = mainViewModel.LightVM;
            });

            AirCommand = new RelayCommand(o => {
                mainViewModel.CurrentView = mainViewModel.AirVM;
            });

            TuychinhCommand = new RelayCommand(o => {
                mainViewModel.CurrentView = mainViewModel.TuychinhVM;
            });
        }
    }
}
