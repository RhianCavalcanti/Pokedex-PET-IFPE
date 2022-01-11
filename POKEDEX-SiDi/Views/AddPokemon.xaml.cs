using POKEDEX_SiDi.Model;
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
    public sealed partial class AddPokemon : Page
    {
        public AddPokemon()
        {
            this.InitializeComponent();
        }
        static int I = 898;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            saveFly.Hide();
            

            
            
            PokemonDb NovoPokemon = new PokemonDb();
            int number = DbClass.Count();
            NovoPokemon.Id = 899 + number;
            NovoPokemon.Name = NameBox.Text;
            NovoPokemon.Types = EspecieBox.Text;
            NovoPokemon.Attack = int.Parse(AtkBox.Text);
            NovoPokemon.Defense = int.Parse(defValue.Text);

            DbClass.Add(NovoPokemon);
        }

        //public static void CadastrarNovoPokemon()
        //{
        //    string name = NameBox.Text;
        //    PokemonDb NovoPokemon = new PokemonDb();
        //    NovoPokemon.Name = 


        //    DbClass.Add(NovoPokemon);

        //}
    }
}
