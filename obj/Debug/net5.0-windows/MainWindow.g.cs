#pragma checksum "..\..\..\mainwindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "883118AC8E764AF7C18FA35002AB9515A4472C38"
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
using System.Windows.Controls.Ribbon;
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
using VendingMachine;


namespace VendingMachine {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 11 "..\..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox DrinksList;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label money;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button one;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button two;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button five;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ten;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cash;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button admin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VendingMachine;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\mainwindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\mainwindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DrinksList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            
            #line 71 "..\..\..\mainwindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.money = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.one = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\mainwindow.xaml"
            this.one.Click += new System.Windows.RoutedEventHandler(this.Coin_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.two = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\mainwindow.xaml"
            this.two.Click += new System.Windows.RoutedEventHandler(this.Coin_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.five = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\mainwindow.xaml"
            this.five.Click += new System.Windows.RoutedEventHandler(this.Coin_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ten = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\mainwindow.xaml"
            this.ten.Click += new System.Windows.RoutedEventHandler(this.Coin_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cash = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\mainwindow.xaml"
            this.cash.Click += new System.Windows.RoutedEventHandler(this.cash_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.admin = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\mainwindow.xaml"
            this.admin.Click += new System.Windows.RoutedEventHandler(this.admin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 28 "..\..\..\mainwindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Item_MouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

