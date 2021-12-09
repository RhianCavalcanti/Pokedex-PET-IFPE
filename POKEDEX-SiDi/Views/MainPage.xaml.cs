﻿using System;
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
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(ListaPokemons));
            //BackButton.Visibility = Visibility.Collapsed;
            //Visibility_Back_Click();
        }

        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {
            //String visivel = Barra_pesquisa.Visibility;
            //if(visivel.Equals("Collapsed"))
            //{
            //    visivel = 
            //}
        }

        //protected void Visibility_Back_Click()
        //{
        //    if (!MyFrame.Content.GetType().Equals("ListaPokemon"))
        //    {
        //        BackButton.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        BackButton.Visibility = Visibility.Collapsed;
        //    }
        //}

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                //Visibility_Back_Click();
                MyFrame.GoBack();
            }
            else
            {
                //Visibility_Back_Click();
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
            //Visibility_Back_Click();
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
            Frame.Navigate(typeof(MainPage));
            //BackButton.Visibility = Visibility.Collapsed;
        }

        private void Organizacao_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
