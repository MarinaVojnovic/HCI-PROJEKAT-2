#pragma checksum "..\..\ShowTags.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BF6925FDF1C9DD44841788A6745E658354323DAB"
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


namespace ResourcesApplication
{


    /// <summary>
    /// ShowTags
    /// </summary>
    public partial class ShowTags : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 27 "..\..\ShowTags.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tagsGrid;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ResourcesApplication;component/showtags.xaml", System.UriKind.Relative);

#line 1 "..\..\ShowTags.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.tagsGrid = ((System.Windows.Controls.DataGrid)(target));

#line 27 "..\..\ShowTags.xaml"
                    this.tagsGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tagsGrid_MouseDoubleClick);

#line default
#line hidden

#line 27 "..\..\ShowTags.xaml"
                    this.tagsGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tagsGrid_SelectionChanged);

#line default
#line hidden
                    return;
                case 2:
                    this.buttonEdit = ((System.Windows.Controls.Button)(target));

#line 41 "..\..\ShowTags.xaml"
                    this.buttonEdit.Click += new System.Windows.RoutedEventHandler(this.buttonEdit_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.buttonDelete = ((System.Windows.Controls.Button)(target));

#line 47 "..\..\ShowTags.xaml"
                    this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.buttonDelete_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

