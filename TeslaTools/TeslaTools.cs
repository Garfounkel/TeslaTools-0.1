using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace TeslaTools
{
    public partial class TeslaTools : Form
    {
        private Bingo bingo;
        private SaveEditor saveEditor;
        private TASlagrad tasLagrad;
        private TeslaSplit teslaSplit;

        public TeslaTools()
        {
            InitializeComponent();

            bingo = new Bingo();
            saveEditor = new SaveEditor();
            tasLagrad = new TASlagrad();
            teslaSplit = new TeslaSplit();

            // Bingo Stuffs 
            SeedTextBox.Text = bingo.GetRandomSeed();
            bingo.NumberOfScrolls = 15;
        }

        #region Bingo Stuffs
        private void SeedTextBox_TextChanged(object sender, EventArgs e)
        {
            bingo.StringSeed = SeedTextBox.Text;
            bingo.SetSeed();
        }

        private void ChangeSeedButton_Click(object sender, EventArgs e)
        {
            SeedTextBox.Text = bingo.GetRandomSeed();
        }

        private void GenerateScrollListButton_Click(object sender, EventArgs e)
        {
            bingo.SetSeed();
            Debug.WriteLine("Seed: " + bingo.IntSeed);
            Debug.WriteLine("Number of scrolls: " + bingo.NumberOfScrolls);
            bingo.GetRandomScrollList(bingo.NumberOfScrolls, new List<int>());
            Debug.WriteLine("Scrolls List: " + bingo.PrintList(bingo.ScrollsList));
            ScrollListTextBox.Text = "Scrolls List: " + bingo.PrintList(bingo.ScrollsList);
        }

        private void ScrollNumber_ValueChanged(object sender, EventArgs e)
        {
            bingo.NumberOfScrolls = (int)ScrollNumber.Value;
        }

        private void GenerateBingoCard_Click(object sender, EventArgs e)
        {
            bingo.SetSeed();
            bingo.GenerateBingoCard();
            BingoCardTextBox.Text = "Bingo Card:" + Environment.NewLine + bingo.PrintBingoCard(bingo.BingoCard);
        }
        #endregion
    }
}
