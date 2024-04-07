double N1 = double.Parse(Console.ReadLine());
double N2 = double.Parse(Console.ReadLine());
string symbol = Console.ReadLine();

double result = 0;
string oddOrEven = "";

if  (symbol == "+")
{
    result = N1 + N2;
    if (result % 2 == 0)
    {
        oddOrEven = "even";
    }
    else
    {
        oddOrEven = "odd";
    }
    Console.WriteLine($"{N1} + {N2} = {result} - {oddOrEven}");
}
else if (symbol == "-")
{
    result = N1 - N2;
    if (result % 2 == 0)
    {
        oddOrEven = "even";
    }
    else
    {
        oddOrEven = "odd";
    }
    Console.WriteLine($"{N1} - {N2} = {result} - {oddOrEven}");
}
else if (symbol == "*")
{
    result = N1 * N2;
    if (result % 2 == 0)
    {
        oddOrEven = "even";
    }
    else
    {
        oddOrEven = "odd";
    }
    Console.WriteLine($"{N1} * {N2} = {result} - {oddOrEven}");
}
else if (symbol == "/")
{
    if (N2 == 0)
    {
        Console.WriteLine($"Cannot divide {N1} by zero");
    }
    else
    {
        result = N1 / N2;
        Console.WriteLine($"{N1} / {N2} = {result:f2}");
    }
}
else if (symbol == "%")
{
    if (N2 == 0)
    {
        Console.WriteLine($"Cannot divide {N1} by zero");
    }
    else
    {
        result = N1 % N2;
        Console.WriteLine($"{N1} % {N2} = {result}");
    }
        
}