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
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        readonly string SettingButtonIconPath = "/Images/HomeAsset/st.png";
        readonly string TVButtonIconPath = "/Images/HomeAsset/tivi.png";
        readonly string LightButtonIconPath = "/Images/HomeAsset/light.png";
        readonly string ACButtonIconPath = "/Images/HomeAsset/air.png";
        readonly string FanButtonIconPath = "/Images/HomeAsset/fan2.png";
        public HomeView()
        {
            InitializeComponent();
            SettingButton.Content = new Image
            {
                Width = 140,
                Height = 140,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(SettingButtonIconPath, UriKind.Relative))
            };
            TVButton.Content = new Image
            {
                Width = 140,
                Height = 140,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(TVButtonIconPath, UriKind.Relative))
            };
            LightButton.Content = new Image
            {
                Width = 140,
                Height = 140,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(LightButtonIconPath, UriKind.Relative))
            };
            ACButton.Content = new Image
            {
                Width = 140,
                Height = 140,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(ACButtonIconPath, UriKind.Relative))
            };
            FanButton.Content = new Image
            {
                Width = 140,
                Height = 140,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(FanButtonIconPath, UriKind.Relative))
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
