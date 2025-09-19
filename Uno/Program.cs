using System.Runtime.InteropServices;

namespace Uno;

public class Program
{
    public static void Main(string[] args)
    {
        Card card = new Card();
        card.Type = CardType.Number;
        card.Color = Color.Red;
        card.Number = 3;

        Console.WriteLine(card.ToString());

        var red5 = new Card() { Color = Color.Red, Number = 5, Type = CardType.Number };
        var red9 = new Card() { Color = Color.Red, Number = 9, Type = CardType.Number };
        var blue9 = new Card() { Color = Color.Blue, Number = 9, Type = CardType.Number };
        var yellow2 = new Card() { Color = Color.Yellow, Number = 2, Type = CardType.Number };
        var green1 = new Card() { Color = Color.Green, Number = 1, Type = CardType.Number };
        var yellow1 = new Card() { Color = Color.Yellow, Number = 1, Type = CardType.Number };
        var blueReverse = new Card() { Type = CardType.Reverse, Color = Color.Blue };
        var greenReverse = new Card() { Type = CardType.Reverse, Color = Color.Green };
        var redSkip = new Card() { Type = CardType.Skip, Color = Color.Red };
        var blueSkip = new Card() { Type = CardType.Skip, Color = Color.Blue };
        var redDraw2 = new Card() { Type = CardType.Draw2, Color = Color.Red };
        var greenDraw2 = new Card() { Type = CardType.Draw2, Color = Color.Green };
        var wild = new Card() { Type = CardType.Wild };
        var wilddraw4 = new Card() { Type = CardType.WildDraw4 };

        Card[] cards1 = { red5, red9, blue9, yellow1 };
        Card[] cards2 = { blue9, blueSkip };
        Card[] cards3 = { yellow1, blue9, red5 };
        var player1 = new Player();
        var player2 = new Player();
        var player3 = new Player();
        player1.Hand.AddRange(cards1);
        player2.Hand.AddRange(cards2);
        player3.Hand.AddRange(cards3);

        Console.WriteLine(player1.HasPlayableCard(new Card() { Color = Color.Green, Type = CardType.Draw2 }));
        Console.WriteLine(player2.HasPlayableCard(new Card() { Color = Color.Green, Type = CardType.Draw2 }));
        System.Console.WriteLine(blueSkip.Type);

    }
}
