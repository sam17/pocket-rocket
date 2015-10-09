using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace Pocket_Rockets
{
    public partial class PlayerMode : PhoneApplicationPage
    {
        public PlayerMode()
        {
            InitializeComponent();
        }

        private void Single_Click(object sender, RoutedEventArgs e)
        {
            string PlayerModeType = null;
            if (AcceleroSelect.IsChecked.Value == true)
            {
                PlayerModeType = "Accelero";
            }

            NavigationService.Navigate(new Uri("/StartMenu.xaml?msg=" + PlayerModeType, UriKind.RelativeOrAbsolute));
        }

        private void Multiplayer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnlineMultiplayer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}