#pragma checksum "C:\Users\Nilo Sandes\source\repos\RhianCavalcanti\Pokedex-PET-IFPE\POKEDEX-SiDi\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B2B74B60D93044305DBF8FD9FBC5EF32E14E84A12445450F1D8C64B762733574"
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
            case 2: // Views\MainPage.xaml line 28
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 47
                {
                    this.Pokelist = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Views\MainPage.xaml line 49
                {
                    this.singlePokemon = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 5: // Views\MainPage.xaml line 53
                {
                    this.List_pokemon = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.List_pokemon).PointerPressed += this.VerDetalhes;
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.List_pokemon).PointerEntered += this.PointerEnteredPokemon;
                }
                break;
            case 6: // Views\MainPage.xaml line 77
                {
                    this.Numero = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Views\MainPage.xaml line 56
                {
                    this.photo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8: // Views\MainPage.xaml line 57
                {
                    this.Details = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9: // Views\MainPage.xaml line 59
                {
                    this.Nome = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Views\MainPage.xaml line 60
                {
                    this.TipoPokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\MainPage.xaml line 61
                {
                    this.AtkPokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\MainPage.xaml line 62
                {
                    this.Habilidades = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\MainPage.xaml line 18
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.Back_Click;
                }
                break;
            case 14: // Views\MainPage.xaml line 19
                {
                    this.logo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Views\MainPage.xaml line 20
                {
                    this.NextPokemon = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.NextPokemon).Click += this.NextPokemon_Click;
                }
                break;
            case 16: // Views\MainPage.xaml line 21
                {
                    this.PreviousPokemon = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PreviousPokemon).Click += this.PreviousPokemon_Click;
                }
                break;
            case 17: // Views\MainPage.xaml line 22
                {
                    this.BarraPesquisa = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.BarraPesquisa).TextChanged += this.BarraPesquisa_TextChanged;
                }
                break;
            case 18: // Views\MainPage.xaml line 23
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

