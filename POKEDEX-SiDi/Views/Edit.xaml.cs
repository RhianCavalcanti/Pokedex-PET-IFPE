﻿using System;
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
    public sealed partial class Edit : Page
    {
        public Edit()
        {
            this.InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                //BackButton.IsEnabled = false;
                Frame.GoBack();
                //Lista.IsSelected = true;
            }
            //Frame.Navigate(typeof(PokemonDetalhado));
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //vai salvar os novos dados no BD
        }

        private void PreviousPokemonImg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextPokemonImg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
