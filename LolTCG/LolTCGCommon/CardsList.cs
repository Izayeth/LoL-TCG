using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using LolTCGCommon.Cards;

namespace LolTCGCommon
{
    [Serializable]
    public class CardsList
    {
        [XmlArray]
        [XmlArrayItem("Card")]
        public List<Card> List { get; set; } = new List<Card>();
    }
}
