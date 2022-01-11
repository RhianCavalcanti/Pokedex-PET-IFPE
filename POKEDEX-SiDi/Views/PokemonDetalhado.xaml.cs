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
using Windows.UI.Xaml.Media.Imaging;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace POKEDEX_SiDi.Views
{
    public sealed partial class PokemonDetalhado : Page
    {
        List<PokemonDb> listaParaATela;
        ObservableCollection<PokemonDb> observable;
        PokemonDb pokeSelected;
        static int I=0;

        

        public PokemonDetalhado()
        {
            this.InitializeComponent();
            DbClass.InitializeDB();
            if (Operations.Modo == "default")
            {                 
                if (I == 0)
                {
                    Operations.PaginacaoPositiva();
                    I++;
                }
                listaParaATela = Operations.ListaDePokemon();
                //ObservableCollection <PokemonDb> observable = new ObservableCollection<PokemonDb>(listaParaATela);
            }else if(Operations.Modo == "type")
            {
                listaParaATela = Operations.ListaDePokemonType();
                //Frame.Navigate(typeof(PokemonDetalhado));
            }
        }


        private void NextTenPokemon_Click(object sender, RoutedEventArgs e)
        {
            if(Operations.Modo == "default")
            {
            listaParaATela.Clear();
            Operations.PaginacaoPositiva();
            listaParaATela = Operations.ListaDePokemon();
            Frame.Navigate(typeof(PokemonDetalhado));
            }
            else if(Operations.Modo == "type")
            {
                listaParaATela.Clear();
                Operations.PaginacaoPositivaType();
                listaParaATela = Operations.ListaDePokemonType();
                Frame.Navigate(typeof(PokemonDetalhado));

            }
        }

        private void PreviousTenPokemon_Click(object sender, RoutedEventArgs e)
        {
            if(Operations.Modo == "default")
            {
                listaParaATela.Clear();
                Operations.PaginacaoNegativa();
                listaParaATela = Operations.ListaDePokemon();
                Frame.Navigate(typeof(PokemonDetalhado));
            }
            else if(Operations.Modo == "type")
            {
                listaParaATela.Clear();
                Operations.PaginacaoNegativaType();
                listaParaATela = Operations.ListaDePokemonType();
                Frame.Navigate(typeof(PokemonDetalhado));
            }
            
        }

        private void ListaPokemonsD_ItemClick(object sender, ItemClickEventArgs e)
        {
            pokeSelected = (PokemonDb)e.ClickedItem;
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
            Uri uri = new Uri(pokeSelected.Image, UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            img.Source = imgSource;

        }
    }
}
