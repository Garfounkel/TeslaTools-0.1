using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TeslaTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Error.WriteLine("Preference clicked");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("About clicked");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
