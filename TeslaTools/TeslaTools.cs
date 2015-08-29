using System;
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

            //Bingo Stuffs
            SeedTextBox.Text = bingo.GetRandomSeed();
        }

        #region Bingo Stuffs
        private void SeedTextBox_TextChanged(object sender, EventArgs e)
        {
            bingo.Seed = SeedTextBox.Text;
        }

        private void ChangeSeedButton_Click(object sender, EventArgs e)
        {
            SeedTextBox.Text = bingo.GetRandomSeed();
        }
        #endregion
    }
}
