using LolTCGCommon.Cards;
using System;
using System.Windows.Forms;

namespace LolTCGEditor
{
    public partial class TypeSelector : Form
    {
        public Card Value { get; private set; }

        public TypeSelector()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void championButton_Click(object sender, EventArgs e)
        {
            Value = new ChampionCard();
            CloseAsOk();
        }

        private void minionButton_Click(object sender, EventArgs e)
        {
            Value = new MinionCard();
            CloseAsOk();
        }

        private void structureButton_Click(object sender, EventArgs e)
        {
            Value = new StructureCard();
            CloseAsOk();
        }

        private void leaderButton_Click(object sender, EventArgs e)
        {
            Value = new LeaderCard();
            CloseAsOk();
        }

        private void CloseAsOk()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
