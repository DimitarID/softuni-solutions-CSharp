int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegMenu = int.Parse(Console.ReadLine());

double menuPrice = (chickenMenu * 10.35) + (fishMenu * 12.4) + (vegMenu * 8.15);

double dessertPirce = menuPrice * 0.2;

double totalPrice = menuPrice + dessertPirce + 2.50;

Console.WriteLine(totalPrice);