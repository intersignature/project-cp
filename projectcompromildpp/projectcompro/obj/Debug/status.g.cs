﻿#pragma checksum "..\..\status.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5AE8B853DA0562331C0D598B8966F951"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using projectcompro;


namespace projectcompro {
    
    
    /// <summary>
    /// status
    /// </summary>
    public partial class status : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image bg;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image inven;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image door;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement music;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\status.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement jick;
        
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
            System.Uri resourceLocater = new System.Uri("/projectcompro;component/status.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\status.xaml"
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
            
            #line 9 "..\..\status.xaml"
            ((projectcompro.status)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bg = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.inven = ((System.Windows.Controls.Image)(target));
            
            #line 13 "..\..\status.xaml"
            this.inven.MouseEnter += new System.Windows.Input.MouseEventHandler(this.inven_MouseEnter);
            
            #line default
            #line hidden
            
            #line 13 "..\..\status.xaml"
            this.inven.MouseLeave += new System.Windows.Input.MouseEventHandler(this.inven_MouseLeave);
            
            #line default
            #line hidden
            
            #line 13 "..\..\status.xaml"
            this.inven.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.inven_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.door = ((System.Windows.Controls.Image)(target));
            
            #line 14 "..\..\status.xaml"
            this.door.MouseEnter += new System.Windows.Input.MouseEventHandler(this.door_MouseEnter);
            
            #line default
            #line hidden
            
            #line 14 "..\..\status.xaml"
            this.door.MouseLeave += new System.Windows.Input.MouseEventHandler(this.door_MouseLeave);
            
            #line default
            #line hidden
            
            #line 14 "..\..\status.xaml"
            this.door.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.door_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.music = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 6:
            this.jick = ((System.Windows.Controls.MediaElement)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

