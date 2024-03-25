double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double capacity = (length *  width * height) / 1000;

double liters = capacity * ((100.0 - percentage) / 100);

Console.WriteLine(liters);