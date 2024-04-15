{
    int age = int.Parse(Console.ReadLine());
    double priceOfWashingMachine = double.Parse(Console.ReadLine());
    double priceOfToys = double.Parse(Console.ReadLine());

    int moneyStart = 10;
    int moneySaved = 0;
    int toys = 0;
    int brother = 0;
    double allMoney = 0.0d;

    for (int i = 1; i <= age; i++)
    {
        if (i % 2 == 0 && i != 1)
        {
            moneySaved = moneySaved + moneyStart;
            moneyStart += 10;
            brother++;
        }
        else if (i % 2 != 0 || i == 1)
        {
            toys++;
        }
    }
    allMoney = toys * priceOfToys + moneySaved - brother;
    if (allMoney >= priceOfWashingMachine)
    {
        allMoney = allMoney - priceOfWashingMachine;
        Console.WriteLine($"Yes! {allMoney:f2}");
    }
    else
    {
        allMoney = Math.Abs(allMoney - priceOfWashingMachine);
        Console.WriteLine($"No! {allMoney:f2}");
    }
}