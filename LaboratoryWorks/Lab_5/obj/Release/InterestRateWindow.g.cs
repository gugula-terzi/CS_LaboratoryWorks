﻿#pragma checksum "..\..\InterestRateWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "814AC24B063D9544737E812AB66F0C01377E994E62E6367B71432C315E0D8321"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab_5;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Lab_5 {
    
    
    /// <summary>
    /// InterestRateWindow
    /// </summary>
    public partial class InterestRateWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\InterestRateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid NavPanel;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\InterestRateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomInterestRate;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\InterestRateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitInterestRateBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Lab_5;component/interestratewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InterestRateWindow.xaml"
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
            this.NavPanel = ((System.Windows.Controls.Grid)(target));
            
            #line 35 "..\..\InterestRateWindow.xaml"
            this.NavPanel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NavPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CustomInterestRate = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\InterestRateWindow.xaml"
            this.CustomInterestRate.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CheckInput_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SubmitInterestRateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\InterestRateWindow.xaml"
            this.SubmitInterestRateBtn.Click += new System.Windows.RoutedEventHandler(this.SubmitInterestRateBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

