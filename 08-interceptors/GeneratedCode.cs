using System.Runtime.CompilerServices;

namespace _08_interceptors;

// Code that would normally be generated, eg. by a source generator
static class D
{
    [InterceptsLocation("C:\\dev\\git\\csharp-12\\08-interceptors\\Program.cs", line: 8, character: 11)] // refers to the call at (L1, C1)
    public static void InterceptorMethod(this C c, int param)
    {
        Console.WriteLine($"interceptor {param}");
    }

    [InterceptsLocation("C:\\dev\\git\\csharp-12\\08-interceptors\\Program.cs", 9, character: 11)] // refers to the call at (L2, C2)
    [InterceptsLocation("C:\\dev\\git\\csharp-12\\08-interceptors\\Program.cs", line: 10, character: 11)] // refers to the call at (L3, C3)
    public static void OtherInterceptorMethod(this C c, int param)
    {
        Console.WriteLine($"other interceptor {param}");
    }
}