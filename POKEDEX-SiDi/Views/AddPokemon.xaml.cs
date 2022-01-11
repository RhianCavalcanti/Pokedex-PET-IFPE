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
            try
            {

                saveFly.Hide();
            
                PokemonDb NovoPokemon = new PokemonDb();
                int number = 0;
                if (DbClass.Count() == 0)
                {
                    number = number;
                }
                else
                {
                    number = DbClass.Count();
                }              
                NovoPokemon.Id = 899 + number;
                NovoPokemon.Name = NameBox.Text + " User";
                NovoPokemon.Types = EspecieBox.Text;
                NovoPokemon.Hp = int.Parse(hpValue.Text);
                NovoPokemon.Attack = int.Parse(AtkBox.Text);
                NovoPokemon.Defense = int.Parse(defValue.Text);
                NovoPokemon.SpecialAttack = int.Parse(SPAtkValue.Text);
                NovoPokemon.SpecialDefense = int.Parse(SPdefValue.Text);
                NovoPokemon.Speed = int.Parse(speedValue.Text);
                NovoPokemon.Weight = int.Parse(pesoValue.Text);
                NovoPokemon.Height = int.Parse(heightValue.Text);
                NovoPokemon.Image = file.Text;
                DbClass.Add(NovoPokemon);
                Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Clear()
        {
            NameBox.Text = "";
            EspecieBox.Text = "";
            hpValue.Text = "";
            AtkBox.Text = "";
            defValue.Text = "";
            SPAtkValue.Text = "";
            SPdefValue.Text = "";
            speedValue.Text = "";
            pesoValue.Text = "";
            heightValue.Text = "";
            file.Text = "";

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
