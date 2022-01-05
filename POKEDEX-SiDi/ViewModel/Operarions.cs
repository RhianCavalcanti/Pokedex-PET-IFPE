using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POKEDEX_SiDi.Model;

namespace POKEDEX_SiDi.ViewModel
{
    class Operations
    {
        static int I = -10;
        static int D = 0;
        public static List<PokemonDb> listPokemon = new List<PokemonDb>();

        public static void PaginacaoPositiva()
        {
            I += 10;
            TableSearch.ShowDataPages(I.ToString());
            DbClass.GetPokemon(I);
            ListaDePokemon();
        }

        public static void PaginacaoNegativa()
        {
            if (I < 10)
            {
                I = I;
            }
            else
            {
                I -= 10;
                TableSearch.ShowDataPages(I.ToString());
            }
            var listaPoke = DbClass.GetPokemon(I);
            ListaDePokemon();
        }

        public static void ListaDePokemon()
        {
            listPokemon.Clear();
            for (int i = 0; i < 10; i++)
            {
                PokemonDb pokeList = new PokemonDb();
                pokeList.Id = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[1];
                pokeList.Name = (string)DbClass.GetPokemon(I).Rows[i].ItemArray[2];
                pokeList.Height = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[4];
                pokeList.Types = (string)DbClass.GetPokemon(I).Rows[i].ItemArray[3];
                pokeList.Weight = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[5];
                pokeList.Image = (string)DbClass.GetPokemon(I).Rows[i].ItemArray[6];
                listPokemon.Add(pokeList);
                Console.WriteLine(listPokemon[i].Id
                    + " " + listPokemon[i].Name
                    + " " + listPokemon[i].Types
                    + " " + listPokemon[i].Weight
                    + " " + listPokemon[i].Height
                    + " " + listPokemon[i].Image
                    + " \n ");
            }
        }
    }
}
 