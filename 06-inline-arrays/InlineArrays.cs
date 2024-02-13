namespace _06_inline_arrays;

// https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/struct?WT.mc_id=DOP-MVP-5001655#inline-arrays

// An inline array is a structure that contains a contiguous block of N elements of the same type. 
// It's a safe-code equivalent of the fixed buffer declaration available only in unsafe code

// A struct with an inline buffer should provide performance characteristics similar to an 
// unsafe fixed size buffer

[System.Runtime.CompilerServices.InlineArray(10)]
public struct InlineArray
{
    public int Thing;
}

public class UsingInlineArrays
{
    public void DoThing()
    {
        var buffer = new InlineArray();

        for (int i = 0; i < 10; i++)
        {
            buffer[i] = i;
        }
    }
}