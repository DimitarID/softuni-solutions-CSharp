
double packageWeight = double.Parse(Console.ReadLine());
string service = Console.ReadLine();
int distance = int.Parse(Console.ReadLine());

double finalPrice = 0;

if (service == "standard")
{
    if (packageWeight < 1)
    {
        finalPrice = distance * 0.03;
    }
    else if (packageWeight >= 1 && packageWeight <= 10)
    {
        finalPrice = distance * 0.05;
    }
    else if (packageWeight >= 11 && packageWeight <= 40)
    {
        finalPrice = distance * 0.10;
    }
    else if (packageWeight >= 41 && packageWeight <= 90)
    {
        finalPrice = distance * 0.15;
    }
    else if (packageWeight >= 91 && packageWeight <= 150)
    {
        finalPrice = distance * 0.20;
    }
}
else if (service == "express")
{
    if (packageWeight < 1)
    {
        finalPrice = distance * 0.03 + 0.03 * 0.8 * packageWeight * distance;
    }
    else if (packageWeight >= 1 && packageWeight <= 10)
    {
        finalPrice = distance * 0.05 + 0.05 * 0.4 * packageWeight * distance;
    }
    else if (packageWeight >= 11 && packageWeight <= 40)
    {
        finalPrice = distance * 0.10 + 0.10 * 0.05 * packageWeight * distance;
    }
    else if (packageWeight >= 41 && packageWeight <= 90)
    {
        finalPrice = distance * 0.15 + 0.15 * 0.02 * packageWeight * distance;
    }
    else if (packageWeight >= 91 && packageWeight <= 150)
    {
        finalPrice = distance * 0.20 + 0.20 * 0.01 * packageWeight * distance;
    }
}

Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:f3} kg. would cost {finalPrice:f2} lv.");