string city = Console.ReadLine();
double sum = double.Parse(Console.ReadLine());

double commission = 0;

if (city == "Sofia")
{
    if (sum >= 0 && sum <= 500)
    {
        commission = sum * 0.05;
        Console.WriteLine($"{commission:f2}");
    }
    else if (sum > 500 && sum <= 1000)
    {
        commission = sum * 0.07;
        Console.WriteLine($"{commission:f2}");
    }
    else if (sum > 1000 && sum <= 10000)
    {
        commission = sum * 0.08;
        Console.WriteLine($"{commission:f2}");
    }
    else if (sum > 10000)
    {
        commission = sum * 0.12;
        Console.WriteLine($"{commission:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}

else if (city == "Varna")
{
    if (sum >= 0 && sum <= 500)
    {
        commission = sum * 0.045;
        Console.WriteLine($"{commission:f2}");
    }
    else if (sum > 500 && sum <= 1000)
    {
        commission = sum * 0.075;
        Console.WriteLine($"{commission:f2}");
    }
    else if (sum > 1000 && sum <= 10000)
    {
        commission = sum * 0.10;
        Console.WriteLine($"{commission:f2}");
    }
    else if (sum > 10000)
    {
        commission = sum * 0.13;
        Console.WriteLine($"{commission:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}

else if (city == "Plovdiv")
{
    if (sum >= 0 && sum <= 500)
    {
        commission = sum * 0.055;
        Console.WriteLine($"{commission:f2}");
    }
    else if (sum > 500 && sum <= 1000)
    {
        commission = sum * 0.08;
        Console.WriteLine($"{commission:f2}");
    }
    else if (sum > 1000 && sum <= 10000)
    {
        commission = sum * 0.12;
        Console.WriteLine($"{commission:f2}");
    }
    else if (sum > 10000)
    {
        commission = sum * 0.145;
        Console.WriteLine($"{commission:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}

else
{
    Console.WriteLine("error");
}