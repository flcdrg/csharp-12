namespace _04_optional_params_lambda;

// https://learn.microsoft.com/dotnet/csharp/language-reference/operators/lambda-expressions?WT.mc_id=DOP-MVP-5001655#input-parameters-of-a-lambda-expression

public class LambdaParameters
{

    public static void Main()
    {
        // Default parameters
        var IncrementBy = (int source, int increment = 1) => source + increment;

        Console.WriteLine(IncrementBy(5)); // 6
        Console.WriteLine(IncrementBy(5, 2)); // 7
    }
}
