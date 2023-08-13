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
    public partial class FinalScore : Form
    {
        //To later assign our passed main form
        private MainForm game;

        //To access functions from our main form we pass our main form as an argument
        public FinalScore(Form gameForm)
        {
            game = gameForm as MainForm;
            InitializeComponent();
            FormClosing += scoreClosing; //To ensure user can't close the menu with X
        }

        //Change our text to match the users end score
        public void changeFinalScore(string score)
        {
            lblFinalScore.Text = "GAME OVER\n\nFinal Score:\n" + score;
        }

        //Close the final score screen upon clicking ok
        private void btnFinalScoreOK_Click(object sender, EventArgs e)
        {
            game.closeFinalScore();
        }

        //Prevent user from closing the Final Score screen
        private void scoreClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
