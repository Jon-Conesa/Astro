﻿#pragma checksum "..\..\TecladoVersion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E671FFE37029B45A70D88B905207DAA7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace ASTRObeta {
    
    
    /// <summary>
    /// TecladoVersion
    /// </summary>
    public partial class TecladoVersion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\TecladoVersion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ASTRObeta.TecladoVersion Window;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\TecladoVersion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\TecladoVersion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\TecladoVersion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pass;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\TecladoVersion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Labell2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\TecladoVersion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\TecladoVersion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttv;
        
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
            System.Uri resourceLocater = new System.Uri("/ASTRObeta;component/tecladoversion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TecladoVersion.xaml"
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
            this.Window = ((ASTRObeta.TecladoVersion)(target));
            
            #line 8 "..\..\TecladoVersion.xaml"
            this.Window.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 8 "..\..\TecladoVersion.xaml"
            this.Window.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\TecladoVersion.xaml"
            this.Window.KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\TecladoVersion.xaml"
            this.Window.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseRightButtonDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\TecladoVersion.xaml"
            this.Window.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.Window_MouseWheel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            
            #line 10 "..\..\TecladoVersion.xaml"
            this.LayoutRoot.KeyDown += new System.Windows.Input.KeyEventHandler(this.LayoutRoot_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBox2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Pass = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\TecladoVersion.xaml"
            this.Pass.Click += new System.Windows.RoutedEventHandler(this.Pass_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Labell2 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Button = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\TecladoVersion.xaml"
            this.Button.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txttv = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 40 "..\..\TecladoVersion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

