using POKEDEX_SiDi.ViewModel;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace POKEDEX_SiDi.Views
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class BuscaNomeID : Page
    {
        public BuscaNomeID()
        {
            
            this.InitializeComponent();
            //Operations.pokemonUnidade

            namePokemon.Text = Operations.pokemonUnidade.Name;
            typePokemon.Text = Operations.pokemonUnidade.Types;
            PesoPokemon.Text = Operations.pokemonUnidade.Weight.ToString() + "lb";
            AltPokemon.Text = Operations.pokemonUnidade.Height.ToString();
            SpeedPokemon.Text = Operations.pokemonUnidade.Speed.ToString();
            HpBarra.Value = Operations.pokemonUnidade.Hp;
            DefesaBarra.Value = Operations.pokemonUnidade.Defense;
            AtaqueBarra.Value = Operations.pokemonUnidade.Attack;
            SpAtkBarra.Value = Operations.pokemonUnidade.SpecialAttack;
            SpDefBarra.Value = Operations.pokemonUnidade.SpecialDefense;
            Uri uri = new Uri(Operations.pokemonUnidade.Image, UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            img.Source = imgSource;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_N_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
