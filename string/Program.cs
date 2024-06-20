class Test
{
    public static void Main(string[] args)
    {
        string s = "I am Nabil";
        // System.Console.WriteLine($"{s}");
        // System.Console.WriteLine($"length = {s.Length}");
        // bool flag = string.IsNullOrEmpty(s);
        // System.Console.WriteLine($"{flag}");
        // System.Console.WriteLine($"{s.ToUpper()}");
        // System.Console.WriteLine($"{s.ToLower()}");
        // System.Console.WriteLine($"{s.Trim()}"); // string er top and bottom space trim kore. vitore trim korena.
        // System.Console.WriteLine($"{s.Substring(5)}");
        // System.Console.WriteLine($"{s.Substring(5,2)}");// 5 theke shuru kore next 2 ta character
        // System.Console.WriteLine($"{s.Insert(0, "hi! ")}");
        // System.Console.WriteLine($"{s.Insert(10, ".")}");
        // System.Console.WriteLine($"{s.Remove(4)}"); // 4 number index er pore shobai removed
        // System.Console.WriteLine($"{s.Replace("nabil", "nahid")}");
        // System.Console.WriteLine($"{s.Contains("Nahid")}");

        // reverse : character array banay nite hobe age. then reverse 
        char[] s1 = s.ToCharArray();
        Array.Reverse(s1);
        string s2 = new string(s1);
        System.Console.WriteLine($"{s2}");

        
    }
}
