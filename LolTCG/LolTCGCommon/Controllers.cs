namespace LolTCGCommon
{
    public class Controllers
    {
        public static Controllers Instance = new Controllers();
        public CardsController CardsController { get; set; }

        public Controllers()
        {
            CardsController = new CardsController();
        }
    }
}
