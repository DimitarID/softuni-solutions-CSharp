double budget = double.Parse(Console.ReadLine());
double humans = double.Parse(Console.ReadLine());
double clothesSinglePrice = double.Parse(Console.ReadLine());

double decor = 0.1 * budget;
double clothesAll = humans * clothesSinglePrice;

if (humans  > 150)
{
    clothesAll = clothesAll * 0.9;
}

double allЕxpense = decor + clothesAll;

if (budget < allЕxpense)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {allЕxpense - budget:f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - allЕxpense:f2} leva left.");
}