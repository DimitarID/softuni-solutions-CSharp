while (true)
{
    string destination = Console.ReadLine();

    if (destination == "End")
    {
        break;
    }

    double sum = 0;
    double budget = double.Parse(Console.ReadLine());

    while (budget > sum)
    {
        double sumInput = double.Parse(Console.ReadLine());
        sum += sumInput;
    }

    Console.WriteLine($"Going to {destination}!");
}