namespace LolTCGCommon.Cards
{
    public abstract class CreatureCard : SummonableCard
    {
        public int Attack { get; set; }
        public int Range { get; set; }
        public bool CanAttack { get; set; } = true;
        public int MaxInDeck { get; set; }
        public bool Unique { get; set; }
    }
}
