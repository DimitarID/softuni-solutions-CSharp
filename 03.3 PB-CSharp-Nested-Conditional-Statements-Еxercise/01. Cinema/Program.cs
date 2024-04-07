string projection = Console.ReadLine();
int r = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int seats = r * c;
double income = 0;

if (projection == "Premiere")
{
    income = seats * 12.00;
}
else if (projection == "Normal")
{
    income = seats * 7.50;
}
else if (projection == "Discount")
{
    income = seats * 5.00;
}

Console.WriteLine($"{income:f2} leva");