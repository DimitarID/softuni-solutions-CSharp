string flower = Console.ReadLine();
int qty = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double flowerPrice = 0.0;

if (flower == "Roses")
{
    flowerPrice = qty * 5;
    if (qty > 80)
    {
        flowerPrice = flowerPrice * 0.9;
    }
}

else if (flower == "Dahlias")
{
    flowerPrice = qty * 3.80;
    if (qty > 90)
    {
        flowerPrice = flowerPrice * 0.85;
    }
}

else if (flower == "Tulips")
{
    flowerPrice = qty * 2.80;
    if (qty > 80)
    {
        flowerPrice = flowerPrice * 0.85;
    }
}

else if (flower == "Narcissus")
{
    flowerPrice = qty * 3.00;
    if (qty < 120)
    {
        flowerPrice = flowerPrice * 1.15;
    }
}

else if (flower == "Gladiolus")
{
    flowerPrice = qty * 2.50;
    if (qty < 80)
    {
        flowerPrice = flowerPrice * 1.20;
    }
}

if (flowerPrice > budget)
{
    double output = flowerPrice - budget;  
    Console.WriteLine($"Not enough money, you need {output:f2} leva more.");
}
else if (flowerPrice <= budget)
{
    double output = budget - flowerPrice;
    Console.WriteLine($"Hey, you have a great garden with {qty} {flower} and {output:f2} leva left.");
}