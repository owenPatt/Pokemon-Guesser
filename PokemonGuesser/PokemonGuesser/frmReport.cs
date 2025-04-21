using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonGuesser;

namespace PokemonGuesser
{
    public partial class frmReport: Form
    {
        /// <summary>
        /// Initializes the program with the pokemon loading on screen
        /// </summary>
        /// <param name="Pokemon">Pokemon to display on the screen</param>
        public frmReport(clsPokemonDetails Pokemon)
        {
            InitializeComponent();
            PokemonReport(Pokemon);
        }           

        /// <summary>
        /// Uses the pokemon given to display the pokemon's stats onto the webscreen
        /// </summary>
        /// <param name="Pokemon">Pokemon to display on the screen</param>
        public void PokemonReport(clsPokemonDetails Pokemon)
        {
            if (Pokemon == null)
                return;

            string strReportHeader;
            string strReportBody = "";

            strReportHeader = "<HTML><HEAD><TITLE>Pokémon Report</TITLE></HEAD>";

            strReportBody += "<BODY>";
            strReportBody += "<H1>Pokémon Report</H1>";
            strReportBody += "<hr/>";

            //Add Pokemon Image
            strReportBody += $"<img src='{Pokemon.ImageURL}' alt='{Pokemon.Name}' height='200'><br/><br/>";

            //Adds name
            strReportBody += $"<h2>{Pokemon.Name}</h2>";
            strReportBody += "<br/>";

            //Adds stats
            strReportBody += $"<strong>Height:</strong> {Pokemon.Height}<br/>";
            strReportBody += $"<strong>Weight:</strong> {Pokemon.Weight}<br/>";
            strReportBody += $"<strong>HP:</strong> {Pokemon.HP}<br/>";
            strReportBody += $"<strong>Attack:</strong> {Pokemon.Attack}<br/>";
            strReportBody += $"<strong>Defense:</strong> {Pokemon.Defense}<br/>";
            strReportBody += $"<strong>Special Attack:</strong> {Pokemon.SpecialAttack}<br/>";
            strReportBody += $"<strong>Special Defense:</strong> {Pokemon.SpecialDefense}<br/>";
            strReportBody += $"<strong>Speed:</strong> {Pokemon.Speed}<br/>";

            //Adds Typing
            if (Pokemon.Type.Length == 2)
                strReportBody += $"<strong>Typing:</strong> {Pokemon.Type[0]} / {Pokemon.Type[1]}<br/>";
            else
                strReportBody += $"<strong>Typing:</strong> {Pokemon.Type[0]}<br/>";

            //Adds Evo Set
            strReportBody += $"<strong>Evo Set:</strong> {Pokemon.EvoSet}<br/>";

            //Adds Info
            strReportBody += $"<p><strong>Info:</strong> {Pokemon.Info}</p>";

            strReportBody += "</BODY></HTML>";

            //Display in wbReport
            wbReport.DocumentText = strReportHeader + strReportBody;
        }
    }
}
