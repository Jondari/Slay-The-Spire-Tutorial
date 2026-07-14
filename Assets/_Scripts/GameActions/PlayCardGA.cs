public class PlayCardGA : GameAction
{
    public Card Card {  get; set; }
    public PlayCardGA(Card card)
    {
        this.Card = card;
    }
}
