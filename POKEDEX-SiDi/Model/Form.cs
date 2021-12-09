using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data.SQLite;
using System.Data;


namespace POKEDEX_SiDi.Model
{
    public partial class Form
    {
        [JsonProperty("base_experience")]
        public long BaseExperience { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }

        [JsonProperty("stats")]
        public List<Stat> Stats { get; set; }

        [JsonProperty("types")]
        public List<TypeElement> Types { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }
}
