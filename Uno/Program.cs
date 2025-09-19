using System.Runtime.InteropServices;

namespace Uno;

public class Program
{
    public static void Main(string[] args)
    {
        var blueReverse = new Card() { Type = CardType.Reverse, Color = Color.Blue };

        var wild = new Card() { Type = CardType.Wild };
        System.Console.WriteLine(Card.PlaysOn(blueReverse, wild));
        System.Console.WriteLine(blueReverse.Type);
        System.Console.WriteLine(wild.Type);
    }
}
