int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylonPrice = (nylon + 2) * 1.50;
double paintPrice = (paint + (paint * 0.1)) * 14.50;
double thinnerPrice = thinner * 5.00;

double materialsPrice = nylonPrice + paintPrice + thinnerPrice + 0.40;

double workPrice = (materialsPrice * 0.3) * 8;

Console.WriteLine(materialsPrice + workPrice);