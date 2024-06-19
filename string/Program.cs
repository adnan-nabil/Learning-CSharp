class Test
{
    public static void Main(string[] args)
    {
        string s = "I am Nabil";
        System.Console.WriteLine($"{s}");
        System.Console.WriteLine($"length = {s.Length}");
        bool flag = string.IsNullOrEmpty(s);
        System.Console.WriteLine($"{flag}");
        System.Console.WriteLine($"{s.ToUpper()}");
        System.Console.WriteLine($"{s.ToLower()}");
        System.Console.WriteLine($"{s.Trim()}"); // string er top and bottom space trim kore. vitore trim korena.
        System.Console.WriteLine($"{s.Substring(5)}");
        System.Console.WriteLine($"{s.Substring(5,2)}");// 5 theke shuru kore 2 ta character
    }
}
