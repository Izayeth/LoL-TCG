using LolTCGCommon;
using LolTCGCommon.Cards;
using System;
using System.Windows.Forms;

namespace LolTCGEditor
{
    public partial class CardsEditor : UserControl
    {
        public CardsEditor()
        {
            InitializeComponent();
            cardsList1.OnSelectedCard += CardsList1_OnSelectedCard;
        }

        private void CardsList1_OnSelectedCard(Card obj)
        {
            cardEditor1.Edit(false, obj);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TypeSelector typeSelector = new TypeSelector();
            if(typeSelector.ShowDialog() == DialogResult.OK)
            {
                cardEditor1.Edit(true,typeSelector.Value);
            }
        }
    }
}
