using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Core;

namespace WpfApp2.MVVM.ViewModel
{
    class Tivi: ObservableObject
    {
        public MainViewModel mainViewModel;
        private object radius;
        private object buttonSize = 140.0;

        public object ButtonSize
        {
            get
            {
                return buttonSize;
            }
            set
            {
                buttonSize = value;
                OnPropertyChanged();
            }
        }

        public object Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }

        public void BigButton()
        {
            ButtonSize = 160.0;
        }

        public void MediumButton()
        {
            ButtonSize = 130.0;
        }

        public void SmallButton()
        {
            ButtonSize = 120.0;
        }



        public Tivi(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            Radius = mainViewModel.Radius;
        }
    }
}
