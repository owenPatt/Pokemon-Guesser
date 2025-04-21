using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGuesser
{
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Opens the practice form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPractice_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPractice PracticeForm = new frmPractice();
            PracticeForm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Opens the guess form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuess_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuess GuessForm = new frmGuess();
            GuessForm.ShowDialog();
            this.Show();
        }
    }
}
