using System.Runtime.InteropServices.ComTypes;

namespace _06_alias;

// https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-12.0/using-alias-types?WT.mc_id=DOP-MVP-5001655

using S = System.String;
using P = Tuple<string, string, int>;

public class Aliases
{
    public void Thing()
    {
        S s = "Hello";

        P p = new("Hello", "World", 42);
    }
}
