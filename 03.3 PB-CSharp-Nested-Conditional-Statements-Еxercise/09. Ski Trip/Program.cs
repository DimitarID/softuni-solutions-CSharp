int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string opinion = Console.ReadLine();

int nights = days - 1;
double priceNights = 0;
double totalPrice = 0;


if (roomType == "room for one person")
{
    priceNights = 18;
    totalPrice = nights * priceNights;
}

else if (roomType == "apartment")
{
    priceNights = 25;
    totalPrice = nights * priceNights;
    if (days < 10)
    {
        totalPrice = totalPrice - 0.30 * totalPrice;
    }
    else if (days >= 10 && days <= 15)
    {
        totalPrice = totalPrice - 0.35 * totalPrice;
    }
    else if (days > 15)
    {
        totalPrice = totalPrice - 0.50 * totalPrice;
    }

}
else if (roomType == "president apartment")
{
    priceNights = 35;
    totalPrice = nights * priceNights;
    if (days < 10)
    {
        totalPrice = totalPrice - 0.10 * totalPrice;
    }
    else if (days >= 10 && days <= 15)
    {
        totalPrice = totalPrice - 0.15 * totalPrice;
    }
    else if (days > 15)
    {
        totalPrice = totalPrice - 0.20 * totalPrice;
    }
}
if (opinion == "positive")
{
    totalPrice = totalPrice + 0.25 * totalPrice;
}
else if (opinion == "negative")
{
    totalPrice = totalPrice - 0.10 * totalPrice;
}

Console.WriteLine($"{totalPrice:F2}");