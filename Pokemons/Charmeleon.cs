using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.Pokemons
{
    internal class Charmeleon : Pokemon
    {
        public Charmeleon()
        {
            this.name = "Charmeleon";
            Random random = new Random();
            this.HP = random.Next(200, 425);
            this._image = Properties.Resources.Pokemon02;
            this.Attack = random.Next(255, 410);
            this.Defense = random.Next(188, 420);
        }
    }
}
