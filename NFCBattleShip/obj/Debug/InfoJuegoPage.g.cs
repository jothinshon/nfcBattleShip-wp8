﻿#pragma checksum "C:\Users\Victor\SkyDrive\Proyectos\NFCBattleShip\AppWindowsPhone\NFCBattleShip\InfoJuegoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EBA0AED6D0AF38B84BE97E486CB8E711"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18033
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace NFCBattleShip {
    
    
    public partial class InfoJuegoPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image Logo;
        
        internal System.Windows.Controls.TextBlock Tb_info;
        
        internal System.Windows.Controls.Button BotonSiguiente;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/NFCBattleShip;component/InfoJuegoPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Logo = ((System.Windows.Controls.Image)(this.FindName("Logo")));
            this.Tb_info = ((System.Windows.Controls.TextBlock)(this.FindName("Tb_info")));
            this.BotonSiguiente = ((System.Windows.Controls.Button)(this.FindName("BotonSiguiente")));
        }
    }
}

