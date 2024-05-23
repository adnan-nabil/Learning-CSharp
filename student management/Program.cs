using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

class Student
{
    public string name
    {
        get;
        private set;
    }

    public string roll_number
    {
        get;
        private set;
    }

    public DateTime date_of_birth
    {
        get;
        private set;
    }

    public Student(string name, DateTime date_of_birth, string roll_number)
    {

        Data_validation(name, date_of_birth, roll_number);

        this.name = name;

        this.date_of_birth = date_of_birth;

        this.roll_number = roll_number;
    }

    public static void Data_validation(string name, DateTime date_of_birth, string roll_number)
    {
        if (name == "" || name == null)
        {
            throw new Exception("name can not be empty"); // argument exception ar exception almost similar kaj e kortese
        }

        // if (date_of_birth == default)
        // {
        //     throw new ArgumentException("date can not be null");
        // }

        if (date_of_birth > DateTime.Now)
        {
            throw new ArgumentException("date should be appropriate");
        }

        if (string.IsNullOrWhiteSpace(roll_number))
        {
            throw new ArgumentException("roll number is must");
        }

    }

    private int CalculateAge()
    {

        int age = DateTime.Now.Year - date_of_birth.Year;
        return age;
    }

    public int Age
    {
        get
        {
            return CalculateAge();
        }

    }

    public void displayinfo()
    {
        System.Console.WriteLine($"name: {name}");
        System.Console.WriteLine($"date of birth: {date_of_birth.ToShortDateString()}");
        System.Console.WriteLine($"roll: {roll_number}");
        System.Console.WriteLine($"age: {Age}");
    }
}


class Start
{
    public static void Main(string[] args)
    {
        try
        {
            Student s1 = new("nabil", new DateTime(1998, 4, 14), "2018331553");
            Student s2 = new("nahid", new DateTime(2002, 5, 7), "2018331554");

            s1.displayinfo();
            System.Console.WriteLine($"\n");
            s2.displayinfo();
            System.Console.WriteLine($"\n");
            System.Console.WriteLine($"{s2.name}");


        }
        catch (Exception e)
        {
            System.Console.WriteLine($"error: {e.Message}");
        }




    }
}
