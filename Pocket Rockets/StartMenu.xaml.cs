using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Pocket_Rockets
{
    public partial class StartMenu : PhoneApplicationPage
    {
        string PlayerModeType;
        public StartMenu()
        {
            InitializeComponent();

        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string msg = "";

            if (NavigationContext.QueryString.TryGetValue("msg", out msg))
                PlayerModeType = msg;
        }

        private void YellowShip_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RedShip.Opacity = 0;
            
        }

        private void RedShip_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            YellowShip.Opacity = 0;
            
        }

        private void Rechoose_Click(object sender, RoutedEventArgs e)
        {
            //  Thickness YellowMargin = new Thickness(27,47,0,0);
            //  Thickness RedMargin = new   Thickness(269,47,0,0);
            RedShip.Opacity = 100;
            YellowShip.Opacity = 100;
            //   YellowShip.Margin = YellowMargin;
            //   RedShip.Margin = RedMargin;
        }
       

    }
}