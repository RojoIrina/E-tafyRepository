﻿#pragma checksum "..\..\..\..\View\FormulaireVendeur.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FCD1A65DCAFDE007B23F0D2C7696B776B315C418"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
    /// FormulaireVendeur
    /// </summary>
    public partial class FormulaireVendeur : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\View\FormulaireVendeur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ModeEthiqueEtafy.View.FormulaireVendeur formulaireVendeur;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\FormulaireVendeur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Annuler;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\..\View\FormulaireVendeur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox motDePasse;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\View\FormulaireVendeur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox confirmationMotDePasse;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\View\FormulaireVendeur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SinscrireBouton;
        
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
            System.Uri resourceLocater = new System.Uri("/ModeEthiqueEtafy;component/view/formulairevendeur.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\FormulaireVendeur.xaml"
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
            this.formulaireVendeur = ((ModeEthiqueEtafy.View.FormulaireVendeur)(target));
            return;
            case 2:
            this.Annuler = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\View\FormulaireVendeur.xaml"
            this.Annuler.Click += new System.Windows.RoutedEventHandler(this.Annuler_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.motDePasse = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 141 "..\..\..\..\View\FormulaireVendeur.xaml"
            this.motDePasse.PasswordChanged += new System.Windows.RoutedEventHandler(this.motDePasse_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.confirmationMotDePasse = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 148 "..\..\..\..\View\FormulaireVendeur.xaml"
            this.confirmationMotDePasse.PasswordChanged += new System.Windows.RoutedEventHandler(this.confirmationMotDePasse_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SinscrireBouton = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\..\..\View\FormulaireVendeur.xaml"
            this.SinscrireBouton.Click += new System.Windows.RoutedEventHandler(this.SinscrireBouton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
