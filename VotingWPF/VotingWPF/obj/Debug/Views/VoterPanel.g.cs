﻿#pragma checksum "..\..\..\Views\VoterPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C583AA94A76C0390FBA7985F71320FCD6D81F990"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using VotingWPF;


namespace VotingWPF {
    
    
    /// <summary>
    /// VoterPanel
    /// </summary>
    public partial class VoterPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\VoterPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoLogButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\VoterPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoRegButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\VoterPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/VotingWPF;component/views/voterpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\VoterPanel.xaml"
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
            this.GoLogButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Views\VoterPanel.xaml"
            this.GoLogButton.Click += new System.Windows.RoutedEventHandler(this.GoLogButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoRegButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Views\VoterPanel.xaml"
            this.GoRegButton.Click += new System.Windows.RoutedEventHandler(this.GoRegButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GoBackButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Views\VoterPanel.xaml"
            this.GoBackButton.Click += new System.Windows.RoutedEventHandler(this.GoBackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

