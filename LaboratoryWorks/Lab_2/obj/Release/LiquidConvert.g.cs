﻿#pragma checksum "..\..\LiquidConvert.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5157F273584B6669D183755C52709D70770953BE3BCAF8F5E5CACC76F6D61AAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MyProject;
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


namespace MyProject {
    
    
    /// <summary>
    /// LiquidConvert
    /// </summary>
    public partial class LiquidConvert : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\LiquidConvert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border NavPanel;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\LiquidConvert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DegreeTextBox;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\LiquidConvert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConvertDestanceBtn;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\LiquidConvert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CubicMeterLabel;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\LiquidConvert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BarrelLabel;
        
        #line default
        #line hidden
        
        
        #line 246 "..\..\LiquidConvert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GallonLabel;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\LiquidConvert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BusheLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/MyProject;component/liquidconvert.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LiquidConvert.xaml"
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
            this.NavPanel = ((System.Windows.Controls.Border)(target));
            
            #line 53 "..\..\LiquidConvert.xaml"
            this.NavPanel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NavPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 58 "..\..\LiquidConvert.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NavPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 76 "..\..\LiquidConvert.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 89 "..\..\LiquidConvert.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HideBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DegreeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 118 "..\..\LiquidConvert.xaml"
            this.DegreeTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.DegreeTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 119 "..\..\LiquidConvert.xaml"
            this.DegreeTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DegreeTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ConvertDestanceBtn = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\LiquidConvert.xaml"
            this.ConvertDestanceBtn.Click += new System.Windows.RoutedEventHandler(this.ConvertDestanceBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CubicMeterLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.BarrelLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.GallonLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.BusheLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
