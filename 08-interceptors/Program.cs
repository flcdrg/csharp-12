namespace _08_interceptors;

class Program
{
    static void Main()
    {
        var c = new C();
        c.InterceptableMethod(1);
        c.InterceptableMethod(1);
        c.InterceptableMethod(2);
        c.InterceptableMethod(1);
    }
}