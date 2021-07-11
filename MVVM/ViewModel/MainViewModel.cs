using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Core;

namespace WpfApp2.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public String HomeCheck = "true";

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TuychinhCommand { get; set; }
        public RelayCommand TiviCommand { get; set; }
        public RelayCommand LightCommand { get; set; }
        public RelayCommand FanCommand { get; set; }
        public RelayCommand AirCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public Tuychinh TuychinhVM { get; set; }
        public Tivi TiviVM { get; set; }
        public Light LightVM { get; set; }
        public Fan FanVM { get; set; }
        public Condition AirVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { 
                return _currentView; 
            }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel(this);
            TuychinhVM = new Tuychinh();
            TiviVM = new Tivi();
            LightVM = new Light();
            FanVM = new Fan();
            AirVM = new Condition();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => {
                CurrentView = HomeVM;
            });

            TuychinhCommand = new RelayCommand(o => {
                CurrentView = TuychinhVM;
            });

            TiviCommand = new RelayCommand(o => {
                CurrentView = TiviVM;
            });

            LightCommand = new RelayCommand(o => {
                CurrentView = LightVM;
            });

            FanCommand = new RelayCommand(o => {
                CurrentView = FanVM;
            });

            AirCommand = new RelayCommand(o => {
                CurrentView = AirVM;
            });

        }
    }
}
