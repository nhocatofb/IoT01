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
        readonly string TurnOffButtonIconPath = "/Images/FanAsset/shut.png";
        readonly string OneButtonIconPath = "/Images/FanAsset/1.png";
        readonly string TwoButtonIconPath = "/Images/FanAsset/2.png";
        readonly string ThreeButtonIconPath = "/Images/FanAsset/3.png";
        readonly string SwingButtonIconPath = "/Images/FanAsset/rotate.png";
        public FanView()
        {
            InitializeComponent();
            TurnOffButton.Content = new Image
            {
                Width = 110,
                Height = 110,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(TurnOffButtonIconPath, UriKind.Relative))
            };
            FirstLevelButton.Content = new Image
            {
                Width = 90,
                Height = 90,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(OneButtonIconPath, UriKind.Relative))
            };
            SecondLevelButton.Content = new Image
            {
                Width = 90,
                Height = 90,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(TwoButtonIconPath, UriKind.Relative))
            };
            ThirdLevelButton.Content = new Image
            {
                Width = 90,
                Height = 90,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(ThreeButtonIconPath, UriKind.Relative))
            };
            SwingButton.Content = new Image
            {
                Width = 210,
                Height = 210,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(SwingButtonIconPath, UriKind.Relative))
            };


        }

    }
}
