using System;

interface IStall
{
    void display(Stall stall);
}

class Stall : IStall
{
    private string StallName { get; set; }
    private int Cost { get; set; }
    private string OwnerName { get; set; }

    public Stall()
    {
        StallName = "Stall Name";
        Cost = 0;
        OwnerName = "Owner Name";
    }

    public Stall(string stallName, int cost, string ownerName)
    {
        StallName = stallName;
        Cost = cost;
        OwnerName = ownerName;
    }

    public void display(Stall stall)
    {
        Console.Write($"\n\nStall Name: {stall.StallName}\nCost: {stall.Cost}\nOwner Name: {stall.OwnerName}\n");
    }

}

class GoldStall : Stall
{
    private Stall stall { get; set; }
    private int TvSets { get; set; }

    public GoldStall()
    {
        stall = new Stall();
        TvSets = 0;
    }

    public GoldStall(Stall stall, int tvSets)
    {
        display(stall);
        TvSets = tvSets;
        Console.Write($"Number of TvSets: {TvSets}");
    }
}

class PremiumStall : Stall
{
    private int Projectors { get; set; }

    public PremiumStall()
    {
        Projectors = 0;
    }

    public PremiumStall(Stall stall, int projectors)
    {
        display(stall);
        Projectors = projectors;
        Console.Write($"Number of Projectors: {projectors}");
    }
}

class ExecutiveStall : Stall
{
    private int Screen { get; set; }

    public ExecutiveStall()
    {
        Screen = 0;
    }

    public ExecutiveStall(Stall stall, int screen)
    {
        display(stall);
        Screen = screen;
        Console.Write($"Number of Screens: {screen}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] input = new string[4];

        Console.Write("\n\nChoose stall type\n\n1-Gold Stall\n2-Premium Stall\n3-Executive stall\n\n");

        int choice = Convert.ToInt32(getInput());

        Console.Write("\n\nEnter Stall details in comma separated(Stall Name,Stall Cost,Owner Name,Number of Projectors)\n\n");

        string userInput = getInput();

        input = userInput.Split(",");

        Stall stall = new Stall(input[0], int.Parse(input[1]), input[2]);

        int lastInput = int.Parse(input[3]);

        switch (choice)
        {
            case 1:
                GoldStall goldStall = new GoldStall(stall, lastInput);
                break;
            case 2:
                PremiumStall premiumStall = new PremiumStall(stall, lastInput);
                break;
            case 3:
                ExecutiveStall executiveStall = new ExecutiveStall(stall, lastInput);
                break;
            default:
                return;

        }

    }

    static string getInput() => Console.ReadLine();
}
