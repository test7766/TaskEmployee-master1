﻿#pragma checksum "..\..\..\Menu\StatisticDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8089723ABBBD4D0F47EA931A41F20F155C13C71282A9E09EA692118644851E4E"
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
using WpfApp1.Crud;


namespace WpfApp1.Crud {
    
    
    /// <summary>
    /// StatisticDialog
    /// </summary>
    public partial class StatisticDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Menu\StatisticDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtCount;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Menu\StatisticDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtMinSalary;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Menu\StatisticDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtAvergeSalary;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Menu\StatisticDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtMaxSalary;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Menu\StatisticDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtFire;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Menu\StatisticDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSalary;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Menu\StatisticDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtdate_of_employment;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Menu\StatisticDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtdate_of_dismissal;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/menu/statisticdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Menu\StatisticDialog.xaml"
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
            this.txtCount = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txtMinSalary = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtAvergeSalary = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtMaxSalary = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtFire = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtSalary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtdate_of_employment = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.txtdate_of_dismissal = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            
            #line 141 "..\..\..\Menu\StatisticDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

