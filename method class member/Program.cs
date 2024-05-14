using System.Security.Cryptography;

class Person
{
    public string? name;
    public int age;

    public void display()
    {
        System.Console.WriteLine($"name = {name}  age = {age}");
    }

    public void set_value(string s, int num)
    {
        name = s;
        age = num;
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new();
        Person p2 = new();
        Person p3=new();
    

        p1.name = "nabil";
        p2.name = "nahid";
        p1.age = 26;
        p2.age = 22;
        p3.set_value("nafiz", 12);

        System.Console.WriteLine($"name of p1 = {p1.name}");
        p2.display();
        p3.display();
    }
}