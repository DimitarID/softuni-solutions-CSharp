string product = Console.ReadLine();
string day = Console.ReadLine();
double qty = double.Parse(Console.ReadLine());

if (product == "banana")
{
    if (day == "Monday" ||  day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
    {
        double output = qty * 2.50;
        Console.WriteLine($"{output:f2}");
    }
    else if (day == "Saturday" || day == "Sunday")
    {
        double output = qty * 2.70;
        Console.WriteLine($"{output:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}

else if (product == "apple")
{
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
    {
        double output = qty * 1.20;
        Console.WriteLine($"{output:f2}");
    }
    else if (day == "Saturday" || day == "Sunday")
    {
        double output = qty * 1.25;
        Console.WriteLine($"{output:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}

else if (product == "orange")
{
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
    {
        double output = qty * 0.85;
        Console.WriteLine($"{output:f2}");
    }
    else if (day == "Saturday" || day == "Sunday")
    {
        double output = qty * 0.90;
        Console.WriteLine($"{output:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}

else if (product == "grapefruit")
{
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
    {
        double output = qty * 1.45;
        Console.WriteLine($"{output:f2}");
    }
    else if (day == "Saturday" || day == "Sunday")
    {
        double output = qty * 1.60;
        Console.WriteLine($"{output:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}

else if (product == "kiwi")
{
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
    {
        double output = qty * 2.70;
        Console.WriteLine($"{output:f2}");
    }
    else if (day == "Saturday" || day == "Sunday")
    {
        double output = qty * 3.00;
        Console.WriteLine($"{output:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}

else if (product == "pineapple")
{
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
    {
        double output = qty * 5.50;
        Console.WriteLine($"{output:f2}");
    }
    else if (day == "Saturday" || day == "Sunday")
    {
        double output = qty * 5.60;
        Console.WriteLine($"{output:f2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}

else if (product == "grapes")
{
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
    {
        double output = qty * 3.85;
        Console.WriteLine($"{output:f2}");
    }
    else if (day == "Saturday" || day == "Sunday")
    {
        double output = qty * 4.20;
        Console.WriteLine($"{output:f2}");
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