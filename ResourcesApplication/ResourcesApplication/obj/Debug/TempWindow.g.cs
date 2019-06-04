﻿#pragma checksum "..\..\TempWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4CF7D927C3D3392397C9DEB7FE99A20049CFAFD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ResourcesApplication;
using ResourcesApplication.Commands;
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


namespace ResourcesApplication {
    
    
    /// <summary>
    /// TempWindow
    /// </summary>
    public partial class TempWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 97 "..\..\TempWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\TempWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Map;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\TempWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu contextMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/ResourcesApplication;component/tempwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TempWindow.xaml"
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
            
            #line 13 "..\..\TempWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.AddTag_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\TempWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ShowTags_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\TempWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.AddType_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 16 "..\..\TempWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ShowTypes_Executed);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 17 "..\..\TempWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.AddResource_Executed);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 18 "..\..\TempWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ShowResources_Executed);
            
            #line default
            #line hidden
            return;
            case 7:
            this.listView = ((System.Windows.Controls.ListView)(target));
            
            #line 97 "..\..\TempWindow.xaml"
            this.listView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listView_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 97 "..\..\TempWindow.xaml"
            this.listView.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListView_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 97 "..\..\TempWindow.xaml"
            this.listView.MouseMove += new System.Windows.Input.MouseEventHandler(this.ListView_MouseMove);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Map = ((System.Windows.Controls.Canvas)(target));
            
            #line 113 "..\..\TempWindow.xaml"
            this.Map.MouseMove += new System.Windows.Input.MouseEventHandler(this.Map_MouseMove);
            
            #line default
            #line hidden
            
            #line 113 "..\..\TempWindow.xaml"
            this.Map.DragEnter += new System.Windows.DragEventHandler(this.Map_DragEnter);
            
            #line default
            #line hidden
            
            #line 113 "..\..\TempWindow.xaml"
            this.Map.Drop += new System.Windows.DragEventHandler(this.Map_Drop);
            
            #line default
            #line hidden
            return;
            case 9:
            this.contextMenu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 10:
            
            #line 119 "..\..\TempWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.paste_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

