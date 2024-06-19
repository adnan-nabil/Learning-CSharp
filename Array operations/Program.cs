using System.Runtime.CompilerServices;

class Test
{

    // sum with params keyword
    public static int sum_with_params(params int[] number)
    {
        int sum = 0;
        foreach(var i in number)
        {
            sum += i;
        }

        return sum;
    }




    public static void Main(string[] args)

    {
        try
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write($"value of {i + 1} : ");
                a[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"before sort: ");
            foreach (var item in a)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine($"");

            System.Console.WriteLine($"max value : {a.Max()}");
            System.Console.WriteLine($"min value : {a.Min()}");
            System.Console.WriteLine($"average value : {a.Average()}");
            
            Array.Sort(a);
            System.Console.WriteLine($"after sort: ");
            foreach (var item in a)
            {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine($"");

        }
        catch (Exception e)
        {
            System.Console.WriteLine($"{e.Message}");
        }

        // params keyword
        System.Console.WriteLine($"sum = {sum_with_params(10,20)}");
        System.Console.WriteLine($"sum = {sum_with_params(10,20,30)}");
        System.Console.WriteLine($"sum = {sum_with_params(10,20,30,40)}");

    }




}
