using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEDEX_SiDi.Model
{
    class TypePokemon
    {
        [JsonProperty("pokemon")]
        public List<Generation> TypesPokemon { get; set; }
    }
}
