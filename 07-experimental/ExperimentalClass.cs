using System.Diagnostics.CodeAnalysis;

namespace _07_experimental;

// https://learn.microsoft.com/dotnet/csharp/language-reference/attributes/general?WT.mc_id=DOP-MVP-5001655#experimental-attribute

[Experimental("DAVID01")]
public class ExperimentalClass
{
    public void Thing()
    {
        //
    }
}


public class Program
{
    public static void Main()
    {
        ExperimentalClass e = new();
        e.Thing();
    }
}