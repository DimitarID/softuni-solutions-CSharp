{
    int N = int.Parse(Console.ReadLine());
    int firsNumber = 1;

    while (N >= firsNumber)
    {
        Console.WriteLine(firsNumber);
        firsNumber = firsNumber * 2 + 1;
    }
}