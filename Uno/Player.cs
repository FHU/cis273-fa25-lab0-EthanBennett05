using System.Reflection.Metadata.Ecma335;
using System.Security;

namespace Uno;

public class Player
{
    public string Name { get; set; } = "";

    public List<Card> Hand { get; set; } = new List<Card>();


    public bool HasPlayableCard(Card card)
    {
        foreach (Card i in Hand)
        {
            if (Card.PlaysOn(i, card))
            {
                return true;
            }
        }
        return false;
    }

    public Card? GetFirstPlayableCard(Card card)
    {
        foreach (Card i in Hand)
        {
            if (Card.PlaysOn(card, i))
            {
                return i;
            }
        }
        return null;
    }


    public Color MostCommonColor()
    {
        int red = 0, blue = 0, yellow = 0, green = 0;
        foreach (Card card in Hand)
        {
            if (card.Color == Color.Red)
            {
                red += 1;
            }
            else if (card.Color == Color.Yellow)
            {
                yellow += 1;
            }
            else if (card.Color == Color.Green)
            {
                green += 1;
            }
            else if (card.Color == Color.Blue)
            {
                blue += 1;
            }

        }
        if (red > yellow && red > green && red > blue)
        {
            return Color.Red;
        }
        else if (yellow > red && yellow > green && yellow > blue)
        {
            return Color.Yellow;
        }
        else if (blue > yellow && blue > green && blue > red)
        {
            return Color.Blue;
        }
        else if (green > yellow && green > blue && green > red)
        {
            return Color.Green;
        }
        else
        {
            return Hand[0].Color;
        }
    }

}