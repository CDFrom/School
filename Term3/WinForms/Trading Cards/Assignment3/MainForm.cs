using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private string connectionString;
        private List<PlayerData> Players = new List<PlayerData>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Connect to database and populate the data
            connectionString = ConfigurationManager.ConnectionStrings["Assignment3.Properties.Settings.CardDatabaseConnectionString"].ConnectionString;
            populatePlayers();

            // Hiding initial fields
            lblAssistsValue.Text = "";
            lblBlocksValue.Text = "";
            lblFieldGoalPercentageValue.Text = "";
            lblFieldGoalsValue.Text = "";
            lblFreeThrowPercentageValue.Text = "";
            lblGamesPlayedValue.Text = "";
            lblGamesStartedValue.Text = "";
            lblHeightValue.Text = "";
            lblNumberValue.Text = "";
            lblPlayerNameValue.Text = "";
            lblPointsPerGameValue.Text = "";
            lblPointsValue.Text = "";
            lblPositionValue.Text = "";
            lblReboundsValue.Text = "";
            lblStealsValue.Text = "";
            lblTeamNameValue.Text = "";
            lblThreePointValue.Text = "";
            lblWeightValue.Text = "";

            // Set the combo box initial values and sort the data
            comboBoxSortBy.SelectedItem = comboBoxSortBy.Items[0];
            comboBoxOrderBy.SelectedItem = comboBoxOrderBy.Items[0];
            sortPlayers(comboBoxSortBy.SelectedItem.ToString(), comboBoxOrderBy.SelectedItem.ToString());

            // Select the first card and display the info
            listViewCards.Items[0].Selected = true;
            displayCard(Int32.Parse(listViewCards.Items[0].Text));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // When they click sort, sort the players based on the given parameters
            sortPlayers(comboBoxSortBy.SelectedItem.ToString(), comboBoxOrderBy.SelectedItem.ToString());
        }

        private void sortPlayers(string sortBy, string orderBy)
        {
            // Set the column to sort by based on given input
            int column = 0;
            if (sortBy == "Player Name")
            {
                column = 1;
            }
            else if (sortBy == "Team Name")
            {
                column = 2;
            }
            // Sort the cards with our comparer class using column and whether to do ascending or descending
            listViewCards.ListViewItemSorter = new ListViewItemComparer(column, orderBy);
        }

        // Fill our item list with the data from the database
        private void populatePlayers()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
                using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Players", connection))
            {
                DataTable table = new DataTable();
                connection.Open();
                adapter.Fill(table);
                connection.Close();

                table.DefaultView.Sort = "Number";
                table = table.DefaultView.ToTable();
                for (int row = 0; row < table.Rows.Count; row++)
                {
                    int number = (int)table.Rows[row]["number"];
                    string name = (string)table.Rows[row]["name"];
                    string team = (string)table.Rows[row]["team"];
                    string photo = (string)table.Rows[row]["photo"];
                    string height = (string)table.Rows[row]["height"];
                    string weight = (string)table.Rows[row]["weight"];
                    string position = (string)table.Rows[row]["position"];
                    int games = (int)table.Rows[row]["games"];
                    int gamesStarted = (int)table.Rows[row]["gamesStarted"];
                    int fieldGoals = (int)table.Rows[row]["fieldGoals"];
                    double fieldGoalPercent = (double)table.Rows[row]["fieldGoal%"];
                    double freeThrowPercent = (double)table.Rows[row]["freeThrow%"];
                    int threePoint = (int)table.Rows[row]["threePoint"];
                    double reboundsPerGame = (double)table.Rows[row]["reboundsPerGame"];
                    double assistsPerGame = (double)table.Rows[row]["assistsPerGame"];
                    int steals = (int)table.Rows[row]["steals"];
                    int blocks = (int)table.Rows[row]["blocks"];
                    int points = (int)table.Rows[row]["points"];
                    double pointsPerGame = (double)table.Rows[row]["pointsPerGame"];

                    PlayerData playerData = new PlayerData()
                    {
                        number = number,
                        name = name,
                        team = team,
                        photo = photo,
                        height = height,
                        weight = weight,
                        position = position,
                        games = games,
                        gamesStarted = gamesStarted,
                        fieldGoals = fieldGoals,
                        fieldGoalPercent = fieldGoalPercent,
                        freeThrowPercent = freeThrowPercent,
                        threePoint = threePoint,
                        reboundsPerGame = reboundsPerGame,
                        assistsPerGame = assistsPerGame,
                        steals = steals,
                        blocks = blocks,
                        points = points,
                        pointsPerGame = pointsPerGame
                    };

                    Players.Add(playerData);
                    ListViewItem item = new ListViewItem(number.ToString());
                    item.SubItems.Add(name);
                    item.SubItems.Add(team);

                    listViewCards.Items.Add(item);
                }
            }
        }

        // When clicked display the clicked cards data
        private void listViewCards_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listViewCards.Items.Count; i++)
            {
                if (listViewCards.Items[i].Selected == true)
                {
                    displayCard(Int32.Parse(listViewCards.Items[i].Text));
                    break;
                }
            }
        }

        // Set all fields to the correct info based on selected card
        private void displayCard(int number)
        {
            foreach (var player in Players)
            {
                if (player.number == number)
                {
                    // Set values to display based on selected player
                    lblAssistsValue.Text = player.assistsPerGame.ToString();
                    lblBlocksValue.Text = player.blocks.ToString();
                    lblFieldGoalPercentageValue.Text = player.fieldGoalPercent.ToString();
                    lblFieldGoalsValue.Text = player.fieldGoals.ToString();
                    lblFreeThrowPercentageValue.Text = player.freeThrowPercent.ToString();
                    lblGamesPlayedValue.Text = player.games.ToString();
                    lblGamesStartedValue.Text = player.gamesStarted.ToString();
                    lblHeightValue.Text = player.height;
                    lblNumberValue.Text = player.number.ToString();
                    lblPlayerNameValue.Text = player.name;
                    lblPointsPerGameValue.Text = player.pointsPerGame.ToString();
                    lblPointsValue.Text = player.points.ToString();
                    lblPositionValue.Text = player.position;
                    lblReboundsValue.Text = player.reboundsPerGame.ToString();
                    lblStealsValue.Text = player.steals.ToString();
                    lblTeamNameValue.Text = player.team;
                    lblThreePointValue.Text = player.threePoint.ToString();
                    lblWeightValue.Text = player.weight;

                    // Add/change the picture
                    pictureBoxPlayer.ImageLocation = "Media/" + player.photo;
                    pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;

                    // Set background color according to team
                    if (player.team == "Chicago Bulls")
                    {
                        pictureBoxPlayer.BackColor = Color.FromArgb(188,3,43);
                    }
                    else if (player.team == "Miami Heat")
                    {
                        pictureBoxPlayer.BackColor = Color.FromArgb(152, 0, 46);
                    }
                    else if (player.team == "Milwaukee Bucks")
                    {
                        pictureBoxPlayer.BackColor = Color.FromArgb(0, 70, 27);
                    }
                    else if (player.team == "Los Angeles Lakers")
                    {
                        pictureBoxPlayer.BackColor = Color.FromArgb(85, 37, 131);
                    }
                    else if (player.team == "New Orleans Pelicans")
                    {
                        pictureBoxPlayer.BackColor = Color.FromArgb(0, 42, 92);
                    }
                    else if (player.team == "San Antonio Spurs")
                    {
                        pictureBoxPlayer.BackColor = Color.FromArgb(0, 0, 0);
                    }
                    else if (player.team == "Philadelphia 76ers")
                    {
                        pictureBoxPlayer.BackColor = Color.FromArgb(0, 107, 182);
                    }
                    else if (player.team == "Golden State Warriors")
                    {
                        pictureBoxPlayer.BackColor = Color.FromArgb(255, 199, 44);
                    }
                    else if (player.team == "Toronto Raptors")
                    {
                        pictureBoxPlayer.BackColor = Color.FromArgb(206, 17, 65);
                    }

                    // Set stats in bold if they are highest amonst the list of players
                    var highestAssists = Players
                        .OrderByDescending(stat => stat.assistsPerGame)
                        .First();
                    if(player == highestAssists) lblAssistsValue.Font = new Font(lblAssistsValue.Font, FontStyle.Bold);
                    else lblAssistsValue.Font = new Font(lblAssistsValue.Font, FontStyle.Regular);

                    var highestBlocks = Players
                        .OrderByDescending(stat => stat.blocks)
                        .First();
                    if(player == highestBlocks) lblBlocksValue.Font = new Font(lblBlocksValue.Font, FontStyle.Bold);
                    else lblBlocksValue.Font= new Font(lblBlocksValue.Font, FontStyle.Regular);

                    var highestFieldGoalPercentage = Players
                        .OrderByDescending(stat => stat.fieldGoalPercent)
                        .First();
                    if(player == highestFieldGoalPercentage) lblFieldGoalPercentageValue.Font = new Font(lblFieldGoalPercentageValue.Font, FontStyle.Bold);
                    else lblFieldGoalPercentageValue.Font = new Font(lblFieldGoalPercentageValue.Font, FontStyle.Regular);

                    var highestFieldGoals = Players
                        .OrderByDescending(stat => stat.fieldGoals)
                        .First();
                    if(player == highestFieldGoals) lblFieldGoalsValue.Font = new Font(lblFieldGoalsValue.Font, FontStyle.Bold);
                    else lblFieldGoalsValue.Font = new Font(lblFieldGoalsValue.Font, FontStyle.Regular);

                    var highestFreeThrowPercentage = Players
                        .OrderByDescending(stat => stat.freeThrowPercent)
                        .First();
                    if(player == highestFreeThrowPercentage) lblFreeThrowPercentageValue.Font = new Font(lblFreeThrowPercentageValue.Font, FontStyle.Bold);
                    else lblFreeThrowPercentageValue.Font = new Font(lblFreeThrowPercentageValue.Font, FontStyle.Regular);

                    var highestGames = Players
                        .OrderByDescending(stat => stat.games)
                        .First();
                    if(player == highestGames) lblGamesPlayedValue.Font = new Font(lblGamesPlayedValue.Font, FontStyle.Bold);
                    else lblGamesPlayedValue.Font = new Font(lblGamesPlayedValue.Font, FontStyle.Regular);

                    var highestGamesStarted = Players
                        .OrderByDescending(stat => stat.gamesStarted)
                        .First();
                    if (player == highestGamesStarted) lblGamesStartedValue.Font = new Font(lblGamesStartedValue.Font, FontStyle.Bold);
                    else lblGamesStartedValue.Font = new Font(lblGamesStartedValue.Font, FontStyle.Regular);

                    var highestPointsPerGame = Players
                        .OrderByDescending(stat => stat.pointsPerGame)
                        .First();
                    if (player == highestPointsPerGame) lblPointsPerGameValue.Font = new Font(lblPointsPerGameValue.Font, FontStyle.Bold);
                    else lblPointsPerGameValue.Font = new Font(lblPointsPerGameValue.Font, FontStyle.Regular);

                    var highestPoints = Players
                        .OrderByDescending(stat => stat.points)
                        .First();
                    if(player == highestPoints) lblPointsValue.Font = new Font(lblPointsValue.Font, FontStyle.Bold);
                    else lblPointsValue.Font = new Font(lblPointsValue.Font, FontStyle.Regular);

                    var highestRebounds = Players
                        .OrderByDescending(stat => stat.reboundsPerGame)
                        .First();
                    if (player == highestRebounds) lblReboundsValue.Font = new Font(lblReboundsValue.Font, FontStyle.Bold);
                    else lblReboundsValue.Font = new Font(lblReboundsValue.Font, FontStyle.Regular);

                    var highestSteals = Players
                        .OrderByDescending(stat => stat.steals)
                        .First();
                    if (player == highestSteals) lblStealsValue.Font = new Font(lblStealsValue.Font, FontStyle.Bold);
                    else lblStealsValue.Font = new Font(lblStealsValue.Font, FontStyle.Regular);

                    var highestThreePoint = Players
                        .OrderByDescending(stat => stat.threePoint)
                        .First();
                    if (player == highestThreePoint) lblThreePointValue.Font = new Font(lblThreePointValue.Font, FontStyle.Bold);
                    else lblThreePointValue.Font = new Font(lblThreePointValue.Font, FontStyle.Regular);
                }
            }
        }

        // In case of non-click movement through the list
        private void listViewCards_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < listViewCards.Items.Count; i++)
            {
                if (listViewCards.Items[i].Selected == true)
                {
                    displayCard(Int32.Parse(listViewCards.Items[i].Text));
                    break;
                }
            }
        }
    }
}
