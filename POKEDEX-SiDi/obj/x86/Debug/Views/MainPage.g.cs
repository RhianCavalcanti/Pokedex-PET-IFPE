﻿#pragma checksum "C:\Users\Nilo Sandes\source\repos\RhianCavalcanti\Pokedex-PET-IFPE\POKEDEX-SiDi\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "813A5288EEB5C96F5B38C16D64E16445487829A2749FC91981D72AAA194A08C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POKEDEX_SiDi.Views
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 57
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 83
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4: // Views\MainPage.xaml line 87
                {
                    global::Windows.UI.Xaml.Controls.ListBox element4 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)element4).SelectionChanged += this.ListBox_SelectionChanged;
                }
                break;
            case 5: // Views\MainPage.xaml line 89
                {
                    this.Lista = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6: // Views\MainPage.xaml line 95
                {
                    this.Add = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7: // Views\MainPage.xaml line 18
                {
                    this.HambuguerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.HambuguerButton).Click += this.HambuguerButton_Click;
                }
                break;
            case 8: // Views\MainPage.xaml line 30
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.Back_Click;
                }
                break;
            case 9: // Views\MainPage.xaml line 42
                {
                    this.logo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.logo).PointerPressed += this.Click_Logo;
                }
                break;
            case 10: // Views\MainPage.xaml line 43
                {
                    this.NextPokemon = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.NextPokemon).Click += this.NextPokemon_Click;
                }
                break;
            case 11: // Views\MainPage.xaml line 44
                {
                    this.PreviousPokemon = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PreviousPokemon).Click += this.PreviousPokemon_Click;
                }
                break;
            case 12: // Views\MainPage.xaml line 47
                {
                    this.BarraPesquisa = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.BarraPesquisa).TextChanged += this.BarraPesquisa_TextChanged;
                }
                break;
            case 13: // Views\MainPage.xaml line 50
                {
                    this.Pesquisar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Pesquisar).Click += this.Pesquisar_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

