using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class NewHighScore : Form
    {
        //To later assign our passed main form
        private MainForm game;

        //To access functions from our main form we pass our main form as an argument
        public NewHighScore(Form gameForm)
        {
            game = gameForm as MainForm;
            InitializeComponent();
            FormClosing += newHighScoreClosing; //To ensure user can't close the menu with X
        }

        //When user clicks enter check that it is a string of 3 characters
        private void btnNewHighScoreEnter_Click(object sender, EventArgs e)
        {
            if (txtBoxNewHighScore.Text.Length != 3 || !txtBoxNewHighScore.Text.All(char.IsLetter))
            {
                MessageBox.Show("Must be 3 letters...");
            }
            //If requirements are met, begin editing scores and clear the user input box
            else
            {
                game.editScores(txtBoxNewHighScore.Text);
                txtBoxNewHighScore.Text = "";
            }
        }

        //Prevent user from closing the Final Score screen
        private void newHighScoreClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
