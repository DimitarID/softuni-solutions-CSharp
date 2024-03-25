int dogsFood = int.Parse(Console.ReadLine());
int catsFood = int.Parse(Console.ReadLine());

double sumDogsFood = dogsFood * 2.50;
double sumCatsFod = catsFood * 4;

double totalSum = sumDogsFood + sumCatsFod;

Console.WriteLine($"{totalSum} lv.");