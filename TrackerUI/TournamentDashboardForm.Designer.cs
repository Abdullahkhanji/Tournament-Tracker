namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            headerLabel = new Label();
            tournamentDropdown = new ComboBox();
            selectTournamentLabel = new Label();
            loadTournamentBtn = new Button();
            createTournamentBtn = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Black;
            headerLabel.Location = new Point(56, 64);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(398, 49);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Tournament Dashboard";
            headerLabel.Click += headerLabel_Click;
            // 
            // tournamentDropdown
            // 
            tournamentDropdown.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentDropdown.FormattingEnabled = true;
            tournamentDropdown.Location = new Point(93, 223);
            tournamentDropdown.Name = "tournamentDropdown";
            tournamentDropdown.Size = new Size(335, 40);
            tournamentDropdown.TabIndex = 16;
            // 
            // selectTournamentLabel
            // 
            selectTournamentLabel.AutoSize = true;
            selectTournamentLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            selectTournamentLabel.Location = new Point(143, 178);
            selectTournamentLabel.Margin = new Padding(4, 0, 4, 0);
            selectTournamentLabel.Name = "selectTournamentLabel";
            selectTournamentLabel.Size = new Size(229, 31);
            selectTournamentLabel.TabIndex = 15;
            selectTournamentLabel.Text = "Select Tournament";
            // 
            // loadTournamentBtn
            // 
            loadTournamentBtn.BackColor = Color.Silver;
            loadTournamentBtn.FlatAppearance.BorderSize = 0;
            loadTournamentBtn.FlatStyle = FlatStyle.Popup;
            loadTournamentBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loadTournamentBtn.ForeColor = Color.Black;
            loadTournamentBtn.Location = new Point(134, 292);
            loadTournamentBtn.Name = "loadTournamentBtn";
            loadTournamentBtn.Size = new Size(256, 48);
            loadTournamentBtn.TabIndex = 26;
            loadTournamentBtn.Text = "Load Tournament";
            loadTournamentBtn.UseVisualStyleBackColor = false;
            // 
            // createTournamentBtn
            // 
            createTournamentBtn.BackColor = Color.Silver;
            createTournamentBtn.FlatAppearance.BorderSize = 0;
            createTournamentBtn.FlatStyle = FlatStyle.Popup;
            createTournamentBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentBtn.ForeColor = Color.Black;
            createTournamentBtn.Location = new Point(134, 359);
            createTournamentBtn.Name = "createTournamentBtn";
            createTournamentBtn.Size = new Size(256, 48);
            createTournamentBtn.TabIndex = 27;
            createTournamentBtn.Text = "Create Tournament";
            createTournamentBtn.UseVisualStyleBackColor = false;
            createTournamentBtn.Click += createTournamentBtn_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(createTournamentBtn);
            Controls.Add(loadTournamentBtn);
            Controls.Add(tournamentDropdown);
            Controls.Add(selectTournamentLabel);
            Controls.Add(headerLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            Load += TournamentDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox tournamentDropdown;
        private Label selectTournamentLabel;
        private Button loadTournamentBtn;
        private Button createTournamentBtn;
    }
}