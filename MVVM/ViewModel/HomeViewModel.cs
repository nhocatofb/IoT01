using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.Core;

namespace WpfApp2.MVVM.ViewModel
{
    class HomeViewModel : ObservableObject
    {
        public MainViewModel mainViewModel;
        public RelayCommand TiviCommand { get; set; }
        public RelayCommand TuychinhCommand { get; set; }
        public RelayCommand LightCommand { get; set; }
        public RelayCommand FanCommand { get; set; }
        public RelayCommand AirCommand { get; set; }

        private object _radius;

        private object tuychinhButtonSize = 200.0;
        private object deviceButtonSize = 150.0;
        private object banerWidth = 400.0;
        private object banerHeight = 200.0;

        private Rect rect;

        public object TuychinhButtonSize
        {
            get
            {
                return tuychinhButtonSize;
            }
            set
            {
                tuychinhButtonSize = value;
                OnPropertyChanged();
            }
        }
        public object DeviceButtonSize
        {
            get
            {
                return deviceButtonSize;
            }
            set
            {
                deviceButtonSize = value;
                OnPropertyChanged();
            }
        }
        public object BanerWidth
        {
            get
            {
                return banerWidth;
            }
            set
            {
                banerWidth = value;
                OnPropertyChanged();
            }
        }

        public object RectSize
        {
            get
            {
                return rect;
            }
            set
            {
                rect = (Rect)value;
                OnPropertyChanged();
            }
        }
        public object BanerHeight
        {
            get
            {
                return banerHeight;
            }
            set
            {
                banerHeight = value;
                OnPropertyChanged();
            }
        }

        public object Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
                OnPropertyChanged();
            }
        }

        public void BigButtonSize()
        {
            TuychinhButtonSize = 220.0;
            DeviceButtonSize = 170.0;
            BanerWidth = 420.0;
            BanerHeight = 220.0;
            RectSize = new Rect(0, 0, 420, 220);
        }

        public void MediumButtonSize()
        {
            TuychinhButtonSize = 200.0;
            DeviceButtonSize = 150.0;
            BanerWidth = 400.0;
            BanerHeight = 200.0;
            RectSize = new Rect(0, 0, 400, 200);
        }

        public void SmallButtonSize()
        {
            TuychinhButtonSize = 170.0;
            DeviceButtonSize = 130.0;
            BanerWidth = 380.0;
            BanerHeight = 180.0;
            RectSize = new Rect(0, 0, 370, 170);
        }

        public HomeViewModel(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            this.Radius = mainViewModel.Radius;

            MediumButtonSize();

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
