using PokemonGo.Pokemons;

namespace PokemonGo
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            pokemons.Add(new Charmander());
            pokemons.Add(new Charmeleon());
            pokemons.Add(new Pichu());
            
            this.monster = new Charizard();
            this.pictureBox2.Image = this.monster.getImage();
            this.tbName2.Text = this.monster.getName();
            this.tbHp2.Text = this.monster.getHP().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHp.Text = selectedPokemon.getHP().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHp.Text = selectedPokemon.getHP().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int atk = Math.Abs(this.monster.getDefense() - this.selectedPokemon.getAttack());
            this.monster.takeDamage(atk);
            this.tbHp2.Text = monster.getHP().ToString();
            if (monster.getHP() <= 0)
            {
                MessageBox.Show("YOU WIN");
                Application.Exit();
            }
        }

        private void add3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHp.Text = selectedPokemon.getHP().ToString();
        }

        private void Hp1_Click(object sender, EventArgs e)
        {
            
        }

        private void Df1_Click(object sender, EventArgs e)
        {
            
        }
    }
}