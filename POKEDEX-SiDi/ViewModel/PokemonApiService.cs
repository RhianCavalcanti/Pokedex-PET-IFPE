using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;
using POKEDEX_SiDi.Model;

namespace POKEDEX_SiDi.ViewModel
{
    public interface PokemonApiService
    {
        [Get("/pokemon/{name}")]
        Task<Form> GetPokemonAsync(string name);
    }
}
