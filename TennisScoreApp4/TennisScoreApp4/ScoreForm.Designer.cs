namespace Tennis_App
{
    partial class ScoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        /// <summary>
        ///  Clean up any resources being used.
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


        private Label labelTennisScore;
        private Label labelRanking;
        private ListView listViewRanking;
        private ColumnHeader playerNameColumn;
        private ColumnHeader scoreColumn;
        private Label labelClickOnName;
        private ListView listViewLatestGames;
        private ColumnHeader firstPlayerColumn;
        private ColumnHeader secondPlayerColumn;
        private ColumnHeader winnerColumn;
        private ColumnHeader totalScoreColumn;
        private Label labelLatestGames;
        private Button buttonAddNewGame;
        private Button ClearButton;
    }
}