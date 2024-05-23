using System.Data.Common;

class Test
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine($"starting");

        try
        {
            int num1 = Convert.ToInt32(System.Console.ReadLine());
            string? num2 = System.Console.ReadLine();
            int num3 = Convert.ToInt32(num2);
            string? name = System.Console.ReadLine();

            int result = num1 / num3;
            System.Console.WriteLine($"result = {result}");
            System.Console.WriteLine($"name = {name}");
        }
       
        catch(OverflowException)
        {
            System.Console.WriteLine($" value too large");
        }
        catch(FormatException)
        {
            System.Console.WriteLine($"value should be int32 format");
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"{e.Message}");
        }

        finally
        {
            System.Console.WriteLine($"Closing");
        }



    }
}