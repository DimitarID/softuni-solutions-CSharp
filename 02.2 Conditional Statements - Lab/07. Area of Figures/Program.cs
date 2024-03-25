string figure = Console.ReadLine();

if (figure == "square")
{
    double num = double.Parse(Console.ReadLine());
    double result = num * num;
    Console.WriteLine($"{result:F3}");
}
else if (figure == "rectangle")
{
    double num1 = double.Parse(Console.ReadLine());
    double num2 = double.Parse(Console.ReadLine());
    double result = num1 * num2;
    Console.WriteLine($"{result:F3}");
}
else if (figure == "circle")
{
    double num = double.Parse(Console.ReadLine());
    double result = Math.PI * num * num;
    Console.WriteLine($"{result:F3}");
}
else if (figure == "triangle")
{
    double num1 = double.Parse(Console.ReadLine());
    double num2 = double.Parse(Console.ReadLine());
    double result = num1 * num2 / 2;
    Console.WriteLine($"{result:F3}");
}