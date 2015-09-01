namespace TeslaTools
{
    partial class TeslaTools
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeslaTools));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Bingo = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GenerateBingoCard = new System.Windows.Forms.Button();
            this.BingoCardTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ScrollListTextBox = new System.Windows.Forms.TextBox();
            this.ScrollsNumberLabel = new System.Windows.Forms.Label();
            this.ScrollNumber = new System.Windows.Forms.NumericUpDown();
            this.GenerateScrollListButton = new System.Windows.Forms.Button();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.ChangeSeedButton = new System.Windows.Forms.Button();
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.TeslaSplit = new System.Windows.Forms.TabPage();
            this.SaveEditor = new System.Windows.Forms.TabPage();
            this.TASlagrad = new System.Windows.Forms.TabPage();
            this.Tabs.SuspendLayout();
            this.Bingo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.AccessibleName = "";
            this.Tabs.Controls.Add(this.Bingo);
            this.Tabs.Controls.Add(this.TeslaSplit);
            this.Tabs.Controls.Add(this.SaveEditor);
            this.Tabs.Controls.Add(this.TASlagrad);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(980, 749);
            this.Tabs.TabIndex = 1;
            // 
            // Bingo
            // 
            this.Bingo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bingo.BackgroundImage")));
            this.Bingo.Controls.Add(this.tabControl1);
            this.Bingo.Controls.Add(this.SeedLabel);
            this.Bingo.Controls.Add(this.ChangeSeedButton);
            this.Bingo.Controls.Add(this.SeedTextBox);
            this.Bingo.Location = new System.Drawing.Point(4, 22);
            this.Bingo.Name = "Bingo";
            this.Bingo.Padding = new System.Windows.Forms.Padding(3);
            this.Bingo.Size = new System.Drawing.Size(972, 723);
            this.Bingo.TabIndex = 2;
            this.Bingo.Text = "Bingo";
            this.Bingo.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(29, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 355);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bingo 5 x 5 x 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bingo 3 x 15 x 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.GenerateBingoCard);
            this.tabPage3.Controls.Add(this.BingoCardTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(570, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bingo 5 x 5 x 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GenerateBingoCard
            // 
            this.GenerateBingoCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBingoCard.Location = new System.Drawing.Point(23, 49);
            this.GenerateBingoCard.Name = "GenerateBingoCard";
            this.GenerateBingoCard.Size = new System.Drawing.Size(220, 49);
            this.GenerateBingoCard.TabIndex = 9;
            this.GenerateBingoCard.Text = "Generate Bingo Card";
            this.GenerateBingoCard.UseVisualStyleBackColor = true;
            this.GenerateBingoCard.Click += new System.EventHandler(this.GenerateBingoCard_Click);
            // 
            // BingoCardTextBox
            // 
            this.BingoCardTextBox.Enabled = false;
            this.BingoCardTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BingoCardTextBox.Location = new System.Drawing.Point(23, 104);
            this.BingoCardTextBox.Multiline = true;
            this.BingoCardTextBox.Name = "BingoCardTextBox";
            this.BingoCardTextBox.ShortcutsEnabled = false;
            this.BingoCardTextBox.Size = new System.Drawing.Size(521, 175);
            this.BingoCardTextBox.TabIndex = 10;
            this.BingoCardTextBox.Text = "Bingo Card:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.ScrollListTextBox);
            this.tabPage4.Controls.Add(this.ScrollsNumberLabel);
            this.tabPage4.Controls.Add(this.ScrollNumber);
            this.tabPage4.Controls.Add(this.GenerateScrollListButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(570, 329);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Scroll list";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ScrollListTextBox
            // 
            this.ScrollListTextBox.Enabled = false;
            this.ScrollListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrollListTextBox.Location = new System.Drawing.Point(26, 88);
            this.ScrollListTextBox.Multiline = true;
            this.ScrollListTextBox.Name = "ScrollListTextBox";
            this.ScrollListTextBox.ShortcutsEnabled = false;
            this.ScrollListTextBox.Size = new System.Drawing.Size(430, 87);
            this.ScrollListTextBox.TabIndex = 8;
            this.ScrollListTextBox.Text = "Scrolls List: ";
            // 
            // ScrollsNumberLabel
            // 
            this.ScrollsNumberLabel.AutoSize = true;
            this.ScrollsNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrollsNumberLabel.ForeColor = System.Drawing.Color.Snow;
            this.ScrollsNumberLabel.Location = new System.Drawing.Point(22, 24);
            this.ScrollsNumberLabel.Name = "ScrollsNumberLabel";
            this.ScrollsNumberLabel.Size = new System.Drawing.Size(157, 24);
            this.ScrollsNumberLabel.TabIndex = 6;
            this.ScrollsNumberLabel.Text = "Number of scrolls";
            // 
            // ScrollNumber
            // 
            this.ScrollNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrollNumber.Location = new System.Drawing.Point(26, 51);
            this.ScrollNumber.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.ScrollNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScrollNumber.Name = "ScrollNumber";
            this.ScrollNumber.Size = new System.Drawing.Size(58, 31);
            this.ScrollNumber.TabIndex = 7;
            this.ScrollNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScrollNumber.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ScrollNumber.ValueChanged += new System.EventHandler(this.ScrollNumber_ValueChanged);
            // 
            // GenerateScrollListButton
            // 
            this.GenerateScrollListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateScrollListButton.Location = new System.Drawing.Point(90, 51);
            this.GenerateScrollListButton.Name = "GenerateScrollListButton";
            this.GenerateScrollListButton.Size = new System.Drawing.Size(62, 27);
            this.GenerateScrollListButton.TabIndex = 4;
            this.GenerateScrollListButton.Text = "GO";
            this.GenerateScrollListButton.UseVisualStyleBackColor = true;
            this.GenerateScrollListButton.Click += new System.EventHandler(this.GenerateScrollListButton_Click);
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeedLabel.ForeColor = System.Drawing.Color.Snow;
            this.SeedLabel.Location = new System.Drawing.Point(25, 36);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(62, 25);
            this.SeedLabel.TabIndex = 3;
            this.SeedLabel.Text = "Seed";
            // 
            // ChangeSeedButton
            // 
            this.ChangeSeedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChangeSeedButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangeSeedButton.Image")));
            this.ChangeSeedButton.Location = new System.Drawing.Point(123, 63);
            this.ChangeSeedButton.Name = "ChangeSeedButton";
            this.ChangeSeedButton.Size = new System.Drawing.Size(32, 29);
            this.ChangeSeedButton.TabIndex = 2;
            this.ChangeSeedButton.UseVisualStyleBackColor = true;
            this.ChangeSeedButton.Click += new System.EventHandler(this.ChangeSeedButton_Click);
            // 
            // SeedTextBox
            // 
            this.SeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeedTextBox.Location = new System.Drawing.Point(29, 63);
            this.SeedTextBox.MaxLength = 5;
            this.SeedTextBox.Name = "SeedTextBox";
            this.SeedTextBox.Size = new System.Drawing.Size(88, 29);
            this.SeedTextBox.TabIndex = 1;
            this.SeedTextBox.TextChanged += new System.EventHandler(this.SeedTextBox_TextChanged);
            // 
            // TeslaSplit
            // 
            this.TeslaSplit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TeslaSplit.BackgroundImage")));
            this.TeslaSplit.Location = new System.Drawing.Point(4, 22);
            this.TeslaSplit.Name = "TeslaSplit";
            this.TeslaSplit.Padding = new System.Windows.Forms.Padding(3);
            this.TeslaSplit.Size = new System.Drawing.Size(972, 723);
            this.TeslaSplit.TabIndex = 0;
            this.TeslaSplit.Text = "TeslaSplit";
            this.TeslaSplit.UseVisualStyleBackColor = true;
            // 
            // SaveEditor
            // 
            this.SaveEditor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveEditor.BackgroundImage")));
            this.SaveEditor.Location = new System.Drawing.Point(4, 22);
            this.SaveEditor.Name = "SaveEditor";
            this.SaveEditor.Padding = new System.Windows.Forms.Padding(3);
            this.SaveEditor.Size = new System.Drawing.Size(972, 723);
            this.SaveEditor.TabIndex = 1;
            this.SaveEditor.Text = "SaveEditor";
            this.SaveEditor.UseVisualStyleBackColor = true;
            // 
            // TASlagrad
            // 
            this.TASlagrad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TASlagrad.BackgroundImage")));
            this.TASlagrad.Location = new System.Drawing.Point(4, 22);
            this.TASlagrad.Name = "TASlagrad";
            this.TASlagrad.Padding = new System.Windows.Forms.Padding(3);
            this.TASlagrad.Size = new System.Drawing.Size(972, 723);
            this.TASlagrad.TabIndex = 3;
            this.TASlagrad.Text = "TASlagrad";
            this.TASlagrad.UseVisualStyleBackColor = true;
            // 
            // TeslaTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 749);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeslaTools";
            this.Text = "TeslaTools";
            this.Tabs.ResumeLayout(false);
            this.Bingo.ResumeLayout(false);
            this.Bingo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TeslaSplit;
        private System.Windows.Forms.TabPage SaveEditor;
        private System.Windows.Forms.TabPage Bingo;
        private System.Windows.Forms.TabPage TASlagrad;
        private System.Windows.Forms.TextBox SeedTextBox;
        private System.Windows.Forms.Button ChangeSeedButton;
        private System.Windows.Forms.Label SeedLabel;
        private System.Windows.Forms.Button GenerateScrollListButton;
        private System.Windows.Forms.Label ScrollsNumberLabel;
        private System.Windows.Forms.NumericUpDown ScrollNumber;
        private System.Windows.Forms.TextBox ScrollListTextBox;
        private System.Windows.Forms.TextBox BingoCardTextBox;
        private System.Windows.Forms.Button GenerateBingoCard;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

