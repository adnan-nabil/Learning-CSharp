using System.Security.Cryptography;

class Person
{
    public string? name;
    public int age;
}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new();
        Person p2 = new();
    

        p1.name = "nabil";
        p2.name = "nahid";
        p1.age = 26;
        p2.age = 22;

        System.Console.WriteLine($"name of p1 = {p1.name}");
    }
}