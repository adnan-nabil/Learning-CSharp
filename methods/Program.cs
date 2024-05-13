

class method_ops
{

    public static int Add(int n, int m)
    {
        return n + m;
    }

    public static void message(string t)
    {
        Console.WriteLine(t);
    }
    public static void Main(string[] args)
    {
        message("hello");
        int result = Add(10, 20);
        Console.WriteLine($"ans is = {result}");
        message("goodbye");

    }
}
