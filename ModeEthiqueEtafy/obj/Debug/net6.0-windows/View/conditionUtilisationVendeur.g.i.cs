﻿#pragma checksum "..\..\..\..\View\ConditionUtilisationVendeur.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26223C527CBF6D47EE40E6769246518AB767D4E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ModeEthiqueEtafy.View;
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


namespace ModeEthiqueEtafy.View {
    
    
    /// <summary>
    /// ConditionUtilisateur
    /// </summary>
    public partial class ConditionUtilisateur : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\View\ConditionUtilisationVendeur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ModeEthiqueEtafy.View.ConditionUtilisateur conditionUtilisateur;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\ConditionUtilisationVendeur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ConditionsUtilisationVendeur;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\View\ConditionUtilisationVendeur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnnulerButton;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\View\ConditionUtilisationVendeur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button JaccepteButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ModeEthiqueEtafy;component/view/conditionutilisationvendeur.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ConditionUtilisationVendeur.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.conditionUtilisateur = ((ModeEthiqueEtafy.View.ConditionUtilisateur)(target));
            return;
            case 2:
            this.ConditionsUtilisationVendeur = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.AnnulerButton = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\..\View\ConditionUtilisationVendeur.xaml"
            this.AnnulerButton.Click += new System.Windows.RoutedEventHandler(this.Annuler_Bouton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.JaccepteButton = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\..\..\View\ConditionUtilisationVendeur.xaml"
            this.JaccepteButton.Click += new System.Windows.RoutedEventHandler(this.Jaccepte_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

