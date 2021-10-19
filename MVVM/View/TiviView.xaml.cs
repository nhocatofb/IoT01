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
    /// Interaction logic for Tivi.xaml
    /// </summary>
    public partial class Tivi : UserControl
    {
        readonly string UpButtonIconPath = "/Images/TVAsset/left.png";
        readonly string DownButtonIconPath = "/Images/TVAsset/down.png";
        readonly string TurnOffButtonIconPath = "/Images/TVAsset/shut.png";
        readonly string TopRightButtonIconPath = "/Images/TVAsset/shut.png";
        readonly string MiddleUpButtonIconPath = "/Images/TVAsset/right.png";
        readonly string MiddleDownButtonIconPath = "/Images/TVAsset/up.png";
        public Tivi()
        {
            InitializeComponent();
            UpButton.Content = new Image
            {
                Width = 120,
                Height = 120,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(UpButtonIconPath, UriKind.Relative))
            };
            MiddleUp.Content = new Image
            {
                Width = 120,
                Height = 120,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(MiddleUpButtonIconPath, UriKind.Relative))
            };
            DownButton.Content = new Image
            {
                Width = 90,
                Height = 90,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(DownButtonIconPath, UriKind.Relative))
            };
            MiddleDown.Content = new Image
            {
                Width = 90,
                Height = 90,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(MiddleDownButtonIconPath, UriKind.Relative))
            };

            TurnOffButton.Content = new Image
            {
                Width = 140,
                Height = 140,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(TurnOffButtonIconPath, UriKind.Relative))
            };
        }
    }
}
