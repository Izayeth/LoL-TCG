using System;
using System.Windows.Forms;
using LolTCGCommon;
using LolTCGCommon.Cards;

namespace LolTCGEditor
{
    public partial class CardsList : UserControl
    {
        public event Action<Card> OnSelectedCard;

        public CardsList()
        {
            InitializeComponent();
            Controllers.Instance.CardsController.OnCardsChanged += 
                CardsController_OnCardsChanged;
        }

        private void CardsController_OnCardsChanged()
        {
            cardsListBox.Items.Clear();
            foreach (var card in Controllers.Instance.CardsController.Cards.List)
            {
                cardsListBox.Items.Add(card);
            }
        }

        private void cardsListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cardsListBox.SelectedItem != null)
                OnSelectedCard?.Invoke((Card)cardsListBox.SelectedItem);
        }
    }
}
