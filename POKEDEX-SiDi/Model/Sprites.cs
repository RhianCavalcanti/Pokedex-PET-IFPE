using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
using Newtonsoft.Json;


namespace POKEDEX_SiDi.Model
{
    public partial class Sprites
    {
        //[JsonProperty("back_default")]
        //public Uri BackDefault { get; set; }

        //[JsonProperty("back_female")]
        //public Uri BackFemale { get; set; }

        //[JsonProperty("back_shiny")]
        //public Uri BackShiny { get; set; }

        //[JsonProperty("back_shiny_female")]
        //public Uri BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        //[JsonProperty("front_female")]
        //public Uri FrontFemale { get; set; }

        //[JsonProperty("front_shiny")]
        //public Uri FrontShiny { get; set; }

        //[JsonProperty("front_shiny_female")]
        //public Uri FrontShinyFemale { get; set; }
    }
}
