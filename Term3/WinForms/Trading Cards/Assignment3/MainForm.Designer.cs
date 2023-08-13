namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewCards = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxCardDisplay = new System.Windows.Forms.GroupBox();
            this.lblTeamNameValue = new System.Windows.Forms.Label();
            this.lblPlayerNameValue = new System.Windows.Forms.Label();
            this.lblPointsPerGameValue = new System.Windows.Forms.Label();
            this.lblGamesPlayedValue = new System.Windows.Forms.Label();
            this.lblGamesStartedValue = new System.Windows.Forms.Label();
            this.lblFieldGoalsValue = new System.Windows.Forms.Label();
            this.lblFieldGoalPercentageValue = new System.Windows.Forms.Label();
            this.lblFreeThrowPercentageValue = new System.Windows.Forms.Label();
            this.lblThreePointValue = new System.Windows.Forms.Label();
            this.lblReboundsValue = new System.Windows.Forms.Label();
            this.lblAssistsValue = new System.Windows.Forms.Label();
            this.lblStealsValue = new System.Windows.Forms.Label();
            this.lblBlocksValue = new System.Windows.Forms.Label();
            this.lblPointsValue = new System.Windows.Forms.Label();
            this.lblPointsPerGame = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblHeightValue = new System.Windows.Forms.Label();
            this.lblWeightValue = new System.Windows.Forms.Label();
            this.lblNumberValue = new System.Windows.Forms.Label();
            this.lblPositionValue = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblGamesStarted = new System.Windows.Forms.Label();
            this.lblFieldGoals = new System.Windows.Forms.Label();
            this.lblFieldGoalPercentage = new System.Windows.Forms.Label();
            this.lblFreeThrowPercentage = new System.Windows.Forms.Label();
            this.lblThreePoint = new System.Windows.Forms.Label();
            this.lblRebounds = new System.Windows.Forms.Label();
            this.lblAssists = new System.Windows.Forms.Label();
            this.lblSteals = new System.Windows.Forms.Label();
            this.lblBlocks = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxCardDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.groupBoxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCards
            // 
            this.listViewCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCards.FullRowSelect = true;
            this.listViewCards.GridLines = true;
            this.listViewCards.HideSelection = false;
            this.listViewCards.Location = new System.Drawing.Point(12, 171);
            this.listViewCards.MultiSelect = false;
            this.listViewCards.Name = "listViewCards";
            this.listViewCards.Size = new System.Drawing.Size(323, 478);
            this.listViewCards.TabIndex = 0;
            this.listViewCards.UseCompatibleStateImageBehavior = false;
            this.listViewCards.View = System.Windows.Forms.View.Details;
            this.listViewCards.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewCards_ItemSelectionChanged);
            this.listViewCards.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewCards_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Player Name";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Team Name";
            this.columnHeader3.Width = 135;
            // 
            // groupBoxCardDisplay
            // 
            this.groupBoxCardDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxCardDisplay.Controls.Add(this.lblTeamNameValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblPlayerNameValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblPointsPerGameValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblGamesPlayedValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblGamesStartedValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblFieldGoalsValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblFieldGoalPercentageValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblFreeThrowPercentageValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblThreePointValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblReboundsValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblAssistsValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblStealsValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblBlocksValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblPointsValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblPointsPerGame);
            this.groupBoxCardDisplay.Controls.Add(this.lblHeight);
            this.groupBoxCardDisplay.Controls.Add(this.lblWeight);
            this.groupBoxCardDisplay.Controls.Add(this.lblPosition);
            this.groupBoxCardDisplay.Controls.Add(this.lblHeightValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblWeightValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblNumberValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblPositionValue);
            this.groupBoxCardDisplay.Controls.Add(this.lblGamesPlayed);
            this.groupBoxCardDisplay.Controls.Add(this.lblGamesStarted);
            this.groupBoxCardDisplay.Controls.Add(this.lblFieldGoals);
            this.groupBoxCardDisplay.Controls.Add(this.lblFieldGoalPercentage);
            this.groupBoxCardDisplay.Controls.Add(this.lblFreeThrowPercentage);
            this.groupBoxCardDisplay.Controls.Add(this.lblThreePoint);
            this.groupBoxCardDisplay.Controls.Add(this.lblRebounds);
            this.groupBoxCardDisplay.Controls.Add(this.lblAssists);
            this.groupBoxCardDisplay.Controls.Add(this.lblSteals);
            this.groupBoxCardDisplay.Controls.Add(this.lblBlocks);
            this.groupBoxCardDisplay.Controls.Add(this.lblPoints);
            this.groupBoxCardDisplay.Controls.Add(this.lblNumber);
            this.groupBoxCardDisplay.Controls.Add(this.lblPlayerName);
            this.groupBoxCardDisplay.Controls.Add(this.lblTeamName);
            this.groupBoxCardDisplay.Controls.Add(this.pictureBoxPlayer);
            this.groupBoxCardDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxCardDisplay.Location = new System.Drawing.Point(341, 12);
            this.groupBoxCardDisplay.Name = "groupBoxCardDisplay";
            this.groupBoxCardDisplay.Size = new System.Drawing.Size(731, 637);
            this.groupBoxCardDisplay.TabIndex = 1;
            this.groupBoxCardDisplay.TabStop = false;
            this.groupBoxCardDisplay.Text = "Card";
            // 
            // lblTeamNameValue
            // 
            this.lblTeamNameValue.AutoSize = true;
            this.lblTeamNameValue.Location = new System.Drawing.Point(18, 60);
            this.lblTeamNameValue.Name = "lblTeamNameValue";
            this.lblTeamNameValue.Size = new System.Drawing.Size(167, 25);
            this.lblTeamNameValue.TabIndex = 37;
            this.lblTeamNameValue.Text = "Toronto Raptors";
            // 
            // lblPlayerNameValue
            // 
            this.lblPlayerNameValue.AutoSize = true;
            this.lblPlayerNameValue.Location = new System.Drawing.Point(18, 147);
            this.lblPlayerNameValue.Name = "lblPlayerNameValue";
            this.lblPlayerNameValue.Size = new System.Drawing.Size(149, 25);
            this.lblPlayerNameValue.TabIndex = 36;
            this.lblPlayerNameValue.Text = "Fred VanVleet";
            // 
            // lblPointsPerGameValue
            // 
            this.lblPointsPerGameValue.Location = new System.Drawing.Point(663, 539);
            this.lblPointsPerGameValue.Name = "lblPointsPerGameValue";
            this.lblPointsPerGameValue.Size = new System.Drawing.Size(60, 25);
            this.lblPointsPerGameValue.TabIndex = 35;
            this.lblPointsPerGameValue.Text = "PPG";
            this.lblPointsPerGameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamesPlayedValue
            // 
            this.lblGamesPlayedValue.Location = new System.Drawing.Point(4, 539);
            this.lblGamesPlayedValue.Name = "lblGamesPlayedValue";
            this.lblGamesPlayedValue.Size = new System.Drawing.Size(40, 25);
            this.lblGamesPlayedValue.TabIndex = 34;
            this.lblGamesPlayedValue.Text = "G";
            this.lblGamesPlayedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamesStartedValue
            // 
            this.lblGamesStartedValue.Location = new System.Drawing.Point(52, 539);
            this.lblGamesStartedValue.Name = "lblGamesStartedValue";
            this.lblGamesStartedValue.Size = new System.Drawing.Size(45, 25);
            this.lblGamesStartedValue.TabIndex = 33;
            this.lblGamesStartedValue.Text = "GS";
            this.lblGamesStartedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFieldGoalsValue
            // 
            this.lblFieldGoalsValue.Location = new System.Drawing.Point(99, 539);
            this.lblFieldGoalsValue.Name = "lblFieldGoalsValue";
            this.lblFieldGoalsValue.Size = new System.Drawing.Size(55, 25);
            this.lblFieldGoalsValue.TabIndex = 32;
            this.lblFieldGoalsValue.Text = "FG";
            this.lblFieldGoalsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFieldGoalPercentageValue
            // 
            this.lblFieldGoalPercentageValue.Location = new System.Drawing.Point(151, 539);
            this.lblFieldGoalPercentageValue.Name = "lblFieldGoalPercentageValue";
            this.lblFieldGoalPercentageValue.Size = new System.Drawing.Size(75, 25);
            this.lblFieldGoalPercentageValue.TabIndex = 31;
            this.lblFieldGoalPercentageValue.Text = "FG%";
            this.lblFieldGoalPercentageValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreeThrowPercentageValue
            // 
            this.lblFreeThrowPercentageValue.Location = new System.Drawing.Point(220, 539);
            this.lblFreeThrowPercentageValue.Name = "lblFreeThrowPercentageValue";
            this.lblFreeThrowPercentageValue.Size = new System.Drawing.Size(75, 25);
            this.lblFreeThrowPercentageValue.TabIndex = 30;
            this.lblFreeThrowPercentageValue.Text = "FT%";
            this.lblFreeThrowPercentageValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThreePointValue
            // 
            this.lblThreePointValue.Location = new System.Drawing.Point(289, 539);
            this.lblThreePointValue.Name = "lblThreePointValue";
            this.lblThreePointValue.Size = new System.Drawing.Size(55, 25);
            this.lblThreePointValue.TabIndex = 29;
            this.lblThreePointValue.Text = "3P";
            this.lblThreePointValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReboundsValue
            // 
            this.lblReboundsValue.Location = new System.Drawing.Point(343, 539);
            this.lblReboundsValue.Name = "lblReboundsValue";
            this.lblReboundsValue.Size = new System.Drawing.Size(60, 25);
            this.lblReboundsValue.TabIndex = 28;
            this.lblReboundsValue.Text = "REB";
            this.lblReboundsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssistsValue
            // 
            this.lblAssistsValue.Location = new System.Drawing.Point(408, 539);
            this.lblAssistsValue.Name = "lblAssistsValue";
            this.lblAssistsValue.Size = new System.Drawing.Size(60, 25);
            this.lblAssistsValue.TabIndex = 27;
            this.lblAssistsValue.Text = "AST";
            this.lblAssistsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStealsValue
            // 
            this.lblStealsValue.Location = new System.Drawing.Point(474, 539);
            this.lblStealsValue.Name = "lblStealsValue";
            this.lblStealsValue.Size = new System.Drawing.Size(55, 25);
            this.lblStealsValue.TabIndex = 26;
            this.lblStealsValue.Text = "STL";
            this.lblStealsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlocksValue
            // 
            this.lblBlocksValue.Location = new System.Drawing.Point(537, 539);
            this.lblBlocksValue.Name = "lblBlocksValue";
            this.lblBlocksValue.Size = new System.Drawing.Size(55, 25);
            this.lblBlocksValue.TabIndex = 25;
            this.lblBlocksValue.Text = "BLK";
            this.lblBlocksValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointsValue
            // 
            this.lblPointsValue.Location = new System.Drawing.Point(595, 539);
            this.lblPointsValue.Name = "lblPointsValue";
            this.lblPointsValue.Size = new System.Drawing.Size(65, 25);
            this.lblPointsValue.TabIndex = 24;
            this.lblPointsValue.Text = "PTS";
            this.lblPointsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointsPerGame
            // 
            this.lblPointsPerGame.AutoSize = true;
            this.lblPointsPerGame.Location = new System.Drawing.Point(665, 495);
            this.lblPointsPerGame.Name = "lblPointsPerGame";
            this.lblPointsPerGame.Size = new System.Drawing.Size(56, 25);
            this.lblPointsPerGame.TabIndex = 23;
            this.lblPointsPerGame.Text = "PPG";
            this.toolTip.SetToolTip(this.lblPointsPerGame, "Points Per Game");
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(18, 190);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(80, 25);
            this.lblHeight.TabIndex = 22;
            this.lblHeight.Text = "Height:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(18, 258);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(85, 25);
            this.lblWeight.TabIndex = 21;
            this.lblWeight.Text = "Weight:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(18, 394);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(95, 25);
            this.lblPosition.TabIndex = 19;
            this.lblPosition.Text = "Position:";
            // 
            // lblHeightValue
            // 
            this.lblHeightValue.Location = new System.Drawing.Point(171, 190);
            this.lblHeightValue.Name = "lblHeightValue";
            this.lblHeightValue.Size = new System.Drawing.Size(71, 25);
            this.lblHeightValue.TabIndex = 18;
            this.lblHeightValue.Text = "6\' 6\"";
            this.lblHeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeightValue
            // 
            this.lblWeightValue.Location = new System.Drawing.Point(166, 258);
            this.lblWeightValue.Name = "lblWeightValue";
            this.lblWeightValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeightValue.Size = new System.Drawing.Size(76, 25);
            this.lblWeightValue.TabIndex = 17;
            this.lblWeightValue.Text = "230lbs";
            this.lblWeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberValue
            // 
            this.lblNumberValue.Location = new System.Drawing.Point(206, 326);
            this.lblNumberValue.Name = "lblNumberValue";
            this.lblNumberValue.Size = new System.Drawing.Size(36, 25);
            this.lblNumberValue.TabIndex = 16;
            this.lblNumberValue.Text = "23";
            this.lblNumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPositionValue
            // 
            this.lblPositionValue.Location = new System.Drawing.Point(197, 394);
            this.lblPositionValue.Name = "lblPositionValue";
            this.lblPositionValue.Size = new System.Drawing.Size(45, 25);
            this.lblPositionValue.TabIndex = 15;
            this.lblPositionValue.Text = "PF";
            this.lblPositionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.Location = new System.Drawing.Point(6, 495);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(36, 25);
            this.lblGamesPlayed.TabIndex = 14;
            this.lblGamesPlayed.Text = "G";
            this.lblGamesPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lblGamesPlayed, "Games Played");
            // 
            // lblGamesStarted
            // 
            this.lblGamesStarted.AutoSize = true;
            this.lblGamesStarted.Location = new System.Drawing.Point(53, 495);
            this.lblGamesStarted.Name = "lblGamesStarted";
            this.lblGamesStarted.Size = new System.Drawing.Size(42, 25);
            this.lblGamesStarted.TabIndex = 13;
            this.lblGamesStarted.Text = "GS";
            this.toolTip.SetToolTip(this.lblGamesStarted, "Games Started");
            // 
            // lblFieldGoals
            // 
            this.lblFieldGoals.AutoSize = true;
            this.lblFieldGoals.Location = new System.Drawing.Point(106, 495);
            this.lblFieldGoals.Name = "lblFieldGoals";
            this.lblFieldGoals.Size = new System.Drawing.Size(41, 25);
            this.lblFieldGoals.TabIndex = 12;
            this.lblFieldGoals.Text = "FG";
            this.toolTip.SetToolTip(this.lblFieldGoals, "Field Goals");
            // 
            // lblFieldGoalPercentage
            // 
            this.lblFieldGoalPercentage.AutoSize = true;
            this.lblFieldGoalPercentage.Location = new System.Drawing.Point(158, 495);
            this.lblFieldGoalPercentage.Name = "lblFieldGoalPercentage";
            this.lblFieldGoalPercentage.Size = new System.Drawing.Size(60, 25);
            this.lblFieldGoalPercentage.TabIndex = 11;
            this.lblFieldGoalPercentage.Text = "FG%";
            this.toolTip.SetToolTip(this.lblFieldGoalPercentage, "Field Goal %");
            // 
            // lblFreeThrowPercentage
            // 
            this.lblFreeThrowPercentage.AutoSize = true;
            this.lblFreeThrowPercentage.Location = new System.Drawing.Point(229, 495);
            this.lblFreeThrowPercentage.Name = "lblFreeThrowPercentage";
            this.lblFreeThrowPercentage.Size = new System.Drawing.Size(57, 25);
            this.lblFreeThrowPercentage.TabIndex = 10;
            this.lblFreeThrowPercentage.Text = "FT%";
            this.toolTip.SetToolTip(this.lblFreeThrowPercentage, "Free Throw %");
            // 
            // lblThreePoint
            // 
            this.lblThreePoint.AutoSize = true;
            this.lblThreePoint.Location = new System.Drawing.Point(297, 495);
            this.lblThreePoint.Name = "lblThreePoint";
            this.lblThreePoint.Size = new System.Drawing.Size(38, 25);
            this.lblThreePoint.TabIndex = 9;
            this.lblThreePoint.Text = "3P";
            this.toolTip.SetToolTip(this.lblThreePoint, "3 Point");
            // 
            // lblRebounds
            // 
            this.lblRebounds.AutoSize = true;
            this.lblRebounds.Location = new System.Drawing.Point(346, 495);
            this.lblRebounds.Name = "lblRebounds";
            this.lblRebounds.Size = new System.Drawing.Size(55, 25);
            this.lblRebounds.TabIndex = 8;
            this.lblRebounds.Text = "REB";
            this.toolTip.SetToolTip(this.lblRebounds, "Rebounds Per Game");
            // 
            // lblAssists
            // 
            this.lblAssists.AutoSize = true;
            this.lblAssists.Location = new System.Drawing.Point(412, 495);
            this.lblAssists.Name = "lblAssists";
            this.lblAssists.Size = new System.Drawing.Size(53, 25);
            this.lblAssists.TabIndex = 7;
            this.lblAssists.Text = "AST";
            this.toolTip.SetToolTip(this.lblAssists, "Assists Per Game");
            // 
            // lblSteals
            // 
            this.lblSteals.AutoSize = true;
            this.lblSteals.Location = new System.Drawing.Point(476, 495);
            this.lblSteals.Name = "lblSteals";
            this.lblSteals.Size = new System.Drawing.Size(51, 25);
            this.lblSteals.TabIndex = 6;
            this.lblSteals.Text = "STL";
            this.toolTip.SetToolTip(this.lblSteals, "Steals");
            // 
            // lblBlocks
            // 
            this.lblBlocks.AutoSize = true;
            this.lblBlocks.Location = new System.Drawing.Point(538, 495);
            this.lblBlocks.Name = "lblBlocks";
            this.lblBlocks.Size = new System.Drawing.Size(52, 25);
            this.lblBlocks.TabIndex = 5;
            this.lblBlocks.Text = "BLK";
            this.toolTip.SetToolTip(this.lblBlocks, "Blocks");
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(601, 495);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(53, 25);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "PTS";
            this.toolTip.SetToolTip(this.lblPoints, "Points");
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(18, 326);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(93, 25);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Number:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(6, 113);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(129, 25);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "PlayerName";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(6, 35);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(122, 25);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "TeamName";
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(275, 27);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(450, 450);
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.comboBoxOrderBy);
            this.groupBoxSort.Controls.Add(this.comboBoxSortBy);
            this.groupBoxSort.Controls.Add(this.lblOrderBy);
            this.groupBoxSort.Controls.Add(this.lblSortBy);
            this.groupBoxSort.Controls.Add(this.btnSort);
            this.groupBoxSort.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(323, 153);
            this.groupBoxSort.TabIndex = 2;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort";
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxOrderBy.Location = new System.Drawing.Point(115, 74);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(202, 33);
            this.comboBoxOrderBy.TabIndex = 4;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Number",
            "Player Name",
            "Team Name"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(115, 27);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(202, 33);
            this.comboBoxSortBy.TabIndex = 3;
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Location = new System.Drawing.Point(6, 78);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(103, 25);
            this.lblOrderBy.TabIndex = 2;
            this.lblOrderBy.Text = "Order By:";
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(6, 31);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(88, 25);
            this.lblSortBy.TabIndex = 1;
            this.lblSortBy.Text = "Sort By:";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(128, 113);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(67, 34);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.groupBoxCardDisplay);
            this.Controls.Add(this.listViewCards);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "MainForm";
            this.Text = "Basketball Cards";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxCardDisplay.ResumeLayout(false);
            this.groupBoxCardDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCards;
        private System.Windows.Forms.GroupBox groupBoxCardDisplay;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblHeightValue;
        private System.Windows.Forms.Label lblWeightValue;
        private System.Windows.Forms.Label lblNumberValue;
        private System.Windows.Forms.Label lblPositionValue;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblGamesStarted;
        private System.Windows.Forms.Label lblFieldGoals;
        private System.Windows.Forms.Label lblFieldGoalPercentage;
        private System.Windows.Forms.Label lblFreeThrowPercentage;
        private System.Windows.Forms.Label lblThreePoint;
        private System.Windows.Forms.Label lblRebounds;
        private System.Windows.Forms.Label lblAssists;
        private System.Windows.Forms.Label lblSteals;
        private System.Windows.Forms.Label lblBlocks;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPointsPerGame;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblPointsPerGameValue;
        private System.Windows.Forms.Label lblGamesPlayedValue;
        private System.Windows.Forms.Label lblGamesStartedValue;
        private System.Windows.Forms.Label lblFieldGoalsValue;
        private System.Windows.Forms.Label lblFieldGoalPercentageValue;
        private System.Windows.Forms.Label lblFreeThrowPercentageValue;
        private System.Windows.Forms.Label lblThreePointValue;
        private System.Windows.Forms.Label lblReboundsValue;
        private System.Windows.Forms.Label lblAssistsValue;
        private System.Windows.Forms.Label lblStealsValue;
        private System.Windows.Forms.Label lblBlocksValue;
        private System.Windows.Forms.Label lblPointsValue;
        private System.Windows.Forms.Label lblTeamNameValue;
        private System.Windows.Forms.Label lblPlayerNameValue;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

