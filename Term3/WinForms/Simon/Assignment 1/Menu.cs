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
    public partial class menu : Form
    {
        //To later assign our passed main form
        private MainForm game;

        //To access functions from our main form we pass our main form as an argument
        public menu(Form gameForm)
        {
            game = gameForm as MainForm;
            InitializeComponent();
            FormClosing += menuClosing; //To ensure user can't close the menu with X
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }

        //Start or resume the game
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //If there isn't a game currently in play, begin new game
            if (btnPlay.Text != "Resume")
            {
                game.startGame();
                btnPlay.Text = "Resume";
            }
            //If there is a game currently in play, resume
            else
            {
                game.resumeGame();
            }
        }

        //Reset the play button text
        public void reset()
        {
            btnPlay.Text = "New Game";
        }

        //Show the current scoreboard
        private void btnScores_Click(object sender, EventArgs e)
        {
            game.showScores();
        }

        //Show the rules of the game when "Rules" are clicked
        private void btnRules_Click(object sender, EventArgs e)
        {
            game.showRules();
        }

        //Exit the application when user clicks "Quit"
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Prevent user from closing the menu
        private void menuClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
