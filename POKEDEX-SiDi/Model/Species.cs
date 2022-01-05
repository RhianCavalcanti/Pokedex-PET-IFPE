using System;
using Newtonsoft.Json;

namespace POKEDEX_SiDi.Model
{
    public partial class Species
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

    }
}

