using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class MainForm : Form
    {
        //List of our 4 colors and a list of the output colors generated over time
        List<GameColor> Colors = new List<GameColor>();
        List<GameColor> ColorsOutput = new List<GameColor>();

        //Adding sounds for all of the colors
        SoundPlayer greenSound = new SoundPlayer("../../Media/a4.wav");
        SoundPlayer blueSound = new SoundPlayer("../../Media/c4.wav");
        SoundPlayer redSound = new SoundPlayer("../../Media/e4.wav");
        SoundPlayer yellowSound = new SoundPlayer("../../Media/g4.wav");

        //To assign on startup for accessing the start menu, final score, high scores and new high score (separate forms)
        menu startMenu;
        FinalScore finalScore;
        HighScores highScores;
        NewHighScore newHighScore;

        //For random generation of colors added to the list
        Random random = new Random();

        //Timer for flashing of colors
        Timer myTimer = new Timer();

        //If the game is running
        bool running = false;

        //If game is showing output (To stop them from pressing other buttons)
        bool displayingSequence = false;

        //If rules are being displayed (To stop them from pressing other buttons)
        bool displayingRules = false;

        //Current position in the list of output
        int position = 0;

        //If there is a color that needs to be reset before continuing
        bool reset = false;

        //Current color that needs to be reset
        GameColor resetColor;

        //Location of high scores file
        string fileHighScores = "HighScores.txt";

        //If updating scores
        bool updatingScores = false;

        public MainForm()
        {
            InitializeComponent();

            //Adding colors to our list of four colors
            Colors.Add(new GameColor() { colorName = "Green"});
            Colors.Add(new GameColor() { colorName = "Blue"});
            Colors.Add(new GameColor() { colorName = "Red"});
            Colors.Add(new GameColor() { colorName = "Yellow"});

            //Set our timer to have a tick event every half a second (Color changing back to normal)
            myTimer.Interval = 500;
            myTimer.Tick += new EventHandler(myTimer_Tick);

            //Check for high scores file
            if (!File.Exists(fileHighScores))
            {
                //If the file doesn't exist, create it and fill it with placeholder values
                File.Create(fileHighScores).Close();
                StreamWriter sw = new StreamWriter(fileHighScores);
                sw.Write("AAA          0\n" +
                         "AAB          0\n" +
                         "AAC          0\n" +
                         "AAD          0\n" +
                         "AAE          0");
                sw.Close();
            }

            updateHighScore();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            //Accessing the start menu, final score, high scores and new high score (separate forms)
            startMenu = new menu(this);
            finalScore = new FinalScore(this);
            highScores = new HighScores(this);
            newHighScore = new NewHighScore(this);

            //Hide the rules to start
            lblRules.Hide();
            btnRulesClose.Hide();

            //Load start menu after form has been launched
            await Task.Delay(100);
            startMenu.ShowDialog();
        }
        //Based on the button clicked change the color to create a "light up" effect and add a sound
        private void btnColor_OnClick(object sender, EventArgs e)
        {
            //Check if the game is currently showing the sequence or the rules and if it is do not allow the user to give any input
            if (displayingSequence || displayingRules)
            {
                return;
            }

            //Get info about the button pressed
            Button color = (Button)sender;

            //Create a value to hold the input, set as null because we need a value for the compiler to allow function call later
            GameColor input = null;

            //If there is currently a color being displayed it will reset it before continuing
            if (reset) resetColors();

            //Check color name and assign input the matching GameColor from list of colors
            switch (color.Name)
            {
                case "btnGreen":
                    input = Colors[0];
                    break;
                case "btnBlue":
                    input = Colors[1];
                    break;
                case "btnRed":
                    input = Colors[2];
                    break;
                case "btnYellow":
                    input = Colors[3];
                    break;
            }

            //Call the color action for the appropriate input
            colorAction(input);

            //Set reset value to true so we know that if a button is pressed immediately after the prior one must be reset
            reset = true;

            //Check if the input is correct
            checkInput(input);
        }

        //Show the start menu on click and pause the game
        private void btnHelp_OnClick(object sender, EventArgs e)
        {
            //If the rules are up this button will do nothing
            if (displayingRules)
            {
                return;
            }

            //Stop the game from running while we are in the menu
            running = false;

            //Show the start menu and force it on top
            startMenu.ShowDialog();
        }

        //Starts the game, either by hitting "Start Game" or the X
        public void startGame()
        {
            //Leave the startMenu window and begin the game
            lblCurrentScore.Text = "Current Score: 0";
            displayingSequence = true;
            running = true;
            startMenu.Hide();
            addColor();
        }

        //Resume the game, either by hitting "Resume" or the X
        public void resumeGame()
        {
            //Leave the startMenu window and resume the game
            startMenu.Hide();
            running = true;
        }

        //Show the rules of the game
        public void showRules()
        {
            //Set this value to true so user cannot click other buttons
            displayingRules = true;

            running = false; //So the game doesn't begin upon menu close
            startMenu.Hide(); //Hide the start menu
            lblRules.Show(); //Show the rules
            btnRulesClose.Show(); //Show the rule button
        }

        //Close rules and go back to the menu
        private void btnRulesClose_Click(object sender, EventArgs e)
        {
            displayingRules = false; //Re-enable buttons
            btnRulesClose.Hide(); //Hide the button for closing rules
            lblRules.Hide(); //Hide the rules
            startMenu.ShowDialog(); //Show the menu
        }

        //Show the high scores
        public async void showScores()
        {
            //Read the high scores file
            StreamReader sr = new StreamReader(fileHighScores);
            string scores = sr.ReadToEnd();

            highScores.updateHighScores(scores); //Update the high scores screen according to what was read from the file
            startMenu.Hide(); //Hide the start menu
            await Task.Delay(1); //Wait 1ms so the screens don't get messed up
            highScores.ShowDialog(); //Show the high scores screen

            sr.Close(); //Close the reader

            updatingScores = false; //If we were brought to the scores by having gotten a new high score
        }

        //Close the high scores form
        public async void closeHighScores()
        {
            highScores.Hide(); //Hide high scores
            await Task.Delay(1); //Wait 1ms so the screens don't get messed up
            startMenu.ShowDialog(); //Show the start menu
        }

        //Close the final score form
        public async void closeFinalScore()
        {
            finalScore.Hide(); //Get rid of the final score screen
            await Task.Delay(1); //To stop the game screen from bugging out and not showing at the correct location
            gameOver(); //Go to game over
        }

        //Add a random color to the output list, then start showing the pattern
        private async void addColor()
        {
            //Set displayingSequence to true to disallow user input while the output is being displayed
            displayingSequence = true;

            //Wait one second before beginning, gives some breathing room after starting up the game and in between rounds
            await Task.Delay(1000);

            //Select a random color and add it to the list of output colors
            int nextColor = random.Next(Colors.Count);
            ColorsOutput.Add(Colors[nextColor]);

            //Show the pattern with updated values
            showPattern();
        }

        //Display the current color and play a sound, waiting between iterations
        private async void showPattern()
        {

            //Go through our list of output colors and display them to the user
            foreach (var color in ColorsOutput)
            {
                //While the game is paused stop anything from happening on the game screen
                while (!running) await Task.Delay(1000);

                //Call function to show color and play sound
                colorAction(color);

                //Wait before next loop iteration
                await Task.Delay(600);
            }

            //Set displayingSequence to false so the user may begin to enter their input
            displayingSequence = false;
        }

        //Check user input against current color in the list and change their score if they get them all correct
        private void checkInput(GameColor color)
        {
            //Check that the color matches the current value in the sequence
            if (color == ColorsOutput[position])
            {
                //If we are at the end of the sequence update the current score, reset our position in the list to the beginning and beginning the next sequence
                if (position + 1 == ColorsOutput.Count)
                {
                    lblCurrentScore.Text = "Current Score: " + (position + 1).ToString();
                    position = 0;
                    addColor();
                }
                //Otherwise increase our position in the sequence for the next input verification
                else
                {
                    position++;
                }
            }
            //If the input is incorrect, stop the game
            else
            {
                finalScore.changeFinalScore(lblCurrentScore.Text.Substring(15)); //Adjust the final score screen to users end score
                finalScore.ShowDialog(); //Show the final score screen
            }
        }

        //When the users input is incorrect end the game and open the game over menu
        private void gameOver()
        {
            //Read the high scores file
            StreamReader sr = new StreamReader(fileHighScores);

            //Check if we have already been updating the scores
            if (!updatingScores)
            {
                //Check if the current score beats any high scores
                for (int i = 0; i < 5; i++)
                {
                    //Check the high score at the current line
                    int score = int.Parse(sr.ReadLine().Substring(13));

                    //See if the current score beats this high score
                    if (score < int.Parse(lblCurrentScore.Text.Substring(15)))
                    {
                        sr.Close(); //Close the reader
                        newHighScore.ShowDialog(); //Open the new highscore
                        updatingScores = true; //Let game over know we are already updating a score
                        return; //End the function if we are updating a high score
                    }
                }
            }

            //Close the reader
            sr.Close();

            running = false; //Stop the game from running
            ColorsOutput.Clear(); //Clear the sequence of colors
            position = 0; //Reset position to 0
            startMenu.reset(); //Reset the start menu to show "New Game"
            if (updatingScores) showScores(); //If we updated our scores show the scores
            else startMenu.ShowDialog(); //Have the start menu appear
        }

        //Edit high scores
        public async void editScores(string initials)
        {
            //Read from the file
            StreamReader sr = new StreamReader(fileHighScores);

            //Find the index of our beaten score
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                int score = int.Parse(sr.ReadLine().Substring(13));
                if (score < int.Parse(lblCurrentScore.Text.Substring(15)))
                {
                    index = i;
                    break;
                }
            }

            //Close the reader
            sr.Close();

            //Open a new reader
            sr = new StreamReader(fileHighScores);

            //Save all lines read into an array of strings
            string[] lines = new string[5];
            for (int i = 0; i < 5; i++)
            {
                lines[i] = sr.ReadLine();
            }

            //Close the reader
            sr.Close();

            //Open a stream writer
            StreamWriter sw = new StreamWriter(fileHighScores);

            //Write to the high scores file
            int j = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i == index) //Put in the new score into the indexed position
                {
                    sw.WriteLine(initials + "          " + lblCurrentScore.Text.Substring(15));
                }
                else //Write the old lines in order
                {
                    sw.WriteLine(lines[j]);
                    j++;
                }
            }

            //Close the writer
            sw.Close();

            //Update the high score in case of new highest score
            updateHighScore();

            newHighScore.Hide(); //Hide the new high score form
            await Task.Delay(1); //Wait 1 ms to avoid form positions messing up
            gameOver(); //Restart game over
        }

        //To update the highest score
        private void updateHighScore()
        {
            //Read the file and update the high score
            StreamReader sr = new StreamReader(fileHighScores);
            lblHighScore.Text = "High Score: " + sr.ReadLine().Substring(13);
            sr.Close();
        }

        //Display the color, play sound and call timer to reset color
        private void colorAction(GameColor color)
        {
            //Check which color we are creating action for and change color and create sound accordingly
            switch (color.colorName)
            {
                case "Green":
                    btnGreen.BackColor = Color.Lime;
                    greenSound.Play();
                    break;
                case "Blue":
                    btnBlue.BackColor = Color.Cyan;
                    blueSound.Play();
                    break;
                case "Red":
                    btnRed.BackColor = Color.Red;
                    redSound.Play();
                    break;
                case "Yellow":
                    btnYellow.BackColor = Color.Yellow;
                    yellowSound.Play();
                    break;
            }

            //Set the color that needs to be reset
            resetColor = color;

            //Start the timer to clear the color
            myTimer.Start();
        }

        //Reset colors to default or "dull" status
        private void resetColors()
        {
            //Check the color that needs to be reset based on name
            switch (resetColor.colorName)
            {
                case "Green":
                    btnGreen.BackColor = Color.Green;
                    break;
                case "Blue":
                    btnBlue.BackColor = Color.Teal;
                    break;
                case "Red":
                    btnRed.BackColor = Color.Maroon;
                    break;
                case "Yellow":
                    btnYellow.BackColor = Color.FromArgb(192, 192, 0);
                    break;
            }

            //Set reset value to false now that we have reset the color
            reset = false;
        }
        
        //For when our timer ticks, we revert the colors back to their original state and stop the timer
        private void myTimer_Tick(object sender, EventArgs e)
        {
            resetColors();
            myTimer.Stop();
        }

    }
}
