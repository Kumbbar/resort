﻿#pragma checksum "..\..\..\Windows\HotelsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F35A13F0D344494697B95E7C89756785AD162F5384BCC7946AC7DA2DD6C6378C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using resort.Windows;


namespace resort.Windows {
    
    
    /// <summary>
    /// HotelsWindow
    /// </summary>
    public partial class HotelsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\..\Windows\HotelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DtGrHotels;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\HotelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFirst;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\HotelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPrevious;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\HotelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNumPage;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\HotelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbNumPage;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\HotelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNext;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\HotelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLast;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Windows\HotelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreateHotel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/resort;component/windows/hotelswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\HotelsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DtGrHotels = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.BtnFirst = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Windows\HotelsWindow.xaml"
            this.BtnFirst.Click += new System.Windows.RoutedEventHandler(this.BtnFirst_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnPrevious = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Windows\HotelsWindow.xaml"
            this.BtnPrevious.Click += new System.Windows.RoutedEventHandler(this.BtnPrevious_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtNumPage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.LbNumPage = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.BtnNext = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Windows\HotelsWindow.xaml"
            this.BtnNext.Click += new System.Windows.RoutedEventHandler(this.BtnNext_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnLast = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Windows\HotelsWindow.xaml"
            this.BtnLast.Click += new System.Windows.RoutedEventHandler(this.BtnLast_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnCreateHotel = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Windows\HotelsWindow.xaml"
            this.BtnCreateHotel.Click += new System.Windows.RoutedEventHandler(this.BtnCreateHotel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 22 "..\..\..\Windows\HotelsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDtGr_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

