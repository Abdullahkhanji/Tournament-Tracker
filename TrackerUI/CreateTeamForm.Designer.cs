namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameValue = new TextBox();
            teamOneScoreLabel = new Label();
            headerLabel = new Label();
            addMemberBtn = new Button();
            selectMemberDropdown = new ComboBox();
            selectMemberLabel = new Label();
            createMemberBox = new GroupBox();
            createMemberBtn = new Button();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            FirstNameLabel = new Label();
            teamMembersList = new ListBox();
            createTeamBtn = new Button();
            removeSelectedBtn = new Button();
            createMemberBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameValue.Location = new Point(80, 130);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(307, 33);
            teamNameValue.TabIndex = 13;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.Location = new Point(70, 96);
            teamOneScoreLabel.Margin = new Padding(4, 0, 4, 0);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(150, 31);
            teamOneScoreLabel.TabIndex = 12;
            teamOneScoreLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Black;
            headerLabel.Location = new Point(25, 28);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(229, 49);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Create Team";
            // 
            // addMemberBtn
            // 
            addMemberBtn.BackColor = Color.Silver;
            addMemberBtn.FlatAppearance.BorderSize = 0;
            addMemberBtn.FlatStyle = FlatStyle.Popup;
            addMemberBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addMemberBtn.ForeColor = Color.Black;
            addMemberBtn.Location = new Point(114, 289);
            addMemberBtn.Name = "addMemberBtn";
            addMemberBtn.Size = new Size(173, 41);
            addMemberBtn.TabIndex = 20;
            addMemberBtn.Text = "Add Member";
            addMemberBtn.UseVisualStyleBackColor = false;
            addMemberBtn.Click += addMemberBtn_Click;
            // 
            // selectMemberDropdown
            // 
            selectMemberDropdown.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectMemberDropdown.FormattingEnabled = true;
            selectMemberDropdown.Location = new Point(80, 224);
            selectMemberDropdown.Name = "selectMemberDropdown";
            selectMemberDropdown.Size = new Size(307, 34);
            selectMemberDropdown.TabIndex = 18;
            // 
            // selectMemberLabel
            // 
            selectMemberLabel.AutoSize = true;
            selectMemberLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            selectMemberLabel.Location = new Point(80, 190);
            selectMemberLabel.Margin = new Padding(4, 0, 4, 0);
            selectMemberLabel.Name = "selectMemberLabel";
            selectMemberLabel.Size = new Size(184, 31);
            selectMemberLabel.TabIndex = 17;
            selectMemberLabel.Text = "Select Member";
            // 
            // createMemberBox
            // 
            createMemberBox.Controls.Add(createMemberBtn);
            createMemberBox.Controls.Add(emailValue);
            createMemberBox.Controls.Add(emailLabel);
            createMemberBox.Controls.Add(lastNameValue);
            createMemberBox.Controls.Add(lastNameLabel);
            createMemberBox.Controls.Add(firstNameValue);
            createMemberBox.Controls.Add(FirstNameLabel);
            createMemberBox.Location = new Point(42, 353);
            createMemberBox.Name = "createMemberBox";
            createMemberBox.Size = new Size(395, 293);
            createMemberBox.TabIndex = 21;
            createMemberBox.TabStop = false;
            createMemberBox.Text = "Add New Member";
            createMemberBox.Enter += groupBox1_Enter;
            // 
            // createMemberBtn
            // 
            createMemberBtn.BackColor = Color.Silver;
            createMemberBtn.FlatAppearance.BorderSize = 0;
            createMemberBtn.FlatStyle = FlatStyle.Popup;
            createMemberBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            createMemberBtn.ForeColor = Color.Black;
            createMemberBtn.Location = new Point(86, 225);
            createMemberBtn.Name = "createMemberBtn";
            createMemberBtn.Size = new Size(200, 42);
            createMemberBtn.TabIndex = 22;
            createMemberBtn.Text = "Create Member";
            createMemberBtn.UseVisualStyleBackColor = false;
            createMemberBtn.Click += createMemberBtn_Click;
            // 
            // emailValue
            // 
            emailValue.Location = new Point(163, 163);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(213, 39);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(44, 167);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(73, 31);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(163, 108);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(213, 39);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(14, 108);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(139, 31);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(163, 54);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(213, 39);
            firstNameValue.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(14, 54);
            FirstNameLabel.Margin = new Padding(4, 0, 4, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(142, 31);
            FirstNameLabel.TabIndex = 9;
            FirstNameLabel.Text = "First Name";
            // 
            // teamMembersList
            // 
            teamMembersList.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            teamMembersList.FormattingEnabled = true;
            teamMembersList.ItemHeight = 31;
            teamMembersList.Location = new Point(508, 96);
            teamMembersList.Name = "teamMembersList";
            teamMembersList.Size = new Size(372, 438);
            teamMembersList.TabIndex = 22;
            // 
            // createTeamBtn
            // 
            createTeamBtn.BackColor = Color.Silver;
            createTeamBtn.FlatAppearance.BorderSize = 0;
            createTeamBtn.FlatStyle = FlatStyle.Popup;
            createTeamBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamBtn.ForeColor = Color.Black;
            createTeamBtn.Location = new Point(569, 567);
            createTeamBtn.Name = "createTeamBtn";
            createTeamBtn.Size = new Size(264, 64);
            createTeamBtn.TabIndex = 25;
            createTeamBtn.Text = "Create Team";
            createTeamBtn.UseVisualStyleBackColor = false;
            createTeamBtn.Click += createTeamBtn_Click;
            // 
            // removeSelectedBtn
            // 
            removeSelectedBtn.BackColor = Color.Silver;
            removeSelectedBtn.FlatAppearance.BorderSize = 0;
            removeSelectedBtn.FlatStyle = FlatStyle.Popup;
            removeSelectedBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            removeSelectedBtn.ForeColor = Color.Black;
            removeSelectedBtn.Location = new Point(901, 254);
            removeSelectedBtn.Name = "removeSelectedBtn";
            removeSelectedBtn.Size = new Size(121, 76);
            removeSelectedBtn.TabIndex = 26;
            removeSelectedBtn.Text = "Remove Selected";
            removeSelectedBtn.UseVisualStyleBackColor = false;
            removeSelectedBtn.Click += removeSelectedBtn_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 658);
            Controls.Add(removeSelectedBtn);
            Controls.Add(createTeamBtn);
            Controls.Add(teamMembersList);
            Controls.Add(createMemberBox);
            Controls.Add(addMemberBtn);
            Controls.Add(selectMemberDropdown);
            Controls.Add(selectMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            Load += CreateTeamForm_Load;
            createMemberBox.ResumeLayout(false);
            createMemberBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamOneScoreLabel;
        private Label headerLabel;
        private Button addMemberBtn;
        private ComboBox selectMemberDropdown;
        private Label selectMemberLabel;
        private GroupBox createMemberBox;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label FirstNameLabel;
        private Button createMemberBtn;
        private ListBox teamMembersList;
        private Button createTeamBtn;
        private Button removeSelectedBtn;
    }
}