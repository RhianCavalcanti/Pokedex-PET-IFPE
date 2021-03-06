using POKEDEX_SiDi.Model;
using POKEDEX_SiDi.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace POKEDEX_SiDi.Views
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        protected String ItemBus { get; set; } //provavelmente será chamado por uma Struct ou Enum em Views e lá chama o método de busca de acordo com o que foi selecionado
        public MainPage()
        {
            this.InitializeComponent();
            //MyFrame.Navigate(typeof(PokemonDetalhado));
            BackButton.Visibility = Visibility.Collapsed;
            MySplitView.IsPaneOpen = false;
            Details.IsEnabled = false;
        }
        
        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {
            
            TableSearch.cadastroUnidade(PesquisaName.Text);
            Operations.PokemonUnidade(PesquisaName.Text);
            BackButton.Visibility = Visibility.Visible;
            MyFrame.Navigate(typeof(BuscaNomeID));

        }

        

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                //BackButton.IsEnabled = false;
                MyFrame.GoBack();
                Lista.IsSelected = true;
                BackButton.Visibility = Visibility.Collapsed;
                MySplitView.IsPaneOpen = false;
            }
            else
            {
                BackButton.Visibility = Visibility.Visible;
                //BackButton.IsEnabled = true;
            }
        }

        private void PreviousPokemon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextPokemon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BarraPesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Frame.Navigate(typeof(SearchPage), BarraPesquisa.Text);
        }

        private void VerDetalhes(object sender, PointerRoutedEventArgs e)
        {
            BackButton.Visibility = Visibility.Visible;
            Details.IsEnabled = true;
            Details.IsSelected = true;
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame.Navigate(typeof(PokemonDetalhado));

            
        }

        private void PointerEnteredPokemon(object sender, PointerRoutedEventArgs e)
        {
            // Pointer. = Cursors.;
            //StackPanel.StyleProperty;
            //mainImage.Cursor = Cursor;
        }

        private void Click_Logo(object sender, PointerRoutedEventArgs e)
        {
            Operations.Modo = "default";
            Frame.Navigate(typeof(MainPage));
            //BackButton.Visibility = Visibility.Collapsed;
        }

        private void HambuguerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Lista.IsSelected)
            {
                Operations.Modo = "default";
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(PokemonDetalhado));
                MySplitView.IsPaneOpen = false;
            }
            else if (Add.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(AddPokemon));
                MySplitView.IsPaneOpen = false;
            }
            else if (Details.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(PokemonDetalhado));
                MySplitView.IsPaneOpen = false;
            }
            //else if(Lista.IsSelected && actual frame is Pokemon detalhado){                 BackButton.Visibility = Visibility.Visible;}
        }

        

        private void MyAutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            sender.Text = args.SelectedItem.ToString();
        }

        private void MyAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            BackButton.Visibility = Visibility.Visible;
            MyFrame.Navigate(typeof(BuscaNomeID));
        }

        private void BuscaPor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBusca = (ComboBox)sender;
            var itemBusca = (ComboBoxItem)comboBusca.SelectedItem;
            ItemBus = itemBusca.Content.ToString();
        }

        private void confirmSearchType_Click(object sender, RoutedEventArgs e)
        {
            Operations.especieName = textTypeSearch.Text;
            Operations.PaginacaoPositivaType();
            Operations.Modo = "type";
            MyFrame.Navigate(typeof(PokemonDetalhado));
        }

        private void MyAutoSuggestBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
