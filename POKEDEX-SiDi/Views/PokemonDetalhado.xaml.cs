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
    public sealed partial class PokemonDetalhado : Page
    {
        public PokemonDetalhado()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Botão de teste, depois será removido
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void logo_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void NextPokemon_Click(object sender, RoutedEventArgs e)
        {
            //vai acessar o próximo pokémon na lista do BD (dependendo do modo de organização escolhido)
        }

        private void PreviousPokemon_Click(object sender, RoutedEventArgs e)
        {
            //vai acessar o pokémon anterior na lista do BD (dependendo do modo de organização escolhido)
        }

        private void BarraPesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
