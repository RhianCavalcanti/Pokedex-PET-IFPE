using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEDEX_SiDi.Model
{
    class Generation
    {
        [JsonProperty("pokemon")]
        public Pokemon PokemonPokemon { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }
    }
}

