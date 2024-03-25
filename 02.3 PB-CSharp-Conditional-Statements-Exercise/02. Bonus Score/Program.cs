int num = int.Parse(Console.ReadLine());

double bonus = 0.0;

if (num <= 100)
{
    bonus = bonus + 5;
}
else if (num > 100 &&  num <= 1000)
{
    bonus = num * 0.2;
}
else if (num > 1000)
{
    bonus = num * 0.1;
}

if (num % 2  == 0)
{
    bonus = bonus + 1;
}
else if (num % 10 == 5)
{
    bonus = bonus + 2;
}

Console.WriteLine(bonus);
Console.WriteLine(bonus + num);