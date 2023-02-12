using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.Pokemons
{
    internal class Pichu : Pokemon
    {
        public Pichu()
        {
            this.name = "Pichu";
            Random random = new Random();
            this.HP = random.Next(175, 325);
            this._image = Properties.Resources.Pichu;
            this.Attack = random.Next(133, 410);
            this.Defense = random.Next(188, 355);
        }
    }
}
