using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PokemonGuesser;

namespace PokemonGuesser
{
    public partial class frmGuess: Form
    {
        /// <summary>
        /// The randomly selected Pokemon
        /// </summary>
        clsPokemonDetails PokemonDetails;

        /// <summary>
        /// The base amount of points that the player starts with
        /// </summary>
        int points = 1000;

        public frmGuess()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On load of the form, grab a random pokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAnalytics_Load(object sender, EventArgs e)
        {
            getRandomPokemon();
        }

        /// <summary>
        /// This function actually handles the grabbing of the random pokemon. This function also handles adding the pokemon to cmbPokemon
        /// </summary>
        private void getRandomPokemon()
        {
            try
            {
                //Creates a data class and sets the SQL statement
                clsData data = new clsData();
                data.SQL = "SELECT * FROM Pokemon";

                //checks to make sure the class returned something
                if (data.dt.Rows.Count == 0) return;

                //Foreach of the rows in the data, grab the name and add it to cmbPokemon
                foreach (DataRow rows in data.dt.Rows)
                {
                    string name = rows["Name"].ToString();
                    name = char.ToUpper(name[0]) + name.Substring(1);
                    cmbPokemon.Items.Add(name);
                }

                //Grab a random number baed on the rows and selects that randomly selected row
                Random rand = new Random();
                int randomIndex = rand.Next(data.dt.Rows.Count);
                DataRow row = data.dt.Rows[randomIndex];

                //Take apart the row and add it to the Pokemon class which formats the data.
                PokemonDetails = new clsPokemonDetails(
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Pokémon: " + ex.Message);
            }
        }


        /// <summary>
        /// This function is used by every hint on the page. Whenever something is double clicked, this fires. It subtracts the points from the score and shows the hint.
        /// </summary>
        /// <param name="sender">The object that was clicked</param>
        /// <param name="e"></param>
        private void hintClicked(object sender, EventArgs e)
        {
            // Makes sure the sender is valid with a valid tag (the tag is used to subtract points and IDing the sender
            if (sender is Control control && control.Tag != null)
            {
                // Spelts the tag into the price and ID of sender
                string[] parts = control.Tag.ToString().Split('|');
                if (parts.Length != 2) return;

                if (int.TryParse(parts[0], out int cost))
                {
                    // Subtracts cost from points
                    points -= cost;

                    // Make sure the user did not go under 0.
                    if (points <= 0)
                    {
                        points = 0;
                        lblPoints.Text = $"{points}";
                        gameOver();
                        return;
                    }

                    //Updates the label for points
                    lblPoints.Text = $"{points}";

                    //Now grabs the second part of the tag, which IDs the sender
                    string propertyName = parts[1];
                    //Grabs the property based on the name
                    var prop = PokemonDetails.GetType().GetProperty(propertyName);

                    //Makes sure a prop was grabbed
                    if (prop != null)
                    {
                        //Grabs the value
                        string value = prop.GetValue(PokemonDetails).ToString();

                        //This if needs to be done since not all of the senders are labels
                        if (propertyName == "Info")
                        {
                            //Replaces all instances of the pokemon's name with ??? in the information and adds it to the text
                            rtxtInfo.Text = Regex.Replace(value, Regex.Escape(PokemonDetails.Name), "???", RegexOptions.IgnoreCase);
                            //Removes the doubleclick event
                            rtxtInfo.DoubleClick -= hintClicked;
                            rtxtInfo.Cursor = Cursors.Default;
                        }
                        else if (propertyName == "ImageURL")
                        {
                            //Loads the picture and removes the event
                            picBoxPokemon.Load(value);
                            picBoxPokemon.DoubleClick -= hintClicked;
                            picBoxPokemon.Cursor = Cursors.Default;
                        }
                        else if (propertyName == "Type")
                        {
                            //Loads the typings and removes event
                            lblTyping.Text = PokemonDetails.Type.Length == 2 ? $"{PokemonDetails.Type[0]} / {PokemonDetails.Type[1]}" : PokemonDetails.Type[0];
                            lblTyping.DoubleClick -= hintClicked;
                            lblTyping.Cursor = Cursors.Default;
                        }
                        else
                        {
                            //Adds text and removes the event
                            Label label = sender as Label;
                            label.Text = value;
                            label.DoubleClick -= hintClicked;
                            label.Cursor = Cursors.Default;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The help button just gives the rules to the player. When clicked, it pops up a MessageBox with the rules.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            string directions = "Welcome to the Pokémon Guessing Game!\n\n" +
                                "You start with 1000 points.\n" +
                                "Each guess costs 100 points.\n" +
                                "You can buy more information by clicking on the prices next to the labels.\n\n" +
                                "Try to guess the Pokémon with the fewest clues to maximize your score!";

            MessageBox.Show(directions, "How to Play", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// This function is called whenever a player wins or loses. If win, display win message. If lost, display the lost message.
        /// </summary>
        /// <param name="win">Defaults to false</param>
        private void gameOver(bool win = false)
        {
            setAllValues();
            if (win)
            {

                string winMessage = "You have Won! \n\n" +
                                    $"You scored {points} Points!";

                MessageBox.Show(winMessage, "VICTORY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                string loseMessage = "You have Lost! \n\n" +
                    $"The correct answer was {PokemonDetails.Name}";

                MessageBox.Show(loseMessage, "DEFEAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Used whenever gameover is called. Sets all values and removes all events.
        /// </summary>
        private void setAllValues()
        {
            lblName.Text = PokemonDetails.Name;
            lblTyping.Text = PokemonDetails.Type.Length == 2 ? $"{PokemonDetails.Type[0]} / {PokemonDetails.Type[1]}" : PokemonDetails.Type[0];
            lblHP.Text = PokemonDetails.HP;
            lblAttack.Text = PokemonDetails.Attack;
            lblDefense.Text = PokemonDetails.Defense;
            lblSpAttack.Text = PokemonDetails.SpecialAttack;
            lblSpDefense.Text = PokemonDetails.SpecialDefense;
            lblSpeed.Text = PokemonDetails.Speed;
            lblEvoSet.Text = PokemonDetails.EvoSet;
            lblHeight.Text = PokemonDetails.Height;
            lblWeight.Text = PokemonDetails.Weight;
            rtxtInfo.Text = PokemonDetails.Info;

            picBoxPokemon.Load(PokemonDetails.ImageURL);

            btnGuess.Enabled = false;
            cmbPokemon.Enabled = false;

            //Remove Function
            lblName.DoubleClick -= hintClicked;
            lblTyping.DoubleClick -= hintClicked;
            lblHP.DoubleClick -= hintClicked;
            lblAttack.DoubleClick -= hintClicked;
            lblDefense.DoubleClick -= hintClicked;
            lblSpAttack.DoubleClick -= hintClicked;
            lblSpDefense.DoubleClick -= hintClicked;
            lblSpeed.DoubleClick -= hintClicked;
            lblEvoSet.DoubleClick -= hintClicked;
            lblHeight.DoubleClick -= hintClicked;
            lblWeight.DoubleClick -= hintClicked;
            rtxtInfo.DoubleClick -= hintClicked;
            picBoxPokemon.DoubleClick -= hintClicked;
        }

        /// <summary>
        /// When the guess button is clicked, checks to see if the player got it right.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuess_Click(object sender, EventArgs e)
        {
            // Checks to see if the play won the game
            if (PokemonDetails.Name == cmbPokemon.Text) 
            {
                gameOver(true);
                return;
            }

            // Checks to see if an answer was selected
            if (cmbPokemon.Text == "")
            {
                return;
            }

            // removes points and removes the answer from the pool
            points -= 100;
            lblPoints.Text = points.ToString();
            cmbPokemon.Items.Remove(cmbPokemon.Text);

            // Checks if the player lost
            if (points <= 0)
            {
                points = 0;
                lblPoints.Text = $"{points}";
                gameOver();
                return;
            }
        }
    }
}
