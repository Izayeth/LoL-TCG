using LolTCGCommon.Cards;
using System;
using System.IO;
using System.Xml.Serialization;

namespace LolTCGCommon
{
    public class CardsController
    {
        public event Action OnCardsChanged;
        public CardsList Cards { get; set; } = new CardsList();

        public void SaveCardsToFile(string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(CardsList));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                ser.Serialize(fs, Cards);
            }
        }

        public void AddNew(Card card)
        {
            Cards.List.Add(card);
            InvokeChange();
        }

        public void LoadCardsFromFile(string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(CardsList));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                Cards = (CardsList)ser.Deserialize(fs);
                InvokeChange();
            }
        }

        public void InvokeChange()
        {
            OnCardsChanged?.Invoke();
        }
    }
}
