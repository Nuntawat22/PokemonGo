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

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
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
                MessageBox.Show("You Win");
                Application.Exit();
            }
        }
        
        private void botton7_Click(object sender, EventArgs e)
        {
            this.tbHp.Text = this.selectedPokemon.getHealth().ToString();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.selectedPokemon.getDef();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tbHp2.Text = this.monster.getHealth().ToString();
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.monster.getDef();
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int atk = Math.Abs(this.selectedPokemon.getDefense() - this.monster.getAttack());
            this.selectedPokemon.takeDamage(atk);
            this.tbHp2.Text = monster.getHP().ToString();
            if (pokemons[0].getHP() <= 0)
            {
                button1.Enabled = false;
            }
            else if (pokemons[1].getHP() <= 0)
            {
                button2.Enabled = false;
            }
            else if (pokemons[2].getHP() <= 0)
            {
                button3.Enabled = false; 
            }
        }
    }
}