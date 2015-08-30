using System;
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
            bingo.Seed = SeedTextBox.Text;
            bingo.CreateRandFromSeed();
        }

        private void ChangeSeedButton_Click(object sender, EventArgs e)
        {
            SeedTextBox.Text = bingo.GetRandomSeed();
        }

        private void GenerateScrollListButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Seed: " + bingo.IntSeed);
            Debug.WriteLine("Number of scrolls: " + bingo.NumberOfScrolls);
            bingo.GetRandomScrollList(bingo.NumberOfScrolls);
            Debug.WriteLine("Scrolls List: " + bingo.PrintScrolls());
            ScrollListTextBox.Text = "Scrolls List: " + bingo.PrintScrolls();
        }

        private void ScrollNumber_ValueChanged(object sender, EventArgs e)
        {
            bingo.NumberOfScrolls = (int)ScrollNumber.Value;
        }
        #endregion
    }
}
