﻿#pragma checksum "C:\Users\víctor\SkyDrive\Proyectos\NFCBattleShip\NFCBattleShip\FinPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E16944DEC11F066B94008783CDFF94F0"
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
    
    
    public partial class FinPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button Btn_Salir;
        
        internal System.Windows.Controls.Button Btn_Volver;
        
        internal System.Windows.Controls.TextBlock Tb_Ganar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/NFCBattleShip;component/FinPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Btn_Salir = ((System.Windows.Controls.Button)(this.FindName("Btn_Salir")));
            this.Btn_Volver = ((System.Windows.Controls.Button)(this.FindName("Btn_Volver")));
            this.Tb_Ganar = ((System.Windows.Controls.TextBlock)(this.FindName("Tb_Ganar")));
        }
    }
}

