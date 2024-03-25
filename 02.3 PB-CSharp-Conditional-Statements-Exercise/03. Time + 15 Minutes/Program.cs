int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int minutesAfter = minutes + 15;

if (minutesAfter >= 60)
{
    hours = hours + 1;
    if (hours > 23)
    {
        hours = 0;
    }
    minutes = minutesAfter - 60;

    if (minutes < 10)
    {
        Console.WriteLine($"{hours}:0{minutes}");
    }
    else
    {
        Console.WriteLine($"{hours}:{minutes}");
    }
}
else
{
    Console.WriteLine($"{hours}:{minutesAfter}");
}