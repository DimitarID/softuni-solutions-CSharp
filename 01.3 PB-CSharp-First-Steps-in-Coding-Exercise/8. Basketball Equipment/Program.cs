int fee = int.Parse(Console.ReadLine());

double sneakers = fee * 0.6;
double outfit = sneakers * 0.8;
double ball = outfit * 0.25;
double accessories = ball * 0.2;

double total = fee + sneakers + outfit + ball + accessories;

Console.WriteLine(total);