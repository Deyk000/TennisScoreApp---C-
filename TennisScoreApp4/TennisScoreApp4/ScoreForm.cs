namespace Tennis_App
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            labelTennisScore = new Label();
            labelRanking = new Label();
            listViewRanking = new ListView();
            playerNameColumn = new ColumnHeader();
            scoreColumn = new ColumnHeader();
            labelClickOnName = new Label();
            listViewLatestGames = new ListView();
            firstPlayerColumn = new ColumnHeader();
            secondPlayerColumn = new ColumnHeader();
            winnerColumn = new ColumnHeader();
            totalScoreColumn = new ColumnHeader();
            labelLatestGames = new Label();
            buttonAddNewGame = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // labelTennisScore
            // 
            labelTennisScore.AutoSize = true;
            labelTennisScore.Font = new Font("Segoe UI", 30F);
            labelTennisScore.ImageAlign = ContentAlignment.TopCenter;
            labelTennisScore.Location = new Point(265, 9);
            labelTennisScore.Name = "labelTennisScore";
            labelTennisScore.RightToLeft = RightToLeft.No;
            labelTennisScore.Size = new Size(301, 67);
            labelTennisScore.TabIndex = 0;
            labelTennisScore.Text = "Tennis Score";
            labelTennisScore.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelRanking
            // 
            labelRanking.AutoSize = true;
            labelRanking.Font = new Font("Segoe UI", 13F);
            labelRanking.Location = new Point(127, 54);
            labelRanking.Name = "labelRanking";
            labelRanking.Size = new Size(90, 30);
            labelRanking.TabIndex = 1;
            labelRanking.Text = "Ranking";
            // 
            // listViewRanking
            // 
            listViewRanking.BackColor = Color.Coral;
            listViewRanking.Columns.AddRange(new ColumnHeader[] { playerNameColumn, scoreColumn });
            listViewRanking.Location = new Point(127, 99);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(615, 121);
            listViewRanking.TabIndex = 2;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            listViewRanking.DoubleClick += ViewProfileButtonClick;
            // 
            // playerNameColumn
            // 
            playerNameColumn.Text = "Player Name";
            playerNameColumn.Width = 240;
            // 
            // scoreColumn
            // 
            scoreColumn.Text = "Score";
            scoreColumn.TextAlign = HorizontalAlignment.Right;
            scoreColumn.Width = 240;
            // 
            // labelClickOnName
            // 
            labelClickOnName.AutoSize = true;
            labelClickOnName.Location = new Point(127, 223);
            labelClickOnName.Name = "labelClickOnName";
            labelClickOnName.Size = new Size(476, 20);
            labelClickOnName.TabIndex = 3;
            labelClickOnName.Text = "*click on a player's name to see more information about their matches.";
            // 
            // listViewLatestGames
            // 
            listViewLatestGames.BackColor = Color.Coral;
            listViewLatestGames.Columns.AddRange(new ColumnHeader[] { firstPlayerColumn, secondPlayerColumn, winnerColumn, totalScoreColumn });
            listViewLatestGames.Location = new Point(127, 313);
            listViewLatestGames.Name = "listViewLatestGames";
            listViewLatestGames.Size = new Size(615, 121);
            listViewLatestGames.TabIndex = 4;
            listViewLatestGames.UseCompatibleStateImageBehavior = false;
            listViewLatestGames.View = View.Details;
            listViewLatestGames.DoubleClick += ViewProfileButtonClick;
            // 
            // firstPlayerColumn
            // 
            firstPlayerColumn.Text = "First Player";
            firstPlayerColumn.Width = 120;
            // 
            // secondPlayerColumn
            // 
            secondPlayerColumn.Text = "Second Player";
            secondPlayerColumn.Width = 120;
            // 
            // winnerColumn
            // 
            winnerColumn.Text = "Winner";
            winnerColumn.Width = 120;
            // 
            // totalScoreColumn
            // 
            totalScoreColumn.Text = "Total Score";
            totalScoreColumn.Width = 120;
            // 
            // labelLatestGames
            // 
            labelLatestGames.AutoSize = true;
            labelLatestGames.Font = new Font("Segoe UI", 13F);
            labelLatestGames.Location = new Point(127, 267);
            labelLatestGames.Name = "labelLatestGames";
            labelLatestGames.Size = new Size(141, 30);
            labelLatestGames.TabIndex = 5;
            labelLatestGames.Text = "Latest Games";
            // 
            // buttonAddNewGame
            // 
            buttonAddNewGame.Location = new Point(609, 267);
            buttonAddNewGame.Name = "buttonAddNewGame";
            buttonAddNewGame.Size = new Size(133, 29);
            buttonAddNewGame.TabIndex = 6;
            buttonAddNewGame.Text = "Add New Game";
            buttonAddNewGame.UseVisualStyleBackColor = true;
            buttonAddNewGame.Click += AddNewGameButtonClick;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(609, 226);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(133, 27);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear Table";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearEventButton;
            // 
            // ScoreForm
            // 
            BackColor = Color.Khaki;
            ClientSize = new Size(820, 489);
            Controls.Add(ClearButton);
            Controls.Add(buttonAddNewGame);
            Controls.Add(labelLatestGames);
            Controls.Add(listViewLatestGames);
            Controls.Add(labelClickOnName);
            Controls.Add(listViewRanking);
            Controls.Add(labelRanking);
            Controls.Add(labelTennisScore);
            Name = "ScoreForm";
            RightToLeftLayout = true;
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        private static Dictionary<string, int> playersWithPoints = [];
        private static readonly Dictionary<(string name, int points), List<(string name, int points)>> games = [];

        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillRankingListView()
        {
            listViewRanking.Items.Clear();
            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                ListViewItem item = new(player.Key);
                item.SubItems.Add(player.Value.ToString());
                listViewRanking.Items.Add(item);
            }
        }

        private void FillLatestGamesListView()
        {
            listViewLatestGames.Items.Clear();
            foreach (var game in games)
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }

        private void FillListView((string name, int points) firstPlayer, (string name, int points) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem item = new(firstPlayer.name);
            item.SubItems.Add(secondPlayer.name);
            item.SubItems.Add(winner);
            item.SubItems.Add($"{firstPlayer.points} - {secondPlayer.points}");

            listViewLatestGames.Items.Add(item);
        }

        private static string GetWinner((string name, int points) firstPlayer, (string name, int points) secondPlayer)
        {
            if (firstPlayer.points > secondPlayer.points)
            {
                return firstPlayer.name;
            }
            else if (firstPlayer.points < secondPlayer.points)
            {
                return secondPlayer.name;
            }
            else
            {
                return "Draw";
            }
        }

        private void AddNewGameButtonClick(object sender, EventArgs e)
        {
            using NewGameForm newGameForm = new();
            if (newGameForm.ShowDialog() == DialogResult.OK)
            {
                AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
            }
        }

        private void AddNewGame((string name, int points) firstPlayer, (string name, int points) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);
            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);
            FillRankingListView();
            FillLatestGamesListView();
        }

        static private void FillGamesData((string name, int points) firstPlayer, (string name, int points) secondPlayer)
        {
            if (!games.ContainsKey(firstPlayer))
            {
                games[firstPlayer] = new List<(string name, int points)>();
            }
            games[firstPlayer].Add(secondPlayer);
        }

        static private void FillPlayerWithPoints((string name, int points) player)
        {
            if (playersWithPoints.ContainsKey(player.name))
            {
                playersWithPoints[player.name] += player.points;
            }
            else
            {
                playersWithPoints[player.name] = player.points;
            }
        }

        private void ViewProfileButtonClick(object sender, EventArgs e)
        {
            string playerName = string.Empty;


            if (listViewRanking.SelectedItems.Count > 0)
            {
                playerName = listViewRanking.SelectedItems[0].SubItems[0].Text;
            }

            else if (listViewLatestGames.SelectedItems.Count > 0)
            {
                ListViewItem selectedGame = listViewLatestGames.SelectedItems[0];
                Point mousePosition = listViewLatestGames.PointToClient(Cursor.Position);
                ListViewHitTestInfo hitTest = listViewLatestGames.HitTest(mousePosition);

                if (hitTest.SubItem != null && selectedGame.SubItems.Count > 1)
                {

                    if (hitTest.SubItem == selectedGame.SubItems[0])
                    {
                        playerName = selectedGame.SubItems[0].Text;
                    }
                    else if (hitTest.SubItem == selectedGame.SubItems[1])
                    {
                        playerName = selectedGame.SubItems[1].Text;
                    }
                }
                else
                {
                    playerName = selectedGame.SubItems[0].Text;
                }
            }


            if (!string.IsNullOrEmpty(playerName))
            {
                using PlayerInfoForm playerInfoForm = new PlayerInfoForm(playerName, GetPlayerGames(playerName));
                playerInfoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a player to view their profile.", "No Player Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearEventButton(object sender, EventArgs e)
        {
            listViewLatestGames.Items.Clear();
            listViewRanking.Items.Clear();
            playersWithPoints.Clear();
            games.Clear();
        }
        private Dictionary<(string name, int points), List<(string name, int points)>> GetPlayerGames(string playerName) => games.Where(x => x.Key.name == playerName
        || x.Value.Any(y => y.name == playerName)).ToDictionary(x => x.Key, x => x.Value.Where(y => y.name == playerName || x.Key.name == playerName).ToList());






    }
}