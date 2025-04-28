namespace Tennis_App
{
    public partial class PlayerInfoForm : Form
    {
        private readonly string playerName;
        private Dictionary<(string name, int points), List<(string name, int points)>> games = [];
        private (string name, int points) currentPlayer = new();
        private (string name, int points) competitor = new();
        public PlayerInfoForm(string playerName, Dictionary<(string name, int points), List<(string name, int points)>> games)
        {
            InitializeComponent();
            this.playerName = playerName;
            this.games = games;

            this.labelPlayerName.Text = playerName;
        }
        private void FillVictoriesAndLossesListViews()
        {
            ClearListViews();
            foreach (var game in games)
            {
                string firstPlayerName = game.Key.name;
                int firstPlayerPoints = game.Key.points;
                foreach (var (name, points) in game.Value)
                {
                    string secondPlayerName = name;
                    int secondPlayerPoints = points;

                    (this.currentPlayer, this.competitor) = GetCurrentPlayerAndCompetitor((firstPlayerName, firstPlayerPoints), (secondPlayerName, secondPlayerPoints));
                    UpdateListView();

                }
            }
        }

        private void ClearListViews()
        {
            this.listViewDraw.Items.Clear();
            this.listViewLosses.Items.Clear();
            this.listViewVictories.Items.Clear();
        }
        private ((string name, int points), (string name, int points)) GetCurrentPlayerAndCompetitor((string name, int points) firstPlayer, (string name, int points) secondPlayer)
        {
            if (firstPlayer.name == playerName)
            {
                return (firstPlayer, secondPlayer);
            }
            return (secondPlayer, firstPlayer);
        }
        private void UpdateListView()
        {
            string competitorName = competitor.name;
            int currentPlayerPoints = currentPlayer.points;
            int competitorPoints = competitor.points;
            string score = $"{currentPlayerPoints} - {competitorPoints}";

            ListView currentListView = GetCurrentListView(currentPlayerPoints, competitorPoints);
            AddDataToListView(competitorName, score, currentListView);
        }
        private ListView GetCurrentListView(int currentPlayerPoints, int competitorPoints)
        {
            if (currentPlayerPoints > competitorPoints)
            {
                return this.listViewVictories;
            }
            else if (currentPlayerPoints < competitorPoints)
            {
                return this.listViewLosses;
            }
            else
            {
                return this.listViewDraw;
            }
        }
        static private void AddDataToListView(string competitor, string score, ListView listView)
        {
            ListViewItem listViewItem = new();
            listViewItem.SubItems[0].Text = competitor;
            listViewItem.SubItems.Add(score);
            listView.Items.Add(listViewItem);
        }
        private void PlayerInfoForm_Load(object sender, EventArgs e)
        {
            FillVictoriesAndLossesListViews();
        }

        private void listViewLosses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelVictories_Click(object sender, EventArgs e)
        {

        }

        private void labelDraw_Click(object sender, EventArgs e)
        {

        }
    }
}