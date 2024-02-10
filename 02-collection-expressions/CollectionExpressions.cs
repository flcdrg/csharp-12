using System.Linq;

namespace _02_collection_expressions;

// https://learn.microsoft.com/dotnet/csharp/language-reference/operators/collection-expressions?WT.mc_id=DOP-MVP-5001655

public class TraditionalCollections
{
    private int[] numbers = new int[] { 1, 2, 3, 4, 5 };
    private List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };

    private void Thing()
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(5);
        
        Array.Sort<string>(new string[] { "a", "b", "c" });
    }
}

public class CollectionExpressions
{
    private int[] numbers = [ 1, 2, 3, 4, 5 ];

    private List<int> numbersList = [ 1, 2, 3, 4, 5 ];

    private void Thing()
    {
        string[] stuff = [ "a", "b", "c" ];

        // Not this
        //var otherStuff = [ "a", "b", "c"];

        IEnumerable<int> numbers = [ 1, 2, 3, 4, 5 ];
        numbers.Average();

        var average = ((IEnumerable<int>) [ 1, 2, 3, 4, 5 ]).Average();

        Array.Sort<string>(["a", "b", "c"]);
    }
}
