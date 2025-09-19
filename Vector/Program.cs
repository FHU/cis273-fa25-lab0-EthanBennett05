using System.Numerics;
using System.Runtime.Intrinsics;

namespace Vector;

public class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector() { X = 4.0, Y = 3.0 };
        Vector v2 = new Vector() { X = 5.0, Y = 10.0 };
        System.Console.WriteLine(v1.AngleBetween(v2));
    }
}

