﻿#pragma checksum "..\..\..\..\UserControlls\DataPageContainer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C37396041D780697273B52A3B5B6289197C407CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Filns_UI.UserControlls;
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


namespace Filns_UI.UserControlls {
    
    
    /// <summary>
    /// DataPageContainer
    /// </summary>
    public partial class DataPageContainer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\UserControlls\DataPageContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label out_docPathTitle;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\UserControlls\DataPageContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox In_docPath;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\UserControlls\DataPageContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button In_PathBtn;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\UserControlls\DataPageContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImagePreview;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\UserControlls\DataPageContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border out_variableContainer;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\UserControlls\DataPageContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel varContainer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Filns_UI;V1.0.0.0;component/usercontrolls/datapagecontainer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControlls\DataPageContainer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.out_docPathTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.In_docPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.In_PathBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\UserControlls\DataPageContainer.xaml"
            this.In_PathBtn.Click += new System.Windows.RoutedEventHandler(this.In_PathBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImagePreview = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.out_variableContainer = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.varContainer = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
