﻿#pragma checksum "..\..\..\..\View\Cadastrar_User.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D9B796CC6708970DF35D533C7574CDE6F15099D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using DS_SISPRE;
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


namespace DS_SISPRE {
    
    
    /// <summary>
    /// Cadastrar_User
    /// </summary>
    public partial class Cadastrar_User : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\View\Cadastrar_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codigo;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\View\Cadastrar_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nome;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\Cadastrar_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cpf;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\Cadastrar_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rg;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\View\Cadastrar_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton func;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\Cadastrar_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton cliente;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\Cadastrar_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\Cadastrar_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox senha;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\Cadastrar_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox senha2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DS-SISPRE;V1.0.0.0;component/view/cadastrar_user.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Cadastrar_User.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.codigo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cpf = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\..\View\Cadastrar_User.xaml"
            this.cpf.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rg = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\View\Cadastrar_User.xaml"
            this.rg.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.func = ((System.Windows.Controls.RadioButton)(target));
            
            #line 21 "..\..\..\..\View\Cadastrar_User.xaml"
            this.func.Checked += new System.Windows.RoutedEventHandler(this.func_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cliente = ((System.Windows.Controls.RadioButton)(target));
            
            #line 22 "..\..\..\..\View\Cadastrar_User.xaml"
            this.cliente.Checked += new System.Windows.RoutedEventHandler(this.cliente_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.senha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.senha2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 31 "..\..\..\..\View\Cadastrar_User.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 32 "..\..\..\..\View\Cadastrar_User.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

