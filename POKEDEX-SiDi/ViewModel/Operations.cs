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

        

        public static void PaginacaoPositiva()
        {
            I += 10;
            TableSearch.ShowDataPages(I.ToString());
            DbClass.GetPokemon(I);
           // ListaDePokemon();
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
            DbClass.GetPokemon(I);
            //ListaDePokemon();
        }

        public static List<PokemonDb> ListaDePokemon()
        {
            List<PokemonDb> ListPokemon = new List<PokemonDb>();
            ListPokemon.Clear();
            for (int i = 0; i < 10; i++)
            {
                PokemonDb pokeList = new PokemonDb();
                pokeList.Id = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[0];
                pokeList.Name = (string)DbClass.GetPokemon(I).Rows[i].ItemArray[1];
                pokeList.Types = (string)DbClass.GetPokemon(I).Rows[i].ItemArray[2];
                pokeList.Hp = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[3];
                pokeList.Attack = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[4];
                pokeList.Defense = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[5];
                pokeList.SpecialAttack = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[6];
                pokeList.SpecialDefense = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[7];
                pokeList.Speed = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[8];
                pokeList.Height = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[9];
                pokeList.Weight = (long)DbClass.GetPokemon(I).Rows[i].ItemArray[10];
                pokeList.Image = (string)DbClass.GetPokemon(I).Rows[i].ItemArray[11];
                ListPokemon.Add(pokeList);
                
            }
            return ListPokemon;
        }

        public static PokemonDb PokemonUnidade(string pokemon)
        {
            PokemonDb pokemonUnidade = new PokemonDb();
            if (DbClass.consultaId(pokemon).Rows.Count != 0 && DbClass.consulta(pokemon).Rows.Count == 0)
            { 
                pokemonUnidade.Id = (long)DbClass.consultaId(pokemon).Rows[0].ItemArray[0];
                pokemonUnidade.Name = (string)DbClass.consultaId(pokemon).Rows[0].ItemArray[1];
                pokemonUnidade.Types = (string)DbClass.consultaId(pokemon).Rows[0].ItemArray[2];
                pokemonUnidade.Hp = (long)DbClass.consultaId(pokemon).Rows[0].ItemArray[3];
                pokemonUnidade.Attack = (long)DbClass.consultaId(pokemon).Rows[0].ItemArray[4];
                pokemonUnidade.Defense = (long)DbClass.consultaId(pokemon).Rows[0].ItemArray[5];
                pokemonUnidade.SpecialAttack = (long)DbClass.consultaId(pokemon).Rows[0].ItemArray[6];
                pokemonUnidade.SpecialDefense = (long)DbClass.consultaId(pokemon).Rows[0].ItemArray[7];
                pokemonUnidade.Speed = (long)DbClass.consultaId(pokemon).Rows[0].ItemArray[8];
                pokemonUnidade.Height = (long)DbClass.consultaId(pokemon).Rows[0].ItemArray[9];
                pokemonUnidade.Weight = (long)DbClass.consultaId(pokemon).Rows[0].ItemArray[10];
                pokemonUnidade.Image = (string)DbClass.consultaId(pokemon).Rows[0].ItemArray[11];
            }
            else if(DbClass.consultaId(pokemon).Rows.Count == 0 && DbClass.consulta(pokemon).Rows.Count != 0)
            {
                pokemonUnidade.Id = (long)DbClass.consulta(pokemon).Rows[0].ItemArray[0];
                pokemonUnidade.Name = (string)DbClass.consulta(pokemon).Rows[0].ItemArray[1];
                pokemonUnidade.Types = (string)DbClass.consulta(pokemon).Rows[0].ItemArray[2];
                pokemonUnidade.Hp = (long)DbClass.consulta(pokemon).Rows[0].ItemArray[3];
                pokemonUnidade.Attack = (long)DbClass.consulta(pokemon).Rows[0].ItemArray[4];
                pokemonUnidade.Defense = (long)DbClass.consulta(pokemon).Rows[0].ItemArray[5];
                pokemonUnidade.SpecialAttack = (long)DbClass.consulta(pokemon).Rows[0].ItemArray[6];
                pokemonUnidade.SpecialDefense = (long)DbClass.consulta(pokemon).Rows[0].ItemArray[7];
                pokemonUnidade.Speed = (long)DbClass.consulta(pokemon).Rows[0].ItemArray[8];
                pokemonUnidade.Height = (long)DbClass.consulta(pokemon).Rows[0].ItemArray[9];
                pokemonUnidade.Weight = (long)DbClass.consulta(pokemon).Rows[0].ItemArray[10];
                pokemonUnidade.Image = (string)DbClass.consulta(pokemon).Rows[0].ItemArray[11];
            }
            else if(DbClass.consultaId(pokemon).Rows.Count == 0 && DbClass.consulta(pokemon).Rows.Count == 0)
            {
                pokemonUnidade.Id = 0;
                pokemonUnidade.Name = "Pokemon não encontrado";
                pokemonUnidade.Types = "---";
                pokemonUnidade.Hp = 0;
                pokemonUnidade.Attack = 0;
                pokemonUnidade.Defense = 0;
                pokemonUnidade.SpecialAttack =  0;
                pokemonUnidade.SpecialDefense = 0;
                pokemonUnidade.Speed = 0;
                pokemonUnidade.Height = 0;
                pokemonUnidade.Weight = 0;
                pokemonUnidade.Image = (string) "https://img2.gratispng.com/20180219/hbq/kisspng-error-message-clip-art-precaution-cliparts-5a8b1cb062e216.398494751519066288405.jpg";

            }

            return pokemonUnidade;

        }

    }
}
 