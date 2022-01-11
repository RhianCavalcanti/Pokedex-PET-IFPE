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
using System.Collections.ObjectModel;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace POKEDEX_SiDi.Views
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class PokemonDetalhado : Page
    {
        List<PokemonDb> listaParaATela;
        ObservableCollection<PokemonDb> observable;
        PokemonDb pokeSelected;
        //ObservableCollection<PokemonDb> = new ObservableCollection<PokemonDb>(ListaPokemons);

        public PokemonDetalhado()
        {
            
            this.InitializeComponent();
            DbClass.InitializeDB();
            Operations.PaginacaoPositiva();

            listaParaATela = /*(ObservableCollection<PokemonDb>)*/ Operations.ListaDePokemon();
            ObservableCollection <PokemonDb> observable = new ObservableCollection<PokemonDb>(listaParaATela);
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
            Operations.PaginacaoPositiva();
            listaParaATela = Operations.ListaDePokemon();
            Frame.Navigate(typeof(PokemonDetalhado));
            //ListaPokemonsD.ItemsSource = listaParaATela;


            //vai chamar os próximos 10 pokémon na lista do BD (dependendo do modo de organização escolhido)
        }

        private void PreviousTenPokemon_Click(object sender, RoutedEventArgs e)
        {
            Operations.PaginacaoNegativa();
            listaParaATela = Operations.ListaDePokemon();
            Frame.Navigate(typeof(PokemonDetalhado));
            //vai acessar os 10 pokémon anteriores na lista do BD (dependendo do modo de organização escolhido)
        }

        private void ListaPokemonsD_ItemClick(object sender, ItemClickEventArgs e)
        {
            pokeSelected = (PokemonDb)e.ClickedItem;
            //Altera os dados que são exibidos nos campos
            namePokemon.Text = pokeSelected.Name;
            typePokemon.Text = pokeSelected.Types;
            PesoPokemon.Text = pokeSelected.Weight.ToString() + "lb";
            AltPokemon.Text = pokeSelected.Height.ToString();
            SpeedPokemon.Text = pokeSelected.Speed.ToString();
            HpBarra.Value = pokeSelected.Hp;
            DefesaBarra.Value = pokeSelected.Defense;
            AtaqueBarra.Value = pokeSelected.Attack;
            SpAtkBarra.Value = pokeSelected.SpecialAttack;
            SpDefBarra.Value = pokeSelected.SpecialDefense;
            //ImageSource image = (ImageSource)pokeSelected.Image;
            //img.Source = pokeSelected.Image;

            //if (ListaPokemonsD.SelectedItem == null)
            //{
            //    ListaPokemonsD.SelectedIndex = 0;
            //}
            //else
            //{
            //    pokeSelected = (PokemonDb)e.ClickedItem;
            //}


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

        private void ListaPokemonsD_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {

        }
    }
}
