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
    public partial class HighScores : Form
    {
        //To later assign our passed main form
        private MainForm game;

        //To access functions from our main form we pass our main form as an argument
        public HighScores(Form gameForm)
        {
            game = gameForm as MainForm;
            InitializeComponent();
            FormClosing += highScoresClosing; //To ensure user can't close the menu with X
        }

        private void HighScores_Load(object sender, EventArgs e)
        {

        }

        //Close the high scores form
        private void btnHighScoresOK_Click(object sender, EventArgs e)
        {
            game.closeHighScores();
        }

        //Update the high scores
        public void updateHighScores(string highScores)
        {
            lblHighScores.Text = highScores;
        }

        //Prevent user from closing the Final Score screen
        private void highScoresClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
