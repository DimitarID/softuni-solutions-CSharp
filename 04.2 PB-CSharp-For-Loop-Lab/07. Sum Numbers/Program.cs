int number = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 1; i <= number; i++)
{
    double num2 = double.Parse(Console.ReadLine());
    sum += num2;
}
Console.WriteLine(sum);