using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Pocket_Rockets.Resources;
using System.Windows.Threading;

namespace Pocket_Rockets
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }



        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PlayerMode.xaml", UriKind.RelativeOrAbsolute));
        }
    
     
    }
}