using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Core;

namespace WpfApp2.MVVM.ViewModel
{
    class Tuychinh : ObservableObject
    {
        public MainViewModel mainViewModel;

        private object _radius;
        private object _shapeButtonSize = 180.0;
        public RelayCommand ShapeCommand { get; set; }
        public RelayCommand BigSizeCommand { get; set; }
        public RelayCommand MediumSizeCommand { get; set; }
        public RelayCommand SmallSizeCommand { get; set; }

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

        public object ShapeButtonSize
        {
            get
            {
                return _shapeButtonSize;
            }
            set
            {
                _shapeButtonSize = value;
                OnPropertyChanged();
            }
        }

        public Tuychinh(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            Radius = mainViewModel.Radius;

            BigSizeCommand = new RelayCommand(o => {
                mainViewModel.HomeVM.BigButtonSize();
                mainViewModel.MediumSizeButton();
                mainViewModel.TiviVM.BigButton();
                ShapeButtonSize = 200.0;
            });

            MediumSizeCommand = new RelayCommand(o => {
                mainViewModel.HomeVM.MediumButtonSize();
                mainViewModel.MediumSizeButton();
                mainViewModel.TiviVM.MediumButton();
                ShapeButtonSize = 180.0;
            });

            SmallSizeCommand = new RelayCommand(o => {
                mainViewModel.HomeVM.SmallButtonSize();
                mainViewModel.SmallSizeButton();
                mainViewModel.TiviVM.SmallButton();
                ShapeButtonSize = 160.0;
            });

            ShapeCommand = new RelayCommand(o => {
                int tmpRadius = (int)Radius;
                if (tmpRadius == 10) {
                    mainViewModel.Radius = 500;
                    tmpRadius = 500;
                } else {
                    mainViewModel.Radius = 10;
                    tmpRadius = 10;
                }
                Radius = tmpRadius;
                mainViewModel.HomeVM.Radius = tmpRadius;
                //mainViewModel.LightVM.Radius = tmpRadius;
                mainViewModel.TiviVM.Radius = tmpRadius;
                //mainViewModel.HomeVM.Radius = tmpRadius;
                //mainViewModel.HomeVM.Radius = tmpRadius;
            });
        }
    }
}
