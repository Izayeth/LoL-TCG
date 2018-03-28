using LolTCGCommon;
using System;
using System.Windows.Forms;

namespace LolTCGEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void saveCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Cards file | *.crd"; 
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Controllers.Instance.CardsController.SaveCardsToFile(saveFileDialog.FileName);
            }           
        }

        private void loadCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Cards file | *.crd";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Controllers.Instance.CardsController.LoadCardsFromFile(openFileDialog.FileName);
            }
        }
    }
}
