using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2.MVVM.View
{
    /// <summary>
    /// Interaction logic for FanView.xaml
    /// </summary>
    public partial class FanView : UserControl
    {
        readonly string TurnOffButtonIconPath = "/Images/FanAssest/shut.png";
        public FanView()
        {
            InitializeComponent();
            TurnOffButton.Content = new Image
            {
                Width = 120,
                Height = 120,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(TurnOffButtonIconPath, UriKind.Relative))
            };
        }

    }
}
