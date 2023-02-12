using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.Pokemons
{
    internal class Charizard : Pokemon
    {
        public Charizard()
        {
            this.name = "Charizard";
            Random random = new Random();
            this.HP = random.Next(355, 525);
            this._image = Properties.Resources.Pokemon03;
            this.Attack = random.Next(410, 650);
            this.Defense = random.Next(350, 550);
        }
    }
}

