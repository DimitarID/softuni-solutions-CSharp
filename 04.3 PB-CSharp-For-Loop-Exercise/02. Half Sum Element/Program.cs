int n = int.Parse(Console.ReadLine());

int firstNumber = int.Parse(Console.ReadLine());
int max = firstNumber;
int min = firstNumber;
int sum = firstNumber;

for (int i = 1; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
    if (num > max)
    {
        max = num;
    }
    if (num < min)
    {
        min = num;
    }
}

if (sum - max == max)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + max);
}
else
{
    int diff = Math.Abs(max - (sum - max));
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);
}