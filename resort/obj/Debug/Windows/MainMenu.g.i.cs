﻿#pragma checksum "..\..\..\Windows\MainMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9F0AB73C22343450BFA27B17F71EFDECD6FD638CE1034A92980295F4C576B7D4"
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
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Windows\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOpenHotels;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtTourName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbxTypes;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Windows\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListTours;
        
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
            System.Uri resourceLocater = new System.Uri("/resort;component/windows/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainMenu.xaml"
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
            this.BtnOpenHotels = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Windows\MainMenu.xaml"
            this.BtnOpenHotels.Click += new System.Windows.RoutedEventHandler(this.BtnOpenHotels_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtTourName = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\Windows\MainMenu.xaml"
            this.TxtTourName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtTourName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CmbxTypes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 49 "..\..\..\Windows\MainMenu.xaml"
            this.CmbxTypes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbxTypes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListTours = ((System.Windows.Controls.ListView)(target));
            
            #line 54 "..\..\..\Windows\MainMenu.xaml"
            this.ListTours.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListTours_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

