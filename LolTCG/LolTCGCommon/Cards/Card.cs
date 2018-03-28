using System;
using System.Xml.Serialization;

namespace LolTCGCommon.Cards
{
    [Serializable]
    [XmlInclude(typeof(ChampionCard))]
    [XmlInclude(typeof(MinionCard))]
    [XmlInclude(typeof(StructureCard))]
    [XmlInclude(typeof(LeaderCard))]
    [XmlRoot("Card")]
    public abstract class Card 
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int ManaCost { get; set; }
        public Guid Guid { get; set; }
    }
}
