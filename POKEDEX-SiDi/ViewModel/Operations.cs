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
        public static List<PokemonDb> ListPokemon = new List<PokemonDb>();

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
            ListPokemon.Clear();
            for (int i = 0; i < 10; i++)
            {
                PokemonDb pokeList = new PokemonDb();
                pokeList.Id = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[1];
                pokeList.Name = (string)DbClass.GetPokemon(I).Rows[i].ItemArray[2];
                pokeList.Types = (string)DbClass.GetPokemon(I).Rows[i].ItemArray[3];
                //pokeList.Hp = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[4];
                //pokeList.Attack = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[5];
                //pokeList.Defense = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[6];
                //pokeList.SpecialAttack = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[7];
                //pokeList.SpecialDefense = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[8];
                //pokeList.Speed = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[9];              
                pokeList.Height = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[10];
                pokeList.Weight = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[11];
                pokeList.Image = (string)DbClass.GetPokemon(I).Rows[i].ItemArray[12];
                ListPokemon.Add(pokeList);
            }
        }
    }
}
 