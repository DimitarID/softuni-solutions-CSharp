string product = Console.ReadLine();
string city = Console.ReadLine();
double qty = double.Parse(Console.ReadLine());

double price = 0;

if (product == "coffee")
{
    if (city == "Sofia")
    {
        price = 0.5 * qty;
    }
    else if (city == "Plovdiv")
    {
        price = 0.4 * qty;
    }
    else if (city == "Varna")
    {
        price = 0.45 * qty;
    }
}

else if (product == "water")
{
    if (city == "Sofia")
    {
        price = 0.8 * qty;
    }
    else
    {
        price = 0.7 * qty;
    }
}

else if (product == "beer")
{
    if (city == "Sofia")
    {
        price = 1.2 * qty;
    }
    else if (city == "Plovdiv")
    {
        price = 1.15 * qty;
    }
    else if (city == "Varna")
    {
        price = 1.10 * qty;
    }
}

else if (product == "sweets")
{
    if (city == "Sofia")
    {
        price = 1.45 * qty;
    }
    else if (city == "Plovdiv")
    {
        price = 1.3 * qty;
    }
    else if (city == "Varna")
    {
        price = 1.35 * qty;
    }
}

else if (product == "peanuts")
{
    if (city == "Sofia")
    {
        price = 1.6 * qty;
    }
    else if (city == "Plovdiv")
    {
        price = 1.5 * qty;
    }
    else if (city == "Varna")
    {
        price = 1.55 * qty;
    }
}

Console.WriteLine(price);