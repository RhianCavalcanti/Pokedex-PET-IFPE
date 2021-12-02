using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using Newtonsoft.Json;
using System.Data;


namespace POKEDEX_SiDi.Model
{
    public partial class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
