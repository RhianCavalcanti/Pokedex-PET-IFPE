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

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace POKEDEX_SiDi.Views
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
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
