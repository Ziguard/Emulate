﻿#pragma checksum "..\..\..\..\..\views\usercontrols\ListUserControl\ListBossUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F52AE06207A292B9ACD82138DB1DC9FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using BisMythicPlus.views.usercontrols;
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


namespace BisMythicPlus.views.usercontrols.ListUserControl {
    
    
    /// <summary>
    /// ListBossUserControl
    /// </summary>
    public partial class ListBossUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\views\usercontrols\ListUserControl\ListBossUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView itemList;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\views\usercontrols\ListUserControl\ListBossUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu ZoneIformationList;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\views\usercontrols\ListUserControl\ListBossUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DuplicateAnimalContextMenu;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\views\usercontrols\ListUserControl\ListBossUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RemoveAnimalContextMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/Emulate;component/views/usercontrols/listusercontrol/listbossusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\views\usercontrols\ListUserControl\ListBossUserControl.xaml"
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
            this.itemList = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.ZoneIformationList = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 3:
            this.DuplicateAnimalContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\..\..\views\usercontrols\ListUserControl\ListBossUserControl.xaml"
            this.DuplicateAnimalContextMenu.Click += new System.Windows.RoutedEventHandler(this.ClickMenuDupli);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RemoveAnimalContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\..\..\views\usercontrols\ListUserControl\ListBossUserControl.xaml"
            this.RemoveAnimalContextMenu.Click += new System.Windows.RoutedEventHandler(this.ClickMenuDel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

