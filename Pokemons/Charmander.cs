using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.Pokemons
{
    internal class Charmander : Pokemon
    {
        public Charmander()
        {
            this.name = "Charmander";
            Random random = new Random();
            this.HP = random.Next(200, 325);
            this._image = Properties.Resources.Pokemon01;
            this.Attack = random.Next(116, 410);
            this.Defense = random.Next(117, 320);
        }
    }
}
