using LolTCGCommon;
using LolTCGCommon.Cards;
using System;
using System.Windows.Forms;

namespace LolTCGEditor
{
    public partial class CardEditor : UserControl
    {
        public Card Value { get; set; }

        public const string CHAMPION = "Champion";
        public const string MINION = "Minion";
        public const string STRUCTURE = "Structure";
        public const string LEADER = "Leader";

        private bool newValue;

        public CardEditor()
        {
            InitializeComponent();
            FillTypeCombobox();
        }

        public void Edit(bool newValue, Card value)
        {
            this.newValue = newValue;
            this.Value = value;
            saveButton.Text = newValue ? "Add" : "Save";
            FillControls();
            Visible = true;
        }

        private void FillControls()
        {
            nameTextBox.Text = Value.Name;
            SelectType();
        }

        private void FillTypeCombobox()
        {
            typeComboBox.Items.Add(CHAMPION);
            typeComboBox.Items.Add(MINION);
            typeComboBox.Items.Add(STRUCTURE);
            typeComboBox.Items.Add(LEADER);
            typeComboBox.SelectedIndex = 0;
        }

        private void SelectType()
        {
            switch (Value.GetType().ToString())
            {
                case "LolTCGCommon.Cards.ChampionCard":
                    typeComboBox.SelectedItem = CHAMPION;
                    break;
                case "LolTCGCommon.Cards.MinionCard":
                    typeComboBox.SelectedItem = MINION;
                    break;
                case "LolTCGCommon.Cards.StructureCard":
                    typeComboBox.SelectedItem = STRUCTURE;
                    break;
                case "LolTCGCommon.Cards.LeaderCard":
                    typeComboBox.SelectedItem = LEADER;
                    break;               
                default:
                    throw new Exception("Unexpected value in type combobox");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancelButton.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void SaveItem()
        {
            Value.Name = nameTextBox.Text;
            if (newValue)
            {
                Controllers.Instance.CardsController.AddNew(Value);
                Visible = false;
            }
            else
            {
                Controllers.Instance.CardsController.InvokeChange();
            }
        }
    }
}
