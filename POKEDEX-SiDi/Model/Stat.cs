using Newtonsoft.Json;

namespace POKEDEX_SiDi.Model
{
    public partial class Stat
    {
        [JsonProperty("base_stat")]
        public long BaseStat { get; set; }

        [JsonProperty("effort")]
        public long Effort { get; set; }

        [JsonProperty("stat")]
        public Species StatStat { get; set; }
    }
}

