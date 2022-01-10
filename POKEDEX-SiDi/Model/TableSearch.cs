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
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace POKEDEX_SiDi.Model
{
    class TableSearch
    {

        public static void ShowData(string pokemon)
        {
            var json = GetJSON(pokemon);
            var data = JsonConvert.DeserializeObject<Form>(json);

            Console.WriteLine(data.Id + " " + data.Name + " " + data.Stats[0].Effort + " " + data.Stats[0].BaseStat + " " + data.Stats[0].StatStat.Name + " " + data.Sprites.FrontDefault.AbsoluteUri);
        }

        public static string GetJSON(string pokemon)
        {
            var request = WebRequest.Create("https://pokeapi.co/api/v2/pokemon/" + pokemon);
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream);
                    var json = reader.ReadToEnd();
                    return json;
                }
            }
            return null;
        }



        public static void ShowDataPages(string pokemon)
        {
            var json = GetJSONPages(pokemon);
            var data = JsonConvert.DeserializeObject<Pages>(json);

            for (int i = 0; i < 10; i++)
            {
                var poke = JsonConvert.DeserializeObject<Form>(GetJSON(data.Results[i].Name));
                Console.WriteLine(data.Results[i].Name);

                if (DbClass.consulta(data.Results[i].Name).Rows.Count == 0)
                {
                    PokemonDb pokemonDb = NewMethod(poke);

                    DbClass.Add(pokemonDb);

                }

                


            }
        }
        static List<string> ListTypes = new List<string>();

        private static PokemonDb NewMethod(Form poke)
        {
            ListTypes.Clear();
            PokemonDb pokemonDb = new PokemonDb();
            pokemonDb.Id = poke.Id;
            pokemonDb.Name = poke.Name;
            string Type = "";
            if (poke.Types.Count == 1)
            {
                Type = poke.Types[0].Type.Name;
            }
            else
            {
                for (int i = 0; i < poke.Types.Count; i++)
                {
                    ListTypes.Add(poke.Types[i].Type.Name);
                }
                Type = String.Join(", ", ListTypes.ToArray());
            }
            pokemonDb.Types = Type;
            pokemonDb.Hp = poke.Stats[0].BaseStat;
            pokemonDb.Attack = poke.Stats[1].BaseStat;
            pokemonDb.Defense = poke.Stats[2].BaseStat;
            pokemonDb.SpecialAttack = poke.Stats[3].BaseStat;
            pokemonDb.SpecialDefense = poke.Stats[4].BaseStat;
            pokemonDb.Speed = poke.Stats[5].BaseStat;
            pokemonDb.Height = poke.Height;
            pokemonDb.Weight = poke.Weight;
            pokemonDb.Image = poke.Sprites.FrontDefault.AbsoluteUri;
            return pokemonDb;
        }

        public static string GetJSONPages(string quantidade)
        {
            var request = WebRequest.Create("https://pokeapi.co/api/v2/pokemon?limit=10&offset=" + quantidade);
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream);
                    var json = reader.ReadToEnd();
                    return json;
                }
            }
            return null;
        }

    }
}
