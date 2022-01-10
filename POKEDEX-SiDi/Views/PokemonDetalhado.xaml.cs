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
using POKEDEX_SiDi.ViewModel;
using POKEDEX_SiDi.Model;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace POKEDEX_SiDi.Views
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class PokemonDetalhado : Page
    {

        List<PokemonDb> listaParaTela;
        public PokemonDetalhado()
        {
            this.InitializeComponent();
            listaParaTela = Operations.ListaDePokemon();
            //var nada = IncrementalLoadingTrigger.None;
            //var incrementar = IncrementalLoadingTrigger.Edge;
            //if (incrementar == incrementar)
            //{

            //}
            //set valores dos campos já aqui chamando do BD
        }

        
        //private void Button_Click(object sender, RoutedEventArgs e) //Botão de teste, depois será removido
        //{
        //    Frame.Navigate(typeof(MainPage));
        //}

        //private void Back_Click(object sender, RoutedEventArgs e)
        //{
        //    if (Frame.CanGoBack)
        //    {
        //        Frame.GoBack();
        //    }
        //}

        private void NextTenPokemon_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Operations.PaginacaoPositiva();
            //vai chamar os próximos 10 pokémon na lista do BD (dependendo do modo de organização escolhido)
        }

        private void PreviousTenPokemon_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Operations.PaginacaoNegativa();
            //vai acessar os 10 pokémon anteriores na lista do BD (dependendo do modo de organização escolhido)
        }

        private void ListaPokemonsD_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if(ListaPokemonsD.SelectedItem == null)
            //{
            //    ListaPokemonsD.SelectedIndex = 0;
            //}
            //ListaPokemonsD.SelectedItem = ListaPokemonsD.ScaleTransition;
            

        }

        //private void StackPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        
        //}

        private void PreviousPokemonImg_Click(object sender, RoutedEventArgs e)
        {
            //get imagem anterior
        }

        private void NextPokemonImg_Click(object sender, RoutedEventArgs e)
        {
            //get() próxima imagem
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //vai levar à página de edição
            Frame.Navigate(typeof(Edit));

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //chamar método para apagar o pokémon da lista
        }

        private void Delete_N_Click(object sender, RoutedEventArgs e)
        {
            DeleteConfirm.Hide();
        }
    }
}
