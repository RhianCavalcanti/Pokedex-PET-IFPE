using System;
using Newtonsoft.Json;

namespace POKEDEX_SiDi.Model
{
    public partial class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }
    }
}

