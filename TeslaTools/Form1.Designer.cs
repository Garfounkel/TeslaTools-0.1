namespace TeslaTools
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TeslaSplit = new System.Windows.Forms.TabPage();
            this.SaveEditor = new System.Windows.Forms.TabPage();
            this.Bingo = new System.Windows.Forms.TabPage();
            this.TASlagrad = new System.Windows.Forms.TabPage();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.AccessibleName = "";
            this.Tabs.Controls.Add(this.TeslaSplit);
            this.Tabs.Controls.Add(this.SaveEditor);
            this.Tabs.Controls.Add(this.Bingo);
            this.Tabs.Controls.Add(this.TASlagrad);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(941, 715);
            this.Tabs.TabIndex = 1;
            // 
            // TeslaSplit
            // 
            this.TeslaSplit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TeslaSplit.BackgroundImage")));
            this.TeslaSplit.Location = new System.Drawing.Point(4, 22);
            this.TeslaSplit.Name = "TeslaSplit";
            this.TeslaSplit.Padding = new System.Windows.Forms.Padding(3);
            this.TeslaSplit.Size = new System.Drawing.Size(933, 689);
            this.TeslaSplit.TabIndex = 0;
            this.TeslaSplit.Text = "TeslaSplit";
            this.TeslaSplit.UseVisualStyleBackColor = true;
            this.TeslaSplit.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // SaveEditor
            // 
            this.SaveEditor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveEditor.BackgroundImage")));
            this.SaveEditor.Location = new System.Drawing.Point(4, 22);
            this.SaveEditor.Name = "SaveEditor";
            this.SaveEditor.Padding = new System.Windows.Forms.Padding(3);
            this.SaveEditor.Size = new System.Drawing.Size(933, 689);
            this.SaveEditor.TabIndex = 1;
            this.SaveEditor.Text = "SaveEditor";
            this.SaveEditor.UseVisualStyleBackColor = true;
            // 
            // Bingo
            // 
            this.Bingo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bingo.BackgroundImage")));
            this.Bingo.Location = new System.Drawing.Point(4, 22);
            this.Bingo.Name = "Bingo";
            this.Bingo.Padding = new System.Windows.Forms.Padding(3);
            this.Bingo.Size = new System.Drawing.Size(933, 689);
            this.Bingo.TabIndex = 2;
            this.Bingo.Text = "Bingo";
            this.Bingo.UseVisualStyleBackColor = true;
            // 
            // TASlagrad
            // 
            this.TASlagrad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TASlagrad.BackgroundImage")));
            this.TASlagrad.Location = new System.Drawing.Point(4, 22);
            this.TASlagrad.Name = "TASlagrad";
            this.TASlagrad.Padding = new System.Windows.Forms.Padding(3);
            this.TASlagrad.Size = new System.Drawing.Size(933, 689);
            this.TASlagrad.TabIndex = 3;
            this.TASlagrad.Text = "TASlagrad";
            this.TASlagrad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 715);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TeslaTools";
            this.Tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TeslaSplit;
        private System.Windows.Forms.TabPage SaveEditor;
        private System.Windows.Forms.TabPage Bingo;
        private System.Windows.Forms.TabPage TASlagrad;
    }
}

