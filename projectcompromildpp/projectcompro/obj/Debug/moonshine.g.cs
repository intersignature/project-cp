﻿#pragma checksum "..\..\moonshine.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4D25B96B9703BB514BB2F816604CDA03"
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
    /// moonshine
    /// </summary>
    public partial class moonshine : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\moonshine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal projectcompro.moonshine moonstage;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\moonshine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image bg;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\moonshine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image door;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\moonshine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image portal1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\moonshine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image flare1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\moonshine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement warpsound;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\moonshine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement music;
        
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
            System.Uri resourceLocater = new System.Uri("/projectcompro;component/moonshine.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\moonshine.xaml"
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
            this.moonstage = ((projectcompro.moonshine)(target));
            
            #line 9 "..\..\moonshine.xaml"
            this.moonstage.Loaded += new System.Windows.RoutedEventHandler(this.moonstage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bg = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.door = ((System.Windows.Controls.Image)(target));
            
            #line 13 "..\..\moonshine.xaml"
            this.door.MouseEnter += new System.Windows.Input.MouseEventHandler(this.door_MouseEnter);
            
            #line default
            #line hidden
            
            #line 13 "..\..\moonshine.xaml"
            this.door.MouseLeave += new System.Windows.Input.MouseEventHandler(this.door_MouseLeave);
            
            #line default
            #line hidden
            
            #line 13 "..\..\moonshine.xaml"
            this.door.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.door_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.portal1 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.flare1 = ((System.Windows.Controls.Image)(target));
            
            #line 15 "..\..\moonshine.xaml"
            this.flare1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.flare1_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\moonshine.xaml"
            this.flare1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.flare1_MouseEnter);
            
            #line default
            #line hidden
            
            #line 15 "..\..\moonshine.xaml"
            this.flare1.MouseLeave += new System.Windows.Input.MouseEventHandler(this.flare1_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.warpsound = ((System.Windows.Controls.MediaElement)(target));
            
            #line 16 "..\..\moonshine.xaml"
            this.warpsound.MediaEnded += new System.Windows.RoutedEventHandler(this.warpsound_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.music = ((System.Windows.Controls.MediaElement)(target));
            
            #line 17 "..\..\moonshine.xaml"
            this.music.MediaEnded += new System.Windows.RoutedEventHandler(this.music_MediaEnded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

