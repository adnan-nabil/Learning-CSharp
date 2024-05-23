class Person
{
    public int age;
    public string? name;

    public Person(string s, int n)
    {
        name = s;
        age = n;
    }

    public void display()
    {
        System.Console.WriteLine($"name = {name} ; age = {age}");
    }
}



class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new("nabil", 26);
        p1.display();

        Person p2 = p1;
        p2.display();

        p2.name = "nahid";
        p2.age = 22;

        p1.display();
        p2.display();


        
        
    }
}