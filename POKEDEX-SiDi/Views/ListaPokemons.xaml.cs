using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using POKEDEX_SiDi.Model;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace POKEDEX_SiDi.Views
{
    public sealed partial class ListaPokemons : Page
    {
        public ListaPokemons()
        {
            this.InitializeComponent();
            //NavigationViewBackButtonVisible.Collapsed = false;
        }

        private void PreviousPokemon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextPokemon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VerDetalhes(object sender, PointerRoutedEventArgs e)
        {
            //visible = NavigationViewBackButtonVisible.Visible;
            Frame.Navigate(typeof(PokemonDetalhado));
            //MainPage.BackButton.Visibility = Visibility.Visible;
        }

        private void Organizacao_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (ComboBoxResult == null) return;

            //var combo = (ComboBox)sender;
            //var item = combo.SelectedItem;
            //if (item..Equals("OrgNum"))
            //{
            //    //                MyFrame.Navigate(typeof(ListaPokemons));
            //    //Select from BD organizando por ID(chave primária)
            //    ComboBoxResult.Text = "Número";
            //}
            //else if (item.Name.Equals("OrgNome"))
            //{
            //    //Select from BD organizando pelo Nome
            //    ComboBoxResult.Text = "Nome";
            //}
            //else if (item.Name.Equals("OrgTipo"))
            //{
            //    //Select from BD organizando pelo Tipo
            //    ComboBoxResult.Text = "Tipo";
            //}
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(PokemonDetalhado));
        }

        private void LoadMore_Click(object sender, RoutedEventArgs e)
        {

        }


        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    //base.OnNavigatingFrom(e);
        //    MainPage.FrameProperty.GetType();

        //    BackButton.Visibility = Visibility.Visible;
        //    //if (!MyFrame.Content.GetType().Equals("ListaPokemon"))
        //    //{
        //    //    BackButton.Visibility = Visibility.Visible;
        //    //}
        //    //else
        //    //{
        //    //    BackButton.Visibility = Visibility.Collapsed;

        //    //}
        //}
    }
}
