class Test
{
    public static void Main(string[] args)
    {
        string[] names = new string[3];
        names[0] = "nabil";
        names[1] = "nahid";
        names[2] = "nafiz";

        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine($"{names[i]}");
        }
        System.Console.WriteLine($"\n");

        foreach (string i in names)
        {
            System.Console.WriteLine($"{i}");
        }

        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;

        foreach (int i in num)
        {
            sum += i;
        }

        System.Console.WriteLine($"{sum}");

         // jagged array

        int[][] n = new int[4][];
        n[0] = new int[3];
        n[0][0] = 10;
        n[0][1] = 20;
        n[0][2] = 30;

        n[1] = [1, 2, 3, 4]; // this is a different way

        n[2] = new int[1];
        n[2][0] = 75;

        n[3] = [5, 15, 25, 35];

        // for (int i = 0; i < 4; i++)
        // {
        //     for (int j = 0; j < n[i].Length; j++)
        //     {
        //         System.Console.WriteLine($"{n[i][j]}");
        //     }

        //     System.Console.WriteLine($"new line");
        // }


        foreach (var row in n)
        {
            foreach (var item in row)
            {
                System.Console.WriteLine($"{item }");
            }

            System.Console.WriteLine();
        }

    }
}