﻿#pragma checksum "..\..\LoginScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9B8A984F4C460C29A92CDB3C55A24F8803F7D6051AB0BB2B9147E501B453FD66"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RealTimeChatApp;
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


namespace RealTimeChatApp {
    
    
    /// <summary>
    /// LoginScreen
    /// </summary>
    public partial class LoginScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputUsername;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox inputPassword;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSignup;
        
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
            System.Uri resourceLocater = new System.Uri("/RealTimeChatApp;component/loginscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginScreen.xaml"
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
            
            #line 8 "..\..\LoginScreen.xaml"
            ((RealTimeChatApp.LoginScreen)(target)).Loaded += new System.Windows.RoutedEventHandler(this.LoginLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.inputUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.inputPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\LoginScreen.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.AttemptUserAuthentication);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSignup = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\LoginScreen.xaml"
            this.btnSignup.Click += new System.Windows.RoutedEventHandler(this.OpenSignupForm);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

