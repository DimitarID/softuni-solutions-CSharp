double depositSum = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double noun  = double.Parse(Console.ReadLine());

double nounTotal = depositSum * noun / 100;

double nounMonth = nounTotal / 12;

double totalSum = depositSum + months * nounMonth;

Console.WriteLine(totalSum);