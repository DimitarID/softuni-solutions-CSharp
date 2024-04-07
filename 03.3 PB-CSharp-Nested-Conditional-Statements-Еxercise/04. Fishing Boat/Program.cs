int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermans  = int.Parse(Console.ReadLine());

double boatRent = 0;

if (season == "Spring")
{
    boatRent = 3000;

    if (fishermans <= 6)
    {
        boatRent = boatRent * 0.9;
    }
    else if (fishermans > 6 && fishermans <= 11)
    {
        boatRent = boatRent * 0.85;
    }
    else if (fishermans > 11)
    {
        boatRent = boatRent * 0.75;
    }
}
else if (season == "Summer" || season == "Autumn")
{
    boatRent = 4200;

    if (fishermans <= 6)
    {
        boatRent = boatRent * 0.9;
    }
    else if (fishermans > 6 && fishermans <= 11)
    {
        boatRent = boatRent * 0.85;
    }
    else if (fishermans > 11)
    {
        boatRent = boatRent * 0.75;
    }
}
else if (season == "Winter")
{
    boatRent = 2600;

    if (fishermans <= 6)
    {
        boatRent = boatRent * 0.9;
    }
    else if (fishermans > 6 && fishermans <= 11)
    {
        boatRent = boatRent * 0.85;
    }
    else if (fishermans > 11)
    {
        boatRent = boatRent * 0.75;
    }
}

if (fishermans % 2 == 0 && season != "Autumn")
{
    boatRent = boatRent * 0.95;
}

if (budget < boatRent)
{
    double output = boatRent - budget;
    Console.WriteLine($"Not enough money! You need {output:f2} leva.");
}
else
{
    double output = budget - boatRent;
    Console.WriteLine($"Yes! You have {output:f2} leva left.");
}