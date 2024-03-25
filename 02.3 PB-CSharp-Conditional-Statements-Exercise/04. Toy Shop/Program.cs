double tripPrice = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double totalPrice = (puzzles * 2.60) + (dolls * 3.00) + (bears * 4.10) + (minions * 8.20) + (trucks * 2.00);
int toysCount = puzzles + dolls + bears + minions + trucks;

if (toysCount >= 50)
{
    totalPrice = totalPrice * 0.75;
}

totalPrice = totalPrice * 0.90;


if  (totalPrice >= tripPrice)
{
    double result = totalPrice - tripPrice;
    Console.WriteLine($"Yes! {result:f2} lv left.");
}
else
{
    double result = tripPrice - totalPrice;
    Console.WriteLine($"Not enough money! {result:f2} lv needed.");
}