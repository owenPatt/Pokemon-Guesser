using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using PokemonGuesser;

namespace PokemonGuesser
{
    public partial class frmPractice: Form
    {
        /// <summary>
        /// The currently selected Pokemon
        /// </summary>
        clsPokemonDetails Pokemon;

        public frmPractice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Grabs a list of the pokemon on load
        /// </summary>
        private void frmPractice_Load(object sender, EventArgs e)
        {
            getPokemonList();
        }

        /// <summary>
        /// Actually handles how the pokemon are loaded. It loads them into the cmbPokemon object.
        /// </summary>
        private void getPokemonList()
        {
            try
            {
                //Create a new data with the SQL statement
                clsData data = new clsData();
                data.SQL = "SELECT Name FROM Pokemon";

                //Adds all of the names to the cmbPokemon Object
                foreach (DataRow row in data.dt.Rows)
                {
                    string name = row["Name"].ToString();
                    name = char.ToUpper(name[0]) + name.Substring(1);
                    cmbPokemon.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pokémon: " + ex.Message);
            }
        }

        /// <summary>
        /// Grabs a random pokemon from the combobox when the random button is clicked
        /// </summary>
        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (cmbPokemon.Items.Count == 0) return;

            Random rnd = new Random();
            int index = rnd.Next(0, cmbPokemon.Items.Count);
            cmbPokemon.SelectedIndex = index;
        }

        /// <summary>
        /// Runs when the selected index of the combobox is changed. Sets all of the information on the screen to the selected pokemon's values
        /// </summary>
        private void cmbPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //grabs the name of the pokemon
            string selectedName = cmbPokemon.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedName)) return;

            try
            {
                //Create a new data and grabs the row with the pokemon's name
                clsData data = new clsData();
                data.SQL = $"SELECT * FROM Pokemon WHERE Name = '{selectedName.Replace("'", "''")}'";

                if (data.dt.Rows.Count > 0)
                {
                    //Grabs the row and create a new pokemon with the information which is done for formatting reasons
                    DataRow row = data.dt.Rows[0];
                    Pokemon = new clsPokemonDetails(
                        row["Name"].ToString(),
                        row["Height"].ToString(),
                        row["Weight"].ToString(),
                        row["HP"].ToString(),
                        row["Atk"].ToString(),
                        row["Def"].ToString(),
                        row["SPAtk"].ToString(),
                        row["SPDef"].ToString(),
                        row["Speed"].ToString(),
                        row["Typing"].ToString(),
                        row["Evo Set"].ToString(),
                        row["Info"].ToString()
                    );

                    //Sets all of the labels to the pokemon's stats
                    lblName.Text = Pokemon.Name;
                    lblTyping.Text = Pokemon.Type.Length == 2 ? $"{Pokemon.Type[0]} / {Pokemon.Type[1]}" : Pokemon.Type[0];
                    lblHP.Text = Pokemon.HP;
                    lblAttack.Text = Pokemon.Attack;
                    lblDefense.Text = Pokemon.Defense;
                    lblSpAttack.Text = Pokemon.SpecialAttack;
                    lblSpDefense.Text = Pokemon.SpecialDefense;
                    lblSpeed.Text = Pokemon.Speed;
                    lblEvoSet.Text = Pokemon.EvoSet;
                    lblHeight.Text = Pokemon.Height;
                    lblWeight.Text = Pokemon.Weight;
                    rtxtInfo.Text = Pokemon.Info;
                    
                    //Grabs the Image URL and loads it
                    string imageUrl = Pokemon.ImageURL;
                    picBoxPokemon.Load(imageUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Pokémon details: " + ex.Message);
            }
        }

        /// <summary>
        /// Allows you to pop then pokemon report to a new page, which can be printed for review.
        /// </summary>
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            //Makes sure you have something selected
            if (cmbPokemon.SelectedIndex == 0 || Pokemon == null)
                return;

            //Displays the report
            frmReport PokemonReport = new frmReport(Pokemon);
            PokemonReport.ShowDialog();
        }
    }
}
