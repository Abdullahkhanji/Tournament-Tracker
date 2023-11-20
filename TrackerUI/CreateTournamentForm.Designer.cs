namespace TrackerUI
{
    partial class createTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createTournament));
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            teamDropdown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamBtn = new Button();
            createPrizeBtn = new Button();
            teamsList = new ListBox();
            teamsLabel = new Label();
            prizesLabel = new Label();
            prizesList = new ListBox();
            deleteTeamBtn = new Button();
            deletePrizeBtn = new Button();
            createTournamentBtn = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Black;
            headerLabel.Location = new Point(23, 19);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(333, 49);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameValue.Location = new Point(80, 137);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(248, 33);
            tournamentNameValue.TabIndex = 10;
            tournamentNameValue.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(70, 103);
            tournamentNameLabel.Margin = new Padding(4, 0, 4, 0);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(225, 31);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            tournamentNameLabel.Click += teamOneScoreLabel_Click;
            // 
            // entryFeeValue
            // 
            entryFeeValue.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeValue.Location = new Point(80, 236);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(248, 33);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            entryFeeValue.TextChanged += textBox1_TextChanged;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.Location = new Point(80, 202);
            entryFeeLabel.Margin = new Padding(4, 0, 4, 0);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(126, 31);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // teamDropdown
            // 
            teamDropdown.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamDropdown.FormattingEnabled = true;
            teamDropdown.Location = new Point(80, 335);
            teamDropdown.Name = "teamDropdown";
            teamDropdown.Size = new Size(248, 34);
            teamDropdown.TabIndex = 14;
            teamDropdown.SelectedIndexChanged += roundDropdown_SelectedIndexChanged;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.Location = new Point(80, 301);
            selectTeamLabel.Margin = new Padding(4, 0, 4, 0);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(154, 31);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            selectTeamLabel.Click += roundLabel_Click;
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            createNewTeamLink.Location = new Point(80, 372);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(82, 17);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create Team";
            createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
            // 
            // addTeamBtn
            // 
            addTeamBtn.BackColor = Color.Silver;
            addTeamBtn.FlatAppearance.BorderSize = 0;
            addTeamBtn.FlatStyle = FlatStyle.Popup;
            addTeamBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addTeamBtn.ForeColor = Color.Black;
            addTeamBtn.Location = new Point(122, 416);
            addTeamBtn.Name = "addTeamBtn";
            addTeamBtn.Size = new Size(173, 41);
            addTeamBtn.TabIndex = 16;
            addTeamBtn.Text = "Add Team";
            addTeamBtn.UseVisualStyleBackColor = false;
            addTeamBtn.Click += addTeamBtn_Click;
            // 
            // createPrizeBtn
            // 
            createPrizeBtn.BackColor = Color.Silver;
            createPrizeBtn.FlatAppearance.BorderSize = 0;
            createPrizeBtn.FlatStyle = FlatStyle.Popup;
            createPrizeBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeBtn.ForeColor = Color.Black;
            createPrizeBtn.Location = new Point(122, 476);
            createPrizeBtn.Name = "createPrizeBtn";
            createPrizeBtn.Size = new Size(173, 42);
            createPrizeBtn.TabIndex = 17;
            createPrizeBtn.Text = "Create Prize";
            createPrizeBtn.UseVisualStyleBackColor = false;
            createPrizeBtn.Click += createPrizeBtn_Click;
            // 
            // teamsList
            // 
            teamsList.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            teamsList.FormattingEnabled = true;
            teamsList.ItemHeight = 31;
            teamsList.Location = new Point(452, 124);
            teamsList.Name = "teamsList";
            teamsList.Size = new Size(325, 159);
            teamsList.TabIndex = 18;
            // 
            // teamsLabel
            // 
            teamsLabel.AutoSize = true;
            teamsLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            teamsLabel.Location = new Point(452, 90);
            teamsLabel.Margin = new Padding(4, 0, 4, 0);
            teamsLabel.Name = "teamsLabel";
            teamsLabel.Size = new Size(199, 31);
            teamsLabel.TabIndex = 19;
            teamsLabel.Text = "Teams / Players";
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.Location = new Point(452, 324);
            prizesLabel.Margin = new Padding(4, 0, 4, 0);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(80, 31);
            prizesLabel.TabIndex = 21;
            prizesLabel.Text = "Prizes";
            // 
            // prizesList
            // 
            prizesList.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            prizesList.FormattingEnabled = true;
            prizesList.ItemHeight = 31;
            prizesList.Location = new Point(452, 358);
            prizesList.Name = "prizesList";
            prizesList.Size = new Size(325, 159);
            prizesList.TabIndex = 20;
            // 
            // deleteTeamBtn
            // 
            deleteTeamBtn.BackColor = Color.Silver;
            deleteTeamBtn.FlatAppearance.BorderSize = 0;
            deleteTeamBtn.FlatStyle = FlatStyle.Popup;
            deleteTeamBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            deleteTeamBtn.ForeColor = Color.Black;
            deleteTeamBtn.Location = new Point(805, 184);
            deleteTeamBtn.Name = "deleteTeamBtn";
            deleteTeamBtn.Size = new Size(149, 48);
            deleteTeamBtn.TabIndex = 22;
            deleteTeamBtn.Text = "Delete";
            deleteTeamBtn.UseVisualStyleBackColor = false;
            deleteTeamBtn.Click += deleteTeamBtn_Click;
            // 
            // deletePrizeBtn
            // 
            deletePrizeBtn.BackColor = Color.Silver;
            deletePrizeBtn.FlatAppearance.BorderSize = 0;
            deletePrizeBtn.FlatStyle = FlatStyle.Popup;
            deletePrizeBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            deletePrizeBtn.ForeColor = Color.Black;
            deletePrizeBtn.Location = new Point(805, 408);
            deletePrizeBtn.Name = "deletePrizeBtn";
            deletePrizeBtn.Size = new Size(149, 48);
            deletePrizeBtn.TabIndex = 23;
            deletePrizeBtn.Text = "Delete";
            deletePrizeBtn.UseVisualStyleBackColor = false;
            deletePrizeBtn.Click += deletePrizeBtn_Click;
            // 
            // createTournamentBtn
            // 
            createTournamentBtn.BackColor = Color.Silver;
            createTournamentBtn.FlatAppearance.BorderSize = 0;
            createTournamentBtn.FlatStyle = FlatStyle.Popup;
            createTournamentBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentBtn.ForeColor = Color.Black;
            createTournamentBtn.Location = new Point(341, 569);
            createTournamentBtn.Name = "createTournamentBtn";
            createTournamentBtn.Size = new Size(264, 64);
            createTournamentBtn.TabIndex = 24;
            createTournamentBtn.Text = "Create Tournament";
            createTournamentBtn.UseVisualStyleBackColor = false;
            createTournamentBtn.Click += createTournamentBtn_Click;
            // 
            // createTournament
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 668);
            Controls.Add(createTournamentBtn);
            Controls.Add(deletePrizeBtn);
            Controls.Add(deleteTeamBtn);
            Controls.Add(prizesLabel);
            Controls.Add(prizesList);
            Controls.Add(teamsLabel);
            Controls.Add(teamsList);
            Controls.Add(createPrizeBtn);
            Controls.Add(addTeamBtn);
            Controls.Add(createNewTeamLink);
            Controls.Add(teamDropdown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "createTournament";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox teamDropdown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamBtn;
        private Button createPrizeBtn;
        private ListBox teamsList;
        private Label teamsLabel;
        private Label prizesLabel;
        private ListBox prizesList;
        private Button deleteTeamBtn;
        private Button deletePrizeBtn;
        private Button createTournamentBtn;
    }
}