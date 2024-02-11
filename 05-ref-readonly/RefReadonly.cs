namespace _05_ref_readonly;

// https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/method-parameters?WT.mc_id=DOP-MVP-5001655#ref-readonly-modifier

public class RefReadonly
{
    public static void ByRef(ref Point p)
    {
        p = new Point(2, 3);

        Console.WriteLine(p);
    }

    public static void ByRefReadonly(ref readonly Point p)
    {
        //p = new Point(2, 3);
        Console.WriteLine(p);

    }
    public static void Main()
    {
        Point p = new Point(1, 1);
        ByRef(ref p);
        Console.WriteLine(p);

        ByRefReadonly(ref p);
        Console.WriteLine(p);
    }
}

public record Point(int X, int Y);
