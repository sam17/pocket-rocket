﻿#pragma checksum "D:\Owner\Desktop\VB.NET\learning\Pocket Rockets\Pocket Rockets\StartMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3DE3D856A3E6D2F2B86B8ADC3357BE4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Pocket_Rockets {
    
    
    public partial class StartMenu : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button PlayButton;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image YellowShip;
        
        internal System.Windows.Controls.Image RedShip;
        
        internal System.Windows.Controls.Button Exit;
        
        internal System.Windows.Controls.Button Rechoose;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Pocket%20Rockets;component/StartMenu.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PlayButton = ((System.Windows.Controls.Button)(this.FindName("PlayButton")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.YellowShip = ((System.Windows.Controls.Image)(this.FindName("YellowShip")));
            this.RedShip = ((System.Windows.Controls.Image)(this.FindName("RedShip")));
            this.Exit = ((System.Windows.Controls.Button)(this.FindName("Exit")));
            this.Rechoose = ((System.Windows.Controls.Button)(this.FindName("Rechoose")));
        }
    }
}

