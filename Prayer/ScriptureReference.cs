using System.Reflection.Metadata;

namespace Prayer;

public record class ScriptureRefrence
{
    public string Book { get; set; } = "";
    public int Chapter { get; set; }
    public int StartVerse { get; set; }
    public int EndVerse { get; set; }

    public override string ToString()
    {
        //Matthew 4:12-17
        if (StartVerse == EndVerse)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}