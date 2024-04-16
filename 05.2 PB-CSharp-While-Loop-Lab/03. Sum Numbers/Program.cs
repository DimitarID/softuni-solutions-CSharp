{
    int targetSum = int.Parse(Console.ReadLine());

    int currentSum = 0;
    int inputNumber;

    while (true)
    {
        inputNumber = int.Parse(Console.ReadLine());
        currentSum += inputNumber;

        if (currentSum >= targetSum)
            break;
    }

    Console.WriteLine($"{currentSum}");
}