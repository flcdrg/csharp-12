using System.Runtime.InteropServices.ComTypes;

namespace _05_alias;

// https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-12.0/using-alias-types?WT.mc_id=DOP-MVP-5001655

using S = System.String;

#region Type Aliases
using P = Tuple<string, string, int>;
using C = char[];

public class Aliases
{
    public void Thing()
    {
        S s = "Hello";

        C chars = s.ToCharArray();

        P p = new("Hello", "World", 42);
    }
} 
#endregion
