using System.Security.Cryptography.X509Certificates;

namespace Uno;

public enum CardType
{
    Number, Wild, Draw2, WildDraw4, Skip, Reverse
}

public enum Color
{
    Red, Yellow, Blue, Green, Wild
}

public class Card
{
    public CardType Type { get; set; }
    public Color Color { get; set; }
    public int? Number { get; set; }

    public static bool PlaysOn(Card card1, Card card2)
    {
        return (
        card1.Color == card2.Color ||
        card1.Number == card2.Number||
        card1.Type == CardType.Wild ||
        card1.Type == CardType.WildDraw4||
        (card1.Type == CardType.Reverse && card2.Type == CardType.Reverse) ||
        (card1.Type == CardType.Skip && card2.Type == CardType.Skip) ||
        (card1.Type == CardType.Draw2 && card2.Type == CardType.Draw2));
    }
    
    public override string ToString()
    {
        if (Color == Color.Wild)
        {
            return $"{Type}";
        }
        else if (Number == null)
        {
            return $"{Color} {Type}";
        }
        else
        {
            return $"{Color} {Number}";
        }
    }

}