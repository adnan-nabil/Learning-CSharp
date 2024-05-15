class Person
{
    private string? name;
    private int age;
    private string? passport_number;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public int agee
    {
        get
        {
            return age;
        }

        set
        {
            if (value > 21)
            {
                age = value;
            }
        }
    }

    public string p_number
    {
        get
        {
            return passport_number;
        }

        set
        {
            if (value.Length == 10)
            {
                passport_number = value;
            }
        }
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new();
        Person p2 = new();


        p1.Name = "nabil";
        p1.agee=26;
        p1.p_number="9876543227";

        p2.Name="nahid";
        p2.agee=22;
        p2.p_number="9876543456";


        System.Console.WriteLine($"p1 name ={p1.Name}, age = {p1.agee}, passport = {p1.p_number}");
        System.Console.WriteLine($"p2 name ={p2.Name}, age = {p2.agee}, passport = {p2.p_number}");
    }
}