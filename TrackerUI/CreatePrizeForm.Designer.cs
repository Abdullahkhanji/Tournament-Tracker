namespace TrackerUI
{
    partial class CreatePrizeForm
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
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            placeNameValue = new TextBox();
            nameLabel = new Label();
            placeNumValue = new TextBox();
            NumberLabel = new Label();
            headerLabel = new Label();
            prizePerValue = new TextBox();
            prizePerLabel = new Label();
            orLabel = new Label();
            createPrizeBtn = new Button();
            SuspendLayout();
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountValue.Location = new Point(375, 234);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(234, 33);
            prizeAmountValue.TabIndex = 20;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.Location = new Point(165, 232);
            prizeAmountLabel.Margin = new Padding(4, 0, 4, 0);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(172, 31);
            prizeAmountLabel.TabIndex = 19;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameValue.Location = new Point(375, 175);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(234, 33);
            placeNameValue.TabIndex = 18;
            placeNameValue.TextChanged += textBox2_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(165, 175);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(146, 31);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Place Name";
            nameLabel.Click += label2_Click;
            // 
            // placeNumValue
            // 
            placeNumValue.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumValue.Location = new Point(375, 113);
            placeNumValue.Name = "placeNumValue";
            placeNumValue.Size = new Size(234, 33);
            placeNumValue.TabIndex = 16;
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NumberLabel.Location = new Point(165, 111);
            NumberLabel.Margin = new Padding(4, 0, 4, 0);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(170, 31);
            NumberLabel.TabIndex = 15;
            NumberLabel.Text = "Place Number";
            NumberLabel.Click += label1_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Black;
            headerLabel.Location = new Point(37, 31);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(223, 49);
            headerLabel.TabIndex = 21;
            headerLabel.Text = "Create Prize";
            // 
            // prizePerValue
            // 
            prizePerValue.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePerValue.Location = new Point(375, 356);
            prizePerValue.Name = "prizePerValue";
            prizePerValue.Size = new Size(234, 33);
            prizePerValue.TabIndex = 23;
            prizePerValue.Text = "0";
            // 
            // prizePerLabel
            // 
            prizePerLabel.AutoSize = true;
            prizePerLabel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            prizePerLabel.Location = new Point(165, 358);
            prizePerLabel.Margin = new Padding(4, 0, 4, 0);
            prizePerLabel.Name = "prizePerLabel";
            prizePerLabel.Size = new Size(203, 31);
            prizePerLabel.TabIndex = 22;
            prizePerLabel.Text = "Prize Percentage";
            prizePerLabel.Click += label4_Click;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.Black;
            orLabel.Location = new Point(361, 288);
            orLabel.Margin = new Padding(4, 0, 4, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(44, 38);
            orLabel.TabIndex = 24;
            orLabel.Text = "or";
            // 
            // createPrizeBtn
            // 
            createPrizeBtn.BackColor = Color.Silver;
            createPrizeBtn.FlatAppearance.BorderSize = 0;
            createPrizeBtn.FlatStyle = FlatStyle.Popup;
            createPrizeBtn.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeBtn.ForeColor = Color.Black;
            createPrizeBtn.Location = new Point(260, 438);
            createPrizeBtn.Name = "createPrizeBtn";
            createPrizeBtn.Size = new Size(264, 64);
            createPrizeBtn.TabIndex = 26;
            createPrizeBtn.Text = "Create Prize";
            createPrizeBtn.UseVisualStyleBackColor = false;
            createPrizeBtn.Click += createPrizeBtn_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 552);
            Controls.Add(createPrizeBtn);
            Controls.Add(orLabel);
            Controls.Add(prizePerValue);
            Controls.Add(prizePerLabel);
            Controls.Add(headerLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(nameLabel);
            Controls.Add(placeNumValue);
            Controls.Add(NumberLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox placeNameValue;
        private Label nameLabel;
        private TextBox placeNumValue;
        private Label NumberLabel;
        private Label headerLabel;
        private TextBox prizePerValue;
        private Label prizePerLabel;
        private Label orLabel;
        private Button createPrizeBtn;
    }
}