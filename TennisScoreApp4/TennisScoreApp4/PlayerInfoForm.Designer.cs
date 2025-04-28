namespace Tennis_App
{
    partial class PlayerInfoForm
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
            labelPlayerName = new Label();
            labelVictories = new Label();
            labelLosses = new Label();
            labelDraw = new Label();
            listViewVictories = new ListView();
            competitorVictories = new ColumnHeader();
            scoreVictories = new ColumnHeader();
            listViewLosses = new ListView();
            competitorLosses = new ColumnHeader();
            scoreLosses = new ColumnHeader();
            listViewDraw = new ListView();
            competitorDraw = new ColumnHeader();
            scoreDraw = new ColumnHeader();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 40F);
            labelPlayerName.Location = new Point(318, 9);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(411, 89);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            labelPlayerName.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelVictories
            // 
            labelVictories.AutoSize = true;
            labelVictories.Font = new Font("Segoe UI", 13F);
            labelVictories.Location = new Point(112, 133);
            labelVictories.Name = "labelVictories";
            labelVictories.Size = new Size(96, 30);
            labelVictories.TabIndex = 1;
            labelVictories.Text = "Victories";
            labelVictories.Click += labelVictories_Click;
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.Font = new Font("Segoe UI", 13F);
            labelLosses.Location = new Point(485, 133);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(75, 30);
            labelLosses.TabIndex = 2;
            labelLosses.Text = "Losses";
            // 
            // labelDraw
            // 
            labelDraw.AutoSize = true;
            labelDraw.Font = new Font("Segoe UI", 13F);
            labelDraw.Location = new Point(826, 133);
            labelDraw.Name = "labelDraw";
            labelDraw.Size = new Size(63, 30);
            labelDraw.TabIndex = 3;
            labelDraw.Text = "Draw";
            labelDraw.Click += labelDraw_Click;
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = Color.Coral;
            listViewVictories.Columns.AddRange(new ColumnHeader[] { competitorVictories, scoreVictories });
            listViewVictories.Location = new Point(12, 193);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(325, 163);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // competitorVictories
            // 
            competitorVictories.Text = "Competitor";
            // 
            // scoreVictories
            // 
            scoreVictories.Text = "Score";
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = Color.Coral;
            listViewLosses.Columns.AddRange(new ColumnHeader[] { competitorLosses, scoreLosses });
            listViewLosses.Location = new Point(365, 193);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(304, 163);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            listViewLosses.SelectedIndexChanged += listViewLosses_SelectedIndexChanged;
            // 
            // competitorLosses
            // 
            competitorLosses.Text = "Competitor";
            // 
            // scoreLosses
            // 
            scoreLosses.Text = "Score";
            // 
            // listViewDraw
            // 
            listViewDraw.BackColor = Color.Coral;
            listViewDraw.Columns.AddRange(new ColumnHeader[] { competitorDraw, scoreDraw });
            listViewDraw.Location = new Point(694, 193);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(326, 163);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // competitorDraw
            // 
            competitorDraw.Text = "Competitor";
            // 
            // scoreDraw
            // 
            scoreDraw.Text = "Score";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1055, 410);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(labelDraw);
            Controls.Add(labelLosses);
            Controls.Add(labelVictories);
            Controls.Add(labelPlayerName);
            Name = "PlayerInfoForm";
            Text = "PlayerInfoForm";
            Load += PlayerInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label labelVictories;
        private Label labelLosses;
        private Label labelDraw;
        private ListView listViewVictories;
        private ColumnHeader competitorVictories;
        private ColumnHeader scoreVictories;
        private ListView listViewLosses;
        private ListView listViewDraw;
        private ColumnHeader competitorLosses;
        private ColumnHeader scoreLosses;
        private ColumnHeader competitorDraw;
        private ColumnHeader scoreDraw;
    }
}