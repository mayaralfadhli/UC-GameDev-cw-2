internal class Program
{
    private static void Main(string[] args)
    {
        string heroName = "Ghost";
        int heroPower = 85;
        string villainName = "Price";
        int villainPower = 75;
        if (heroPower > villainPower)
        {
            Console.WriteLine("villain damged");
        }

        else if (heroPower == villainPower)
        {
            Console.WriteLine("oh..");
        }
        else if (heroPower < villainPower)
        {
            Console.WriteLine("I am damged");
        }
        else
        {
            Console.WriteLine("....");
        }
    
    }