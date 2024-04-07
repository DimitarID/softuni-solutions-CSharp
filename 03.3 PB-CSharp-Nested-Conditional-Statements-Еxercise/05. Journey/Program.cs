double budget = double.Parse(Console.ReadLine());
string season  = Console.ReadLine();

double spendMoney = 0;
string accommodation = "";
string destination = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        accommodation = "Camp";
        spendMoney = budget * 0.3;
    }
    else if (season == "winter")
    {
        accommodation = "Hotel";
        spendMoney = budget * 0.7;
    }
}
else if (budget > 100 && budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        accommodation = "Camp";
        spendMoney = budget * 0.4;
    }
    else if (season == "winter")
    {
        accommodation = "Hotel";
        spendMoney = budget * 0.8;
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    accommodation = "Hotel";
    spendMoney = budget * 0.9;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{accommodation} - {spendMoney:f2}");