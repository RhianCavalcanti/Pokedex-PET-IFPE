using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
using POKEDEX_SiDi.ViewModel;
using Refit;



namespace POKEDEX_SiDi.Model
{
    class TableSearch
    {
        public static long id { get; set; }
        public static string name { get; set; }
        public static long H { get; set; }

        public static async Task GetRequerimentPokemonInApi(string namePokemon)
        {
            var dataPokemon = RestService.For<PokemonApiService>("https://pokeapi.co/api/v2");

            var poke = await dataPokemon.GetPokemonAsync(namePokemon);

            id = poke.Id;

            name = poke.Name;

            H = poke.Height;
        }
    }
}
