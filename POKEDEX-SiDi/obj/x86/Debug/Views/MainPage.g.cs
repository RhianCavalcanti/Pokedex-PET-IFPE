﻿#pragma checksum "C:\Users\Nilo Sandes\source\repos\RhianCavalcanti\Pokedex-PET-IFPE\POKEDEX-SiDi\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B944EB5549A45DC7710AA73C82BD4ADC3EBB79968AAB7C417F079C73C591857C"
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
            case 2: // Views\MainPage.xaml line 110
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 142
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4: // Views\MainPage.xaml line 146
                {
                    global::Windows.UI.Xaml.Controls.ListBox element4 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)element4).SelectionChanged += this.ListBox_SelectionChanged;
                }
                break;
            case 5: // Views\MainPage.xaml line 148
                {
                    this.Lista = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6: // Views\MainPage.xaml line 154
                {
                    this.Add = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7: // Views\MainPage.xaml line 160
                {
                    this.Details = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 8: // Views\MainPage.xaml line 21
                {
                    this.HambuguerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.HambuguerButton).Click += this.HambuguerButton_Click;
                }
                break;
            case 9: // Views\MainPage.xaml line 33
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.Back_Click;
                }
                break;
            case 10: // Views\MainPage.xaml line 45
                {
                    this.logo = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.logo).PointerPressed += this.Click_Logo;
                }
                break;
            case 11: // Views\MainPage.xaml line 83
                {
                    this.BuscaPor = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.BuscaPor).SelectionChanged += this.BuscaPor_SelectionChanged;
                }
                break;
            case 12: // Views\MainPage.xaml line 88
                {
                    this.MyAutoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.MyAutoSuggestBox).TextChanged += this.MyAutoSuggestBox_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.MyAutoSuggestBox).SuggestionChosen += this.MyAutoSuggestBox_SuggestionChosen;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.MyAutoSuggestBox).QuerySubmitted += this.MyAutoSuggestBox_QuerySubmitted;
                }
                break;
            case 13: // Views\MainPage.xaml line 84
                {
                    this.PorNome = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 14: // Views\MainPage.xaml line 85
                {
                    this.PorTipo = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 15: // Views\MainPage.xaml line 86
                {
                    this.PorNumero = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
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

