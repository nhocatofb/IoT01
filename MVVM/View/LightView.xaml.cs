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
    /// Interaction logic for LightView.xaml
    /// </summary>
    public partial class LightView : UserControl
    {
        bool isOn = false;
        string iconOnPath = "/Images/LightAsset/light-on.png";
        string iconOffPath = "/Images/LightAsset/light-off.png";
        string nextStatePath = null;

        public LightView()
        {
            InitializeComponent();
            LightButton.Content = new Image
            {
                Width = 140,
                Height = 140,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(iconOffPath, UriKind.Relative))
            };
        }

        private void LightButton_Click(object sender, RoutedEventArgs e)
        {
            var message = "";
            if (isOn)
            {
                nextStatePath = iconOffPath;
                message = "{\"id\": \"1\", \"command\":\"off\"}";
            } 
            else
            {
                nextStatePath = iconOnPath;
                message = "{\"id\": \"1\", \"command\":\"on\"}";
            }
            isOn = !isOn;

            LightButton.Content = new Image
            {
                Width = 140,
                Height = 140,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Source = new BitmapImage(new Uri(nextStatePath, UriKind.Relative))
            };

            
            API.ApiHelper.RequestMessage(message);
            API.ApiHelper.PublicMessage();
        }
    }
}
