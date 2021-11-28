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
        public static async void RegisterPokemon(string name)
        {
            await TableSearch.GetRequerimentPokemonInApi(name);

            DbClass.Add(TableSearch.id, TableSearch.name);

        }

        public static async void Verificate(string name)
        {
            if (DbClass.consulta(name).Rows.Count == 1)
            {


            }



        }
    }
}
