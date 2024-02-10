namespace _01_primary_constructors;

public class TraditionalClass
{
    private string Name { get; set; }

    public TraditionalClass(string name)
    {
        Name = name;
    }
}

public class PrimaryConstructorClass(string name)
{
    private string Name { get; init; } = name;

    private string Name2 => name;

    private string otherThing;

    public void Thing()
    {
        Console.WriteLine(name);
    }
}

public struct PrimaryConstructorStruct(string name)
{
    private string Name { get; init; } = name;

    private string Name2 => name;

    private string otherThing;
}
