﻿#pragma checksum "..\..\AppointmentPatientHistoryPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7DDCB9DCD47A7D313FBAABCE74593E2ECD708548C4AB97D4E2F32D62FF73D217"
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
using System.Windows.Forms.Integration;
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


namespace Hospital_Management_System {
    
    
    /// <summary>
    /// AppointmentPatientHistoryPage
    /// </summary>
    public partial class AppointmentPatientHistoryPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AppointmentPatientHistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AppointmentPatientHistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid2;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AppointmentPatientHistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AppointmentPatientHistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewDetails;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AppointmentPatientHistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/Hospital Management System;component/appointmentpatienthistorypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AppointmentPatientHistoryPage.xaml"
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
            this.datagrid1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\AppointmentPatientHistoryPage.xaml"
            this.datagrid1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datagrid1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\AppointmentPatientHistoryPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\AppointmentPatientHistoryPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 4:
            this.datagrid2 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\AppointmentPatientHistoryPage.xaml"
            this.datagrid2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datagrid2_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.viewDetails = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AppointmentPatientHistoryPage.xaml"
            this.viewDetails.Click += new System.Windows.RoutedEventHandler(this.viewDetails_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\AppointmentPatientHistoryPage.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

