using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEDEX_SiDi.Model
{
    class PokemonDb
    {
        

        public long Id { get; set; }
        public string Name { get; set; }
        public string Types { get; set; }
        public long Hp { get; set; }
        public long Attack { get; set; }
        public long Defense { get; set; }
        public long SpecialAttack { get; set; }
        public long SpecialDefense { get; set; }
        public long Speed { get; set; }
        public long Weight { get; set; }
        public long Height { get; set; }
        public string Image { get; set; }
    }
}
