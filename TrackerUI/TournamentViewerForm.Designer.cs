namespace TrackerUI
{
    partial class TournamentViewerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropdown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListbox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            vsLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Black;
            headerLabel.Location = new Point(26, 30);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(224, 49);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            headerLabel.Click += label1_Click;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = Color.Black;
            tournamentName.Location = new Point(241, 30);
            tournamentName.Margin = new Padding(4, 0, 4, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(122, 49);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            tournamentName.Click += tournamentName_Click;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.Location = new Point(71, 138);
            roundLabel.Margin = new Padding(4, 0, 4, 0);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(83, 31);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            roundLabel.Click += label3_Click;
            // 
            // roundDropdown
            // 
            roundDropdown.FormattingEnabled = true;
            roundDropdown.Location = new Point(162, 135);
            roundDropdown.Name = "roundDropdown";
            roundDropdown.Size = new Size(281, 40);
            roundDropdown.TabIndex = 3;
            roundDropdown.SelectedIndexChanged += roundDropdown_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckbox.ForeColor = Color.Black;
            unplayedOnlyCheckbox.Location = new Point(162, 181);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(155, 29);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            unplayedOnlyCheckbox.CheckedChanged += unplayedOnlyCheckbox_CheckedChanged;
            // 
            // matchupListbox
            // 
            matchupListbox.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            matchupListbox.FormattingEnabled = true;
            matchupListbox.ItemHeight = 31;
            matchupListbox.Location = new Point(71, 242);
            matchupListbox.Name = "matchupListbox";
            matchupListbox.Size = new Size(372, 376);
            matchupListbox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("MV Boli", 24F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.Location = new Point(520, 135);
            teamOneName.Margin = new Padding(4, 0, 4, 0);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(201, 41);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<Team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.Location = new Point(550, 191);
            teamOneScoreLabel.Margin = new Padding(4, 0, 4, 0);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(74, 31);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            teamOneScoreLabel.Click += teamOneScoreLabel_Click;
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(630, 188);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(190, 39);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(630, 481);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(190, 39);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.Location = new Point(550, 484);
            teamTwoScoreLabel.Margin = new Padding(4, 0, 4, 0);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(74, 31);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("MV Boli", 24F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.Location = new Point(520, 428);
            teamTwoName.Margin = new Padding(4, 0, 4, 0);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(211, 41);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<Team Two>";
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point);
            vsLabel.Location = new Point(599, 295);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(162, 79);
            vsLabel.TabIndex = 12;
            vsLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.BackColor = Color.Silver;
            scoreButton.FlatAppearance.BorderSize = 0;
            scoreButton.FlatStyle = FlatStyle.Popup;
            scoreButton.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scoreButton.ForeColor = Color.Black;
            scoreButton.Location = new Point(868, 310);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(180, 64);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 707);
            Controls.Add(scoreButton);
            Controls.Add(vsLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListbox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropdown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "TournamentViewerForm";
            Text = "TournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropdown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListbox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label vsLabel;
        private Button scoreButton;
    }
}