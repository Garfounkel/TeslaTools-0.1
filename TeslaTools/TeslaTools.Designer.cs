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
            this.SeedLabel = new System.Windows.Forms.Label();
            this.ChangeSeedButton = new System.Windows.Forms.Button();
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.TeslaSplit = new System.Windows.Forms.TabPage();
            this.SaveEditor = new System.Windows.Forms.TabPage();
            this.TASlagrad = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.Bingo.SuspendLayout();
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
            this.Bingo.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
        private System.Windows.Forms.Button button1;
    }
}

